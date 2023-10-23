using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Academia
{
    public partial class frmAlterar : Form
    {
        Dados d1 = new Dados();
        private int id;
        private int idade;
        public frmAlterar()
        {
            InitializeComponent();
        }

        private void frmAlterar_Load(object sender, EventArgs e)
        {
            cmbNome.DisplayMember = "Nome";
            cmbNome.ValueMember = "Id";
            cmbNome.DataSource = d1.PesquisaDados().Tables[0];
        }

        private void cmbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(cmbNome.SelectedValue.ToString());
            d1.Id = id;
            d1.PesquisaID();
            idade = DateTime.Parse(d1.Idade.ToString()).Year;
            switch (d1.Plano)
            {
                case 1:
                    {
                        rdbP1.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rdbP2.Checked = true;
                        break;
                    }
                case 3:
                    {
                        rdbP3.Checked = true;
                        break;
                    }
            }
            txtbI.Text = (DateTime.Now.Year - idade).ToString();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (rdbP1.Checked)
                d1.Plano = 1;
            if (rdbP2.Checked)
                d1.Plano = 2;
            if (rdbP3.Checked)
                d1.Plano = 3;
            d1.Id = id;
            d1.Alterar();
            MessageBox.Show("Alterado com sucesso.");
        }
    }
}
