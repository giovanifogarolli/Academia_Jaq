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
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        Dados d1 = new Dados();
        ConexaoDados cDados = new ConexaoDados();

        private void btnNome_Click(object sender, EventArgs e)
        {
            d1.Nome = cmbNome.Text;
            dgvNome.DataSource = d1.PesquisaPorNome().Tables[0];
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            cmbNome.DisplayMember = "Nome";
            cmbNome.ValueMember = "Id";
            cmbNome.DataSource = d1.PesquisaDados().Tables[0];

            cmbPlano.DisplayMember = "Plano";
            cmbPlano.ValueMember = "Plano";
            cmbPlano.DataSource = d1.PesquisaPlanos().Tables[0];
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            int idade = DateTime.Now.Year - int.Parse(txtIdade.Text);
            d1.Idade = idade.ToString();
            dgvIdade.DataSource = d1.PesquisaPorIdade().Tables[0];
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            d1.Plano = int.Parse(cmbPlano.Text);
            dgvPlano.DataSource = d1.PesquisaPorPlano().Tables[0];
        }
    }
}
