namespace Projeto_Academia
{
    partial class FrmConsulta
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
            tabControl1 = new TabControl();
            tabNome = new TabPage();
            dgvNome = new DataGridView();
            btnNome = new Button();
            cmbNome = new ComboBox();
            tabIdade = new TabPage();
            txtIdade = new TextBox();
            dgvIdade = new DataGridView();
            btnIdade = new Button();
            tabPlano = new TabPage();
            dgvPlano = new DataGridView();
            cmbPlano = new ComboBox();
            btnPlano = new Button();
            tabControl1.SuspendLayout();
            tabNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNome).BeginInit();
            tabIdade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIdade).BeginInit();
            tabPlano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPlano).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabNome);
            tabControl1.Controls.Add(tabIdade);
            tabControl1.Controls.Add(tabPlano);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabNome
            // 
            tabNome.Controls.Add(dgvNome);
            tabNome.Controls.Add(btnNome);
            tabNome.Controls.Add(cmbNome);
            tabNome.Location = new Point(4, 24);
            tabNome.Name = "tabNome";
            tabNome.Padding = new Padding(3);
            tabNome.Size = new Size(792, 420);
            tabNome.TabIndex = 0;
            tabNome.Text = "Nome";
            tabNome.UseVisualStyleBackColor = true;
            // 
            // dgvNome
            // 
            dgvNome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNome.Location = new Point(8, 35);
            dgvNome.Name = "dgvNome";
            dgvNome.RowTemplate.Height = 25;
            dgvNome.Size = new Size(778, 379);
            dgvNome.TabIndex = 2;
            // 
            // btnNome
            // 
            btnNome.Location = new Point(135, 6);
            btnNome.Name = "btnNome";
            btnNome.Size = new Size(75, 23);
            btnNome.TabIndex = 1;
            btnNome.Text = "Consultar";
            btnNome.UseVisualStyleBackColor = true;
            btnNome.Click += btnNome_Click;
            // 
            // cmbNome
            // 
            cmbNome.FormattingEnabled = true;
            cmbNome.Location = new Point(8, 6);
            cmbNome.Name = "cmbNome";
            cmbNome.Size = new Size(121, 23);
            cmbNome.TabIndex = 0;
            // 
            // tabIdade
            // 
            tabIdade.Controls.Add(txtIdade);
            tabIdade.Controls.Add(dgvIdade);
            tabIdade.Controls.Add(btnIdade);
            tabIdade.Location = new Point(4, 24);
            tabIdade.Name = "tabIdade";
            tabIdade.Padding = new Padding(3);
            tabIdade.Size = new Size(792, 420);
            tabIdade.TabIndex = 1;
            tabIdade.Text = "Idade";
            tabIdade.UseVisualStyleBackColor = true;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(8, 7);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 3;
            // 
            // dgvIdade
            // 
            dgvIdade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIdade.Location = new Point(8, 35);
            dgvIdade.Name = "dgvIdade";
            dgvIdade.RowTemplate.Height = 25;
            dgvIdade.Size = new Size(776, 378);
            dgvIdade.TabIndex = 2;
            // 
            // btnIdade
            // 
            btnIdade.Location = new Point(128, 6);
            btnIdade.Name = "btnIdade";
            btnIdade.Size = new Size(75, 23);
            btnIdade.TabIndex = 0;
            btnIdade.Text = "Consultar";
            btnIdade.UseVisualStyleBackColor = true;
            btnIdade.Click += btnIdade_Click;
            // 
            // tabPlano
            // 
            tabPlano.Controls.Add(dgvPlano);
            tabPlano.Controls.Add(cmbPlano);
            tabPlano.Controls.Add(btnPlano);
            tabPlano.Location = new Point(4, 24);
            tabPlano.Name = "tabPlano";
            tabPlano.Size = new Size(792, 420);
            tabPlano.TabIndex = 2;
            tabPlano.Text = "Plano";
            tabPlano.UseVisualStyleBackColor = true;
            // 
            // dgvPlano
            // 
            dgvPlano.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlano.Location = new Point(8, 42);
            dgvPlano.Name = "dgvPlano";
            dgvPlano.RowTemplate.Height = 25;
            dgvPlano.Size = new Size(776, 371);
            dgvPlano.TabIndex = 2;
            // 
            // cmbPlano
            // 
            cmbPlano.FormattingEnabled = true;
            cmbPlano.Location = new Point(8, 13);
            cmbPlano.Name = "cmbPlano";
            cmbPlano.Size = new Size(121, 23);
            cmbPlano.TabIndex = 1;
            // 
            // btnPlano
            // 
            btnPlano.Location = new Point(144, 13);
            btnPlano.Name = "btnPlano";
            btnPlano.Size = new Size(75, 23);
            btnPlano.TabIndex = 0;
            btnPlano.Text = "Consultar";
            btnPlano.UseVisualStyleBackColor = true;
            btnPlano.Click += btnPlano_Click;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FrmConsulta";
            Text = "Form3";
            Load += FrmConsulta_Load;
            tabControl1.ResumeLayout(false);
            tabNome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNome).EndInit();
            tabIdade.ResumeLayout(false);
            tabIdade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIdade).EndInit();
            tabPlano.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPlano).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabNome;
        private DataGridView dgvNome;
        private Button btnNome;
        private ComboBox cmbNome;
        private TabPage tabIdade;
        private DataGridView dgvIdade;
        private Button btnIdade;
        private TabPage tabPlano;
        private DataGridView dgvPlano;
        private Button btnPlano;
        private TextBox txtIdade;
        private ComboBox cmbPlano;
    }
}