using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO
{
    public partial class Tela_Gerente_Cadastrar_Passagem : Form
    {
        ToolTip mensagem = new ToolTip();
        Consultas_toSqlServer consultas;
        public Tela_Gerente_Cadastrar_Passagem()
        {
            InitializeComponent();
            consultas = new Consultas_toSqlServer(string.Empty);
        }

        private void pbImagem_MouseHover(object sender, EventArgs e)
        {
            mensagem.Show("Clique para selecionar imagem. (372px;154px)", pbImagemDestino);
        }

        private void pbImagem_Click(object sender, EventArgs e)
        {
            arquivo.Filter = "Imagens (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                pbImagemDestino.BackgroundImage = Image.FromFile(@arquivo.FileName);
                pbImagemDestino.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
                MessageBox.Show(
                "Nenhum arquivo selecionado ou o arquivo selecionado não é do tipo imagem",
                "Houve algum erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop
            );

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        //talvez eu coloque passagens de graça
        {

            if ( txtDestino.Text != string.Empty && txtLocalPartida.Text != string.Empty)
            {

                byte[] imagemDestinoBytes = Converter_de_imagem_para_byte();
                consultas.Inserir_na_tabela_passagens(imagemDestinoBytes, Convert.ToInt32(nmrPilotoId.Value), Convert.ToInt32(nmrCopilotoId.Value),
     Convert.ToInt32(nmrAeromoca1Id.Value), Convert.ToInt32(nmrAeromoca2Id.Value), Convert.ToInt32(nmrAeromoca3Id.Value), nmrValorEconomicaPassagem.Value,
     nmrValorLuxoPassagem.Value, txtDestino.Text, txtLocalPartida.Text);
                MessageBox.Show($"Sua passagem para {txtDestino.Text} foi inserida com sucesso!",
                    "passagem efetuada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Todos os campos devem estar preenchidos corretamente!",
                    "Houve algum erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }
        private byte[] Converter_de_imagem_para_byte()
        {
            Image img = Image.FromFile(arquivo.FileName);
            MemoryStream stream = new MemoryStream();

            img.Save(stream, img.RawFormat);
            return stream.ToArray(); // o arquivo recebebidor é byte


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void arquivo_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
