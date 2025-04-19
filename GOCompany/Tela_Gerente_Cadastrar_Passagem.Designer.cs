namespace GO
{
    partial class Tela_Gerente_Cadastrar_Passagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Gerente_Cadastrar_Passagem));
            label1 = new Label();
            pbImagemDestino = new PictureBox();
            label3 = new Label();
            nmrValorLuxoPassagem = new NumericUpDown();
            arquivo = new OpenFileDialog();
            btnCadastrar = new Button();
            dtpPartida = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dtpChegada = new DateTimePicker();
            label6 = new Label();
            labelX = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            nmrValorEconomicaPassagem = new NumericUpDown();
            label7 = new Label();
            txtDestino = new TextBox();
            nmrAeromoca3Id = new NumericUpDown();
            nmrAeromoca2Id = new NumericUpDown();
            nmrAeromoca1Id = new NumericUpDown();
            nmrCopilotoId = new NumericUpDown();
            nmrPilotoId = new NumericUpDown();
            cbLocalPartida = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbImagemDestino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorLuxoPassagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorEconomicaPassagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAeromoca3Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAeromoca2Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrAeromoca1Id).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrCopilotoId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmrPilotoId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(12, 189);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 2;
            label1.Text = "Local de partida";
            // 
            // pbImagemDestino
            // 
            pbImagemDestino.BackColor = Color.White;
            pbImagemDestino.BackgroundImageLayout = ImageLayout.Stretch;
            pbImagemDestino.BorderStyle = BorderStyle.FixedSingle;
            pbImagemDestino.Cursor = Cursors.Hand;
            pbImagemDestino.Location = new Point(254, 28);
            pbImagemDestino.Name = "pbImagemDestino";
            pbImagemDestino.Size = new Size(372, 154);
            pbImagemDestino.TabIndex = 4;
            pbImagemDestino.TabStop = false;
            pbImagemDestino.Click += pbImagem_Click;
            pbImagemDestino.MouseHover += pbImagem_MouseHover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(12, 279);
            label3.Name = "label3";
            label3.Size = new Size(146, 19);
            label3.TabIndex = 6;
            label3.Text = "Valor da classe de luxo";
            // 
            // nmrValorLuxoPassagem
            // 
            nmrValorLuxoPassagem.Location = new Point(12, 297);
            nmrValorLuxoPassagem.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrValorLuxoPassagem.Name = "nmrValorLuxoPassagem";
            nmrValorLuxoPassagem.Size = new Size(193, 23);
            nmrValorLuxoPassagem.TabIndex = 7;
            // 
            // arquivo
            // 
            arquivo.FileName = "arquivo1";
            arquivo.FileOk += arquivo_FileOk;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.MediumTurquoise;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(398, 379);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(159, 38);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // dtpPartida
            // 
            dtpPartida.Checked = false;
            dtpPartida.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpPartida.Font = new Font("Segoe UI", 10F);
            dtpPartida.Location = new Point(12, 341);
            dtpPartida.MaxDate = new DateTime(2034, 12, 31, 0, 0, 0, 0);
            dtpPartida.MinDate = new DateTime(2024, 11, 3, 0, 0, 0, 0);
            dtpPartida.Name = "dtpPartida";
            dtpPartida.Size = new Size(193, 25);
            dtpPartida.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(12, 323);
            label4.Name = "label4";
            label4.Size = new Size(147, 19);
            label4.TabIndex = 10;
            label4.Text = "Data e hora da partida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(12, 376);
            label5.Name = "label5";
            label5.Size = new Size(155, 19);
            label5.TabIndex = 12;
            label5.Text = "Data e hora da chegada";
            // 
            // dtpChegada
            // 
            dtpChegada.CustomFormat = "";
            dtpChegada.Font = new Font("Segoe UI", 10F);
            dtpChegada.Location = new Point(11, 398);
            dtpChegada.MaxDate = new DateTime(2034, 12, 31, 0, 0, 0, 0);
            dtpChegada.MinDate = new DateTime(2024, 11, 3, 0, 0, 0, 0);
            dtpChegada.Name = "dtpChegada";
            dtpChegada.Size = new Size(193, 25);
            dtpChegada.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(660, 188);
            label6.Name = "label6";
            label6.Size = new Size(42, 16);
            label6.TabIndex = 14;
            label6.Text = "Piloto";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.BackColor = Color.Transparent;
            labelX.Font = new Font("Microsoft Sans Serif", 10F);
            labelX.ForeColor = Color.DarkBlue;
            labelX.Location = new Point(660, 232);
            labelX.Name = "labelX";
            labelX.Size = new Size(59, 17);
            labelX.TabIndex = 16;
            labelX.Text = "Copiloto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(660, 280);
            label8.Name = "label8";
            label8.Size = new Size(83, 19);
            label8.TabIndex = 18;
            label8.Text = "Aeromoça 1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(660, 324);
            label9.Name = "label9";
            label9.Size = new Size(83, 19);
            label9.TabIndex = 20;
            label9.Text = "Aeromoça 2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.DarkBlue;
            label10.Location = new Point(660, 376);
            label10.Name = "label10";
            label10.Size = new Size(83, 19);
            label10.TabIndex = 22;
            label10.Text = "Aeromoça 3";
            label10.Click += label10_Click;
            // 
            // nmrValorEconomicaPassagem
            // 
            nmrValorEconomicaPassagem.Location = new Point(12, 250);
            nmrValorEconomicaPassagem.Margin = new Padding(3, 28, 3, 28);
            nmrValorEconomicaPassagem.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrValorEconomicaPassagem.Name = "nmrValorEconomicaPassagem";
            nmrValorEconomicaPassagem.Size = new Size(192, 23);
            nmrValorEconomicaPassagem.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(12, 231);
            label7.Name = "label7";
            label7.Size = new Size(167, 19);
            label7.TabIndex = 23;
            label7.Text = "Valor da classe econômica";
            // 
            // txtDestino
            // 
            txtDestino.Font = new Font("Segoe UI", 10F);
            txtDestino.Location = new Point(254, 205);
            txtDestino.Name = "txtDestino";
            txtDestino.PlaceholderText = "Insira aqui seu local de destino";
            txtDestino.Size = new Size(372, 25);
            txtDestino.TabIndex = 25;
            // 
            // nmrAeromoca3Id
            // 
            nmrAeromoca3Id.Location = new Point(660, 397);
            nmrAeromoca3Id.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrAeromoca3Id.Name = "nmrAeromoca3Id";
            nmrAeromoca3Id.Size = new Size(211, 23);
            nmrAeromoca3Id.TabIndex = 26;
            // 
            // nmrAeromoca2Id
            // 
            nmrAeromoca2Id.Location = new Point(660, 342);
            nmrAeromoca2Id.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrAeromoca2Id.Name = "nmrAeromoca2Id";
            nmrAeromoca2Id.Size = new Size(211, 23);
            nmrAeromoca2Id.TabIndex = 27;
            // 
            // nmrAeromoca1Id
            // 
            nmrAeromoca1Id.Location = new Point(660, 298);
            nmrAeromoca1Id.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrAeromoca1Id.Name = "nmrAeromoca1Id";
            nmrAeromoca1Id.Size = new Size(211, 23);
            nmrAeromoca1Id.TabIndex = 28;
            // 
            // nmrCopilotoId
            // 
            nmrCopilotoId.Location = new Point(660, 250);
            nmrCopilotoId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrCopilotoId.Name = "nmrCopilotoId";
            nmrCopilotoId.Size = new Size(211, 23);
            nmrCopilotoId.TabIndex = 29;
            // 
            // nmrPilotoId
            // 
            nmrPilotoId.Location = new Point(660, 208);
            nmrPilotoId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmrPilotoId.Name = "nmrPilotoId";
            nmrPilotoId.Size = new Size(211, 23);
            nmrPilotoId.TabIndex = 30;
            // 
            // cbLocalPartida
            // 
            cbLocalPartida.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLocalPartida.FormattingEnabled = true;
            cbLocalPartida.ImeMode = ImeMode.NoControl;
            cbLocalPartida.Items.AddRange(new object[] { "Aeroporto Internacional do Rio de Janeiro - Galeão – Antonio Carlos Jobim", "Aeroporto Santos Dumont - Rio de Janeiro", "Aeroporto Internacional de Viracopos - Campinas, São Paulo", "Aeroporto de Jacarepaguá - Roberto Marinho", "Aeroporto Internacional de Fortaleza - Pinto Martins (FOR)" });
            cbLocalPartida.Location = new Point(12, 208);
            cbLocalPartida.Name = "cbLocalPartida";
            cbLocalPartida.Size = new Size(193, 23);
            cbLocalPartida.TabIndex = 31;
            // 
            // Tela_Gerente_Cadastrar_Passagem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 464);
            Controls.Add(cbLocalPartida);
            Controls.Add(nmrPilotoId);
            Controls.Add(nmrCopilotoId);
            Controls.Add(nmrAeromoca1Id);
            Controls.Add(nmrAeromoca2Id);
            Controls.Add(nmrAeromoca3Id);
            Controls.Add(txtDestino);
            Controls.Add(nmrValorEconomicaPassagem);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(labelX);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpChegada);
            Controls.Add(label4);
            Controls.Add(dtpPartida);
            Controls.Add(btnCadastrar);
            Controls.Add(nmrValorLuxoPassagem);
            Controls.Add(label3);
            Controls.Add(pbImagemDestino);
            Controls.Add(label1);
            Name = "Tela_Gerente_Cadastrar_Passagem";
            Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pbImagemDestino).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorLuxoPassagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrValorEconomicaPassagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAeromoca3Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAeromoca2Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrAeromoca1Id).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrCopilotoId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmrPilotoId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pbImagemDestino;
        private Label label3;
        private NumericUpDown nmrValorLuxoPassagem;
        private OpenFileDialog arquivo;
        private Button btnCadastrar;
        private DateTimePicker dtpPartida;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpChegada;
        private Label label6;
        private Label labelX;
        private Label label8;
        private Label label9;
        private Label label10;
        private NumericUpDown nmrValorEconomicaPassagem;
        private Label label7;
        private TextBox txtDestino;
        private NumericUpDown nmrAeromoca3Id;
        private NumericUpDown nmrAeromoca2Id;
        private NumericUpDown nmrAeromoca1Id;
        private NumericUpDown nmrCopilotoId;
        private NumericUpDown nmrPilotoId;
        private ComboBox cbLocalPartida;
    }
}