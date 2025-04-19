using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GO
{
    internal class Consultas_toSqlServer
    {
        // Inserir_na_tabela_passagens há uma observação nessa função
        private readonly SqlConnection conn;
        public Consultas_toSqlServer(string connection)
        {
            try{
                this.conn = new SqlConnection(connection);
                this.conn.Open();
            }catch (InvalidOperationException)
            {
                this.conn = new SqlConnection(@"Server=PC\SQLSERVER2025;database=gocompany;" +
                "Trusted_Connection=True;TrustServerCertificate=True");
                MessageBox.Show("Não foi possível conectar com a stringConnection da classe Funcionario_entrar," +
                    " então utilizamos a conexão padrão",
                    "Prevenção do servidor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (SqlException exSql){

                MessageBox.Show(exSql.Message,
                    "Erro com o Servivodor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
              
            }
        }

        public bool Acessar_Conta_Funcionario(int id, string senha)
        {
            conn.Open();
            string funcaoFuncionario = string.Empty;

            using (SqlCommand consulta = new SqlCommand(@"SELECT funcao FROM gocompany.funcionarios WHERE id = @id AND senha = @senha", conn)){
                SqlDataReader leitor;

                consulta.Parameters.AddWithValue("@id", id);
                consulta.Parameters.AddWithValue("@senha", senha);

                leitor = consulta.ExecuteReader();
                leitor.Read();
                funcaoFuncionario = leitor.GetString("funcao");

                leitor.Close();
                conn.Close();
            }

            if(funcaoFuncionario == "Gerente")
                return true;
            else
                return false;
        }
        public void Inserir_Na_Tabela_Clientes( string nome, string senha, string tipagem, string email, string cpf, string rg,string estado,
            string genero, DateTime dtnasc, int idade)
        {
            // string conectarAoBanco = @"Server=localhost;Database=go;User ID=root;Password=;";
            string cmdInserirNoBanco = @$"INSERT INTO clientes(nome,senha,tipagem,email,cpf,rg,estado,genero,data_nascimento,idade)" 
            + "VALUES(@nome,@senha,@tipagem,@email,@cpf,@rg,@estado,@genero,@dtnasc,@idade)";  
            using (SqlCommand cmd = new SqlCommand(cmdInserirNoBanco, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@tipagem", tipagem);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@genero", genero);
                cmd.Parameters.AddWithValue("@dtnasc", dtnasc);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Inserir_na_tabela_passagens(byte[] imagemDestinoByte,int pilotoId, int copilotoId, int aeromoca1Id, int aeromoca2Id,
            int aeromoca3Id, decimal valorEconomica, decimal valorLuxo, string destino, string localPartida, DateTime dhchegada, DateTime dhpartida)
        {
            conn.Open();
            try 
            {
                using (SqlCommand consulta = new SqlCommand("INSERT INTO gocompany.passagens(imagem_destino, valor_economica, valor_luxo, destino," +
                    " local_partida, data_hora_chegada, data_hora_partida) VALUES(@ImagemDestino, @ValorEconomica, @ValorLuxo, @Destino, @LocalPartida, @dhchegada, @dhpartida)", conn))
                {
                    consulta.Parameters.AddWithValue("@ImagemDestino", imagemDestinoByte);
                  //consulta.Parameters.AddWithValue("@PilotoId", pilotoId);
                  //consulta.Parameters.AddWithValue("@CopilotoId", copilotoId);
                  //consulta.Parameters.AddWithValue("@Aeromoca1Id", aeromoca1Id);
                  //consulta.Parameters.AddWithValue("@Aeromoca2Id", aeromoca2Id);
                  //consulta.Parameters.AddWithValue("@Aeromoca3Id", aeromoca3Id);
                    consulta.Parameters.AddWithValue("@ValorEconomica", valorEconomica);
                    consulta.Parameters.AddWithValue("@ValorLuxo", valorLuxo);
                    consulta.Parameters.AddWithValue("@Destino", destino);
                    consulta.Parameters.AddWithValue("@LocalPartida", localPartida);
                    consulta.Parameters.AddWithValue("@dhchegada", dhchegada);
                    consulta.Parameters.AddWithValue("@dhpartida", dhpartida);


                    consulta.ExecuteNonQuery();
                    MessageBox.Show($"Sua passagem para {destino} foi inserida com sucesso!",
                       "passagem efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException exSql) 
            {
                    MessageBox.Show(exSql.Message,
                        "Erro Com o servidor",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

            }
                
                conn.Close();
        }

        public bool Acessar_Conta_Cliente(string email, string senha)
        {
            bool contaAceita = false;
            conn.Open();
            //SELECT * FROM clientes
            SqlCommand consulta = new SqlCommand(@"SELECT email,senha FROM clientes WHERE email = @email AND senha = @senha",conn);
            SqlDataReader leitor;

            consulta.Parameters.AddWithValue("@email",email);
            consulta.Parameters.AddWithValue("@senha",senha);

            leitor = consulta.ExecuteReader();
            
            if (leitor.Read())
                contaAceita = true;
            
            leitor.Close();
            conn.Close();
            return contaAceita;
        }
      
        public bool Verificar_redundancias_de_dados(string email)
        {
            bool dadoDuplo = false;
            conn.Open();
            SqlCommand consulta = new SqlCommand("SELECT count(email) FROM clientes WHERE email = @email", conn);
            consulta.Parameters.AddWithValue("@email", email);
            if(Convert.ToInt32(consulta.ExecuteScalar())>0)
                dadoDuplo = true;

            conn.Close();
            return dadoDuplo;
        }
        public string Deletar_Registro(decimal identificador)
        {
            string ?passagemCanceladaNome = string.Empty;
            conn.Open();
            try
            {
                SqlCommand comando = new SqlCommand("SELECT destino FROM passagens Where id = @id", conn);
                comando.Parameters.AddWithValue("@id", identificador);
                SqlDataReader leitor = comando.ExecuteReader();
                leitor.Read();
                passagemCanceladaNome = leitor["destino"].ToString();
                leitor.Close();

                SqlCommand comando2 = new SqlCommand("INSERT INTO passagens_canceladas(id_passagens) values(@id)", conn);
                comando2.Parameters.AddWithValue("@id", identificador);
                comando2.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Nenhum registro encontrado", "Houve algum problema",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            conn.Close();
            return passagemCanceladaNome;
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
