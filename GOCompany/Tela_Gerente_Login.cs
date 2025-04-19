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
    public partial class Tela_Gerente_Login : Form
    {
        Consultas_toSqlServer consulta;
        Tela_Gerente tG = new Tela_Gerente();
        public Tela_Gerente_Login()
        {
            InitializeComponent();
            this.consulta = new Consultas_toSqlServer(string.Empty);
            
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (consulta.Acessar_Conta_Funcionario(Convert.ToInt32(nmrIdentificadorFuncionario.Value), txtSenhaFuncionario.Text))
            {
                tG.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Sinto muito, mas não foi possivel identificar-te como GERENTE de nossa empresa",
                    "Gerente não encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }
    }
}
