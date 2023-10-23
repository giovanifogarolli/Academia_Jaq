namespace Projeto_Academia
{
    partial class Form2
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
            lblA = new Label();
            cbxA = new ComboBox();
            gpbP = new GroupBox();
            ckbC = new CheckBox();
            ckbP = new CheckBox();
            ckbS = new CheckBox();
            gpbD = new GroupBox();
            ckbG = new CheckBox();
            ckbR = new CheckBox();
            ckbPC = new CheckBox();
            gpbMI = new GroupBox();
            ckbAg = new CheckBox();
            ckbAb = new CheckBox();
            ckbAd = new CheckBox();
            ckbF = new CheckBox();
            ckbEx = new CheckBox();
            ckbLP = new CheckBox();
            gpbBC = new GroupBox();
            ckbRi = new CheckBox();
            ckbRs = new CheckBox();
            ckbRD = new CheckBox();
            gpbT = new GroupBox();
            ckbTi = new CheckBox();
            ckbTT = new CheckBox();
            ckbTp = new CheckBox();
            btnS = new Button();
            lblId = new Label();
            lblP = new Label();
            txtbId = new TextBox();
            txtbP = new TextBox();
            lblSalvo = new Label();
            gpbP.SuspendLayout();
            gpbD.SuspendLayout();
            gpbMI.SuspendLayout();
            gpbBC.SuspendLayout();
            gpbT.SuspendLayout();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(12, 9);
            lblA.Name = "lblA";
            lblA.Size = new Size(42, 15);
            lblA.TabIndex = 12;
            lblA.Text = "Aluno:";
            // 
            // cbxA
            // 
            cbxA.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxA.FormattingEnabled = true;
            cbxA.Location = new Point(60, 6);
            cbxA.Name = "cbxA";
            cbxA.Size = new Size(255, 23);
            cbxA.TabIndex = 13;
            cbxA.SelectedIndexChanged += cbxA_SelectedIndexChanged;
            // 
            // gpbP
            // 
            gpbP.Controls.Add(ckbC);
            gpbP.Controls.Add(ckbP);
            gpbP.Controls.Add(ckbS);
            gpbP.Location = new Point(12, 73);
            gpbP.Name = "gpbP";
            gpbP.Size = new Size(200, 151);
            gpbP.TabIndex = 14;
            gpbP.TabStop = false;
            gpbP.Tag = "Checkbox";
            gpbP.Text = "Peitoral";
            // 
            // ckbC
            // 
            ckbC.AutoSize = true;
            ckbC.Location = new Point(6, 104);
            ckbC.Name = "ckbC";
            ckbC.Size = new Size(74, 19);
            ckbC.TabIndex = 2;
            ckbC.Text = "Crucifixo";
            ckbC.UseVisualStyleBackColor = true;
            // 
            // ckbP
            // 
            ckbP.AutoSize = true;
            ckbP.Location = new Point(6, 68);
            ckbP.Name = "ckbP";
            ckbP.Size = new Size(74, 19);
            ckbP.TabIndex = 1;
            ckbP.Text = "Pec Deck";
            ckbP.UseVisualStyleBackColor = true;
            // 
            // ckbS
            // 
            ckbS.AutoSize = true;
            ckbS.Location = new Point(6, 32);
            ckbS.Name = "ckbS";
            ckbS.Size = new Size(63, 19);
            ckbS.TabIndex = 0;
            ckbS.Text = "Supino";
            ckbS.UseVisualStyleBackColor = true;
            // 
            // gpbD
            // 
            gpbD.Controls.Add(ckbG);
            gpbD.Controls.Add(ckbR);
            gpbD.Controls.Add(ckbPC);
            gpbD.Location = new Point(12, 248);
            gpbD.Name = "gpbD";
            gpbD.Size = new Size(200, 132);
            gpbD.TabIndex = 15;
            gpbD.TabStop = false;
            gpbD.Tag = "Checkbox";
            gpbD.Text = "Dorsal";
            // 
            // ckbG
            // 
            ckbG.AutoSize = true;
            ckbG.Location = new Point(6, 104);
            ckbG.Name = "ckbG";
            ckbG.Size = new Size(71, 19);
            ckbG.TabIndex = 5;
            ckbG.Text = "Graviton";
            ckbG.UseVisualStyleBackColor = true;
            // 
            // ckbR
            // 
            ckbR.AutoSize = true;
            ckbR.Location = new Point(6, 68);
            ckbR.Name = "ckbR";
            ckbR.Size = new Size(103, 19);
            ckbR.TabIndex = 4;
            ckbR.Text = "Remo Sentado";
            ckbR.UseVisualStyleBackColor = true;
            // 
            // ckbPC
            // 
            ckbPC.AutoSize = true;
            ckbPC.Location = new Point(6, 32);
            ckbPC.Name = "ckbPC";
            ckbPC.Size = new Size(96, 19);
            ckbPC.TabIndex = 3;
            ckbPC.Text = "Pulley Costas";
            ckbPC.UseVisualStyleBackColor = true;
            // 
            // gpbMI
            // 
            gpbMI.Controls.Add(ckbAg);
            gpbMI.Controls.Add(ckbAb);
            gpbMI.Controls.Add(ckbAd);
            gpbMI.Controls.Add(ckbF);
            gpbMI.Controls.Add(ckbEx);
            gpbMI.Controls.Add(ckbLP);
            gpbMI.Location = new Point(273, 73);
            gpbMI.Name = "gpbMI";
            gpbMI.Size = new Size(200, 307);
            gpbMI.TabIndex = 16;
            gpbMI.TabStop = false;
            gpbMI.Tag = "Checkbox";
            gpbMI.Text = "Musculos inferiores";
            // 
            // ckbAg
            // 
            ckbAg.AutoSize = true;
            ckbAg.Location = new Point(6, 279);
            ckbAg.Name = "ckbAg";
            ckbAg.Size = new Size(101, 19);
            ckbAg.TabIndex = 8;
            ckbAg.Text = "Agachamento";
            ckbAg.UseVisualStyleBackColor = true;
            // 
            // ckbAb
            // 
            ckbAb.AutoSize = true;
            ckbAb.Location = new Point(6, 243);
            ckbAb.Name = "ckbAb";
            ckbAb.Size = new Size(76, 19);
            ckbAb.TabIndex = 7;
            ckbAb.Text = "Abdutora";
            ckbAb.UseVisualStyleBackColor = true;
            // 
            // ckbAd
            // 
            ckbAd.AutoSize = true;
            ckbAd.Location = new Point(6, 207);
            ckbAd.Name = "ckbAd";
            ckbAd.Size = new Size(69, 19);
            ckbAd.TabIndex = 6;
            ckbAd.Text = "Adutora";
            ckbAd.UseVisualStyleBackColor = true;
            // 
            // ckbF
            // 
            ckbF.AutoSize = true;
            ckbF.Location = new Point(6, 104);
            ckbF.Name = "ckbF";
            ckbF.Size = new Size(64, 19);
            ckbF.TabIndex = 5;
            ckbF.Text = "Flexora";
            ckbF.UseVisualStyleBackColor = true;
            // 
            // ckbEx
            // 
            ckbEx.AutoSize = true;
            ckbEx.Location = new Point(6, 68);
            ckbEx.Name = "ckbEx";
            ckbEx.Size = new Size(77, 19);
            ckbEx.TabIndex = 4;
            ckbEx.Text = "Extensora";
            ckbEx.UseVisualStyleBackColor = true;
            // 
            // ckbLP
            // 
            ckbLP.AutoSize = true;
            ckbLP.Location = new Point(6, 32);
            ckbLP.Name = "ckbLP";
            ckbLP.Size = new Size(75, 19);
            ckbLP.TabIndex = 3;
            ckbLP.Text = "Leg Press";
            ckbLP.UseVisualStyleBackColor = true;
            // 
            // gpbBC
            // 
            gpbBC.Controls.Add(ckbRi);
            gpbBC.Controls.Add(ckbRs);
            gpbBC.Controls.Add(ckbRD);
            gpbBC.Location = new Point(533, 73);
            gpbBC.Name = "gpbBC";
            gpbBC.Size = new Size(200, 151);
            gpbBC.TabIndex = 17;
            gpbBC.TabStop = false;
            gpbBC.Tag = "Checkbox";
            gpbBC.Text = "Biceps";
            // 
            // ckbRi
            // 
            ckbRi.AutoSize = true;
            ckbRi.Location = new Point(6, 104);
            ckbRi.Name = "ckbRi";
            ckbRi.Size = new Size(63, 19);
            ckbRi.TabIndex = 5;
            ckbRi.Text = "Isolada";
            ckbRi.UseVisualStyleBackColor = true;
            // 
            // ckbRs
            // 
            ckbRs.AutoSize = true;
            ckbRs.Location = new Point(6, 68);
            ckbRs.Name = "ckbRs";
            ckbRs.Size = new Size(85, 19);
            ckbRs.TabIndex = 4;
            ckbRs.Text = "Rosta Scott";
            ckbRs.UseVisualStyleBackColor = true;
            // 
            // ckbRD
            // 
            ckbRD.AutoSize = true;
            ckbRD.Location = new Point(6, 32);
            ckbRD.Name = "ckbRD";
            ckbRD.Size = new Size(91, 19);
            ckbRD.TabIndex = 3;
            ckbRD.Text = "Rosca Direta";
            ckbRD.UseVisualStyleBackColor = true;
            // 
            // gpbT
            // 
            gpbT.Controls.Add(ckbTi);
            gpbT.Controls.Add(ckbTT);
            gpbT.Controls.Add(ckbTp);
            gpbT.Location = new Point(533, 248);
            gpbT.Name = "gpbT";
            gpbT.Size = new Size(200, 132);
            gpbT.TabIndex = 18;
            gpbT.TabStop = false;
            gpbT.Tag = "Checkbox";
            gpbT.Text = "Triceps";
            // 
            // ckbTi
            // 
            ckbTi.AutoSize = true;
            ckbTi.Location = new Point(6, 104);
            ckbTi.Name = "ckbTi";
            ckbTi.Size = new Size(64, 19);
            ckbTi.TabIndex = 5;
            ckbTi.Text = "Isolado";
            ckbTi.UseVisualStyleBackColor = true;
            // 
            // ckbTT
            // 
            ckbTT.AutoSize = true;
            ckbTT.Location = new Point(6, 68);
            ckbTT.Name = "ckbTT";
            ckbTT.Size = new Size(91, 19);
            ckbTT.TabIndex = 4;
            ckbTT.Text = "Triceps Testa";
            ckbTT.UseVisualStyleBackColor = true;
            // 
            // ckbTp
            // 
            ckbTp.AutoSize = true;
            ckbTp.Location = new Point(6, 32);
            ckbTp.Name = "ckbTp";
            ckbTp.Size = new Size(97, 19);
            ckbTp.TabIndex = 3;
            ckbTp.Text = "Triceps Pulley";
            ckbTp.UseVisualStyleBackColor = true;
            // 
            // btnS
            // 
            btnS.Location = new Point(700, 407);
            btnS.Name = "btnS";
            btnS.Size = new Size(75, 23);
            btnS.TabIndex = 19;
            btnS.Text = "Salvar";
            btnS.UseVisualStyleBackColor = true;
            btnS.Click += btnS_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(342, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 15);
            lblId.TabIndex = 20;
            lblId.Text = "Idade:";
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.Location = new Point(433, 9);
            lblP.Name = "lblP";
            lblP.Size = new Size(40, 15);
            lblP.TabIndex = 21;
            lblP.Text = "Plano:";
            // 
            // txtbId
            // 
            txtbId.Location = new Point(387, 6);
            txtbId.Name = "txtbId";
            txtbId.ReadOnly = true;
            txtbId.Size = new Size(32, 23);
            txtbId.TabIndex = 9;
            // 
            // txtbP
            // 
            txtbP.Location = new Point(479, 6);
            txtbP.Name = "txtbP";
            txtbP.ReadOnly = true;
            txtbP.Size = new Size(190, 23);
            txtbP.TabIndex = 22;
            // 
            // lblSalvo
            // 
            lblSalvo.AutoSize = true;
            lblSalvo.ForeColor = Color.Green;
            lblSalvo.Location = new Point(679, 433);
            lblSalvo.Name = "lblSalvo";
            lblSalvo.Size = new Size(109, 15);
            lblSalvo.TabIndex = 23;
            lblSalvo.Text = "Salvo com sucesso!";
            lblSalvo.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSalvo);
            Controls.Add(txtbP);
            Controls.Add(txtbId);
            Controls.Add(lblP);
            Controls.Add(lblId);
            Controls.Add(btnS);
            Controls.Add(gpbT);
            Controls.Add(gpbBC);
            Controls.Add(gpbMI);
            Controls.Add(gpbD);
            Controls.Add(gpbP);
            Controls.Add(cbxA);
            Controls.Add(lblA);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            gpbP.ResumeLayout(false);
            gpbP.PerformLayout();
            gpbD.ResumeLayout(false);
            gpbD.PerformLayout();
            gpbMI.ResumeLayout(false);
            gpbMI.PerformLayout();
            gpbBC.ResumeLayout(false);
            gpbBC.PerformLayout();
            gpbT.ResumeLayout(false);
            gpbT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblA;
        private ComboBox cbxA;
        private GroupBox gpbP;
        private CheckBox ckbC;
        private CheckBox ckbP;
        private CheckBox ckbS;
        private GroupBox gpbD;
        private CheckBox ckbG;
        private CheckBox ckbR;
        private CheckBox ckbPC;
        private GroupBox gpbMI;
        private CheckBox ckbAg;
        private CheckBox ckbAb;
        private CheckBox ckbAd;
        private CheckBox ckbF;
        private CheckBox ckbEx;
        private CheckBox ckbLP;
        private GroupBox gpbBC;
        private CheckBox ckbRi;
        private CheckBox ckbRs;
        private CheckBox ckbRD;
        private GroupBox gpbT;
        private CheckBox ckbTi;
        private CheckBox ckbTT;
        private CheckBox ckbTp;
        private Button btnS;
        private Label lblId;
        private Label lblP;
        private TextBox txtbId;
        private TextBox txtbP;
        private Label lblSalvo;
    }
}