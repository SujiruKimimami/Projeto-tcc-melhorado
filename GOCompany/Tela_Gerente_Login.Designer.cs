namespace GO
{
    partial class Tela_Gerente_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSenhaFuncionario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nmrIdentificadorFuncionario = new NumericUpDown();
            btnAcessar = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrIdentificadorFuncionario).BeginInit();
            SuspendLayout();
            // 
            // txtSenhaFuncionario
            // 
            txtSenhaFuncionario.Location = new Point(65, 120);
            txtSenhaFuncionario.MaxLength = 30;
            txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            txtSenhaFuncionario.Size = new Size(175, 23);
            txtSenhaFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 44);
            label1.Name = "label1";
            label1.Size = new Size(307, 18);
            label1.TabIndex = 2;
            label1.Text = "Insira seu dígito Identificador de funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 99);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // nmrIdentificadorFuncionario
            // 
            nmrIdentificadorFuncionario.Font = new Font("Segoe UI", 10F);
            nmrIdentificadorFuncionario.Location = new Point(65, 65);
            nmrIdentificadorFuncionario.Margin = new Padding(3, 4, 3, 4);
            nmrIdentificadorFuncionario.Name = "nmrIdentificadorFuncionario";
            nmrIdentificadorFuncionario.Size = new Size(174, 25);
            nmrIdentificadorFuncionario.TabIndex = 4;
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.Azure;
            btnAcessar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = Color.Black;
            btnAcessar.Location = new Point(65, 161);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(128, 39);
            btnAcessar.TabIndex = 5;
            btnAcessar.Text = "Acessar conta";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // Tela_Entrar_Gerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(459, 256);
            Controls.Add(btnAcessar);
            Controls.Add(nmrIdentificadorFuncionario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenhaFuncionario);
            Name = "Tela_Entrar_Gerente";
            Text = "Login do gerente";
            ((System.ComponentModel.ISupportInitialize)nmrIdentificadorFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenhaFuncionario;
        private Label label1;
        private Label label2;
        private NumericUpDown nmrIdentificadorFuncionario;
        private Button btnAcessar;
    }
}