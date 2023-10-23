using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_Academia
{
    public partial class frmExcluir : Form
    {

        Dados d1 = new Dados();
        private int id;
        private int idade;

        public frmExcluir()
        {
            InitializeComponent();
        }

        private void frmExcluir_Load(object sender, EventArgs e)
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

        private void btnE_Click(object sender, EventArgs e)
        {
            d1.Excluir();
            MessageBox.Show("Excluido com sucesso!");
        }
    }
}
