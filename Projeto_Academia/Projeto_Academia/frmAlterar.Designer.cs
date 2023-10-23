namespace Projeto_Academia
{
    partial class frmAlterar
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
            gpbP = new GroupBox();
            rdbP3 = new RadioButton();
            rdbP2 = new RadioButton();
            rdbP1 = new RadioButton();
            txtbI = new TextBox();
            Lblidade = new Label();
            lblN = new Label();
            btnA = new Button();
            cmbNome = new ComboBox();
            gpbP.SuspendLayout();
            SuspendLayout();
            // 
            // gpbP
            // 
            gpbP.Controls.Add(rdbP3);
            gpbP.Controls.Add(rdbP2);
            gpbP.Controls.Add(rdbP1);
            gpbP.Location = new Point(12, 101);
            gpbP.Name = "gpbP";
            gpbP.Size = new Size(212, 134);
            gpbP.TabIndex = 18;
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
            // txtbI
            // 
            txtbI.Location = new Point(57, 60);
            txtbI.Name = "txtbI";
            txtbI.ReadOnly = true;
            txtbI.Size = new Size(33, 23);
            txtbI.TabIndex = 17;
            // 
            // Lblidade
            // 
            Lblidade.AutoSize = true;
            Lblidade.Location = new Point(12, 63);
            Lblidade.Name = "Lblidade";
            Lblidade.Size = new Size(39, 15);
            Lblidade.TabIndex = 16;
            Lblidade.Text = "Idade:";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Location = new Point(12, 20);
            lblN.Name = "lblN";
            lblN.Size = new Size(43, 15);
            lblN.TabIndex = 13;
            lblN.Text = "Nome:";
            // 
            // btnA
            // 
            btnA.Location = new Point(61, 255);
            btnA.Name = "btnA";
            btnA.Size = new Size(131, 23);
            btnA.TabIndex = 12;
            btnA.Text = "Alterar Cadastro";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // cmbNome
            // 
            cmbNome.FormattingEnabled = true;
            cmbNome.Location = new Point(61, 17);
            cmbNome.Name = "cmbNome";
            cmbNome.Size = new Size(163, 23);
            cmbNome.TabIndex = 20;
            cmbNome.SelectedIndexChanged += cmbNome_SelectedIndexChanged;
            // 
            // frmAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 318);
            Controls.Add(cmbNome);
            Controls.Add(gpbP);
            Controls.Add(txtbI);
            Controls.Add(Lblidade);
            Controls.Add(lblN);
            Controls.Add(btnA);
            Name = "frmAlterar";
            Text = "frmAlterar";
            Load += frmAlterar_Load;
            gpbP.ResumeLayout(false);
            gpbP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbP;
        private RadioButton rdbP3;
        private RadioButton rdbP2;
        private RadioButton rdbP1;
        private TextBox txtbI;
        private Label Lblidade;
        private Label lblN;
        private Button btnA;
        private ComboBox cmbNome;
    }
}