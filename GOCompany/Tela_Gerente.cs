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
    public partial class Tela_Gerente : Form
    {
        Tela_Gerente_Cadastrar_Passagem newPass;
        Tela_Gerente_Cancelar_Passagem cancelPass;
        public Tela_Gerente()
        {
            InitializeComponent();
            newPass = new();
            cancelPass = new();
        }

        private void btnInserirPassagem_Click(object sender, EventArgs e)
        {
            newPass.Show();
            this.Hide();
        }

        private void btnCancelarPassagem_Click(object sender, EventArgs e)
        {

            cancelPass.Show();
            this.Hide();
        }
    }
}
