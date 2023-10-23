namespace Projeto_Academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnE = new Button();
            lblN = new Label();
            txtN = new TextBox();
            lblI = new Label();
            Lblidade = new Label();
            txtbI = new TextBox();
            gpbP = new GroupBox();
            rdbP3 = new RadioButton();
            rdbP2 = new RadioButton();
            rdbP1 = new RadioButton();
            dtpN = new DateTimePicker();
            lblCadastro = new Label();
            gpbP.SuspendLayout();
            SuspendLayout();
            // 
            // btnE
            // 
            btnE.Location = new Point(61, 315);
            btnE.Name = "btnE";
            btnE.Size = new Size(131, 23);
            btnE.TabIndex = 2;
            btnE.Text = "Criar Cadastro";
            btnE.UseVisualStyleBackColor = true;
            btnE.Click += btnE_Click;
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(12, 18);
            lblN.Name = "lblN";
            lblN.Size = new Size(43, 15);
            lblN.TabIndex = 3;
            lblN.Text = "Nome:";
            // 
            // txtN
            // 
            txtN.Location = new Point(61, 15);
            txtN.Name = "txtN";
            txtN.Size = new Size(184, 23);
            txtN.TabIndex = 4;
            // 
            // lblI
            // 
            lblI.AutoSize = true;
            lblI.Location = new Point(12, 60);
            lblI.Name = "lblI";
            lblI.Size = new Size(117, 15);
            lblI.TabIndex = 5;
            lblI.Text = "Data de Nascimento:";
            // 
            // Lblidade
            // 
            Lblidade.AutoSize = true;
            Lblidade.Location = new Point(12, 100);
            Lblidade.Name = "Lblidade";
            Lblidade.Size = new Size(39, 15);
            Lblidade.TabIndex = 7;
            Lblidade.Text = "Idade:";
            // 
            // txtbI
            // 
            txtbI.Location = new Point(57, 97);
            txtbI.Name = "txtbI";
            txtbI.ReadOnly = true;
            txtbI.Size = new Size(33, 23);
            txtbI.TabIndex = 8;
            // 
            // gpbP
            // 
            gpbP.Controls.Add(rdbP3);
            gpbP.Controls.Add(rdbP2);
            gpbP.Controls.Add(rdbP1);
            gpbP.Location = new Point(12, 154);
            gpbP.Name = "gpbP";
            gpbP.Size = new Size(212, 134);
            gpbP.TabIndex = 9;
            gpbP.TabStop = false;
            gpbP.Text = "Planos";
            // 
            // rdbP3
            // 
            rdbP3.AutoSize = true;
            rdbP3.Location = new Point(18, 98);
            rdbP3.Name = "rdbP3";
            rdbP3.Size = new Size(143, 19);
            rdbP3.TabIndex = 2;
            rdbP3.TabStop = true;
            rdbP3.Text = "5x na Semana - R$ 200";
            rdbP3.UseVisualStyleBackColor = true;
            // 
            // rdbP2
            // 
            rdbP2.AutoSize = true;
            rdbP2.Location = new Point(18, 64);
            rdbP2.Name = "rdbP2";
            rdbP2.Size = new Size(143, 19);
            rdbP2.TabIndex = 1;
            rdbP2.TabStop = true;
            rdbP2.Text = "3x na Semana - R$ 150";
            rdbP2.UseVisualStyleBackColor = true;
            // 
            // rdbP1
            // 
            rdbP1.AutoSize = true;
            rdbP1.Location = new Point(18, 28);
            rdbP1.Name = "rdbP1";
            rdbP1.Size = new Size(143, 19);
            rdbP1.TabIndex = 0;
            rdbP1.TabStop = true;
            rdbP1.Text = "2x na Semana - R$ 120";
            rdbP1.UseVisualStyleBackColor = true;
            // 
            // dtpN
            // 
            dtpN.Format = DateTimePickerFormat.Short;
            dtpN.Location = new Point(135, 57);
            dtpN.Name = "dtpN";
            dtpN.Size = new Size(89, 23);
            dtpN.TabIndex = 11;
            dtpN.ValueChanged += dtpN_ValueChanged;
            // 
            // lblCadastro
            // 
            lblCadastro.AutoSize = true;
            lblCadastro.ForeColor = Color.Green;
            lblCadastro.Location = new Point(45, 341);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(164, 15);
            lblCadastro.TabIndex = 13;
            lblCadastro.Text = "Cadastro criado com sucesso!";
            lblCadastro.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 372);
            Controls.Add(lblCadastro);
            Controls.Add(dtpN);
            Controls.Add(gpbP);
            Controls.Add(txtbI);
            Controls.Add(Lblidade);
            Controls.Add(lblI);
            Controls.Add(txtN);
            Controls.Add(lblN);
            Controls.Add(btnE);
            Name = "Form1";
            Text = "Form1";
            gpbP.ResumeLayout(false);
            gpbP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnE;
        private Label lblN;
        private TextBox txtN;
        private Label lblI;
        private Label Lblidade;
        private TextBox txtbI;
        private GroupBox gpbP;
        private RadioButton rdbP3;
        private RadioButton rdbP2;
        private RadioButton rdbP1;
        private DateTimePicker dtpN;
        private Label lblCadastro;
    }
}