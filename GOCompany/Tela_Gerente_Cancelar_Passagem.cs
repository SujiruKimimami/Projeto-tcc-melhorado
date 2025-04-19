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
    public partial class Tela_Gerente_Cancelar_Passagem : Form
    {
        Consultas_toSqlServer consultas;
        public Tela_Gerente_Cancelar_Passagem()
        {
            InitializeComponent();
            consultas = new Consultas_toSqlServer(string.Empty);
        }

        private void btnCancelarViagem_Click(object sender, EventArgs e)
        {
            string viagemCancelada = consultas.Deletar_Registro(nmrIdentificador.Value);
            if (viagemCancelada != string.Empty)
                MessageBox.Show($"A viagem para {viagemCancelada} do identificador de numero '{nmrIdentificador.Value}' " +
                    $"foi cancelada com excelência (Confira a tabela de passagens canceladas para maiores informações)",
                    "Passagem encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);                                                        
            
        }
    }
}
