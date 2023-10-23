using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projeto_Academia
{
    public partial class Form2 : Form
    {
        Dados d1 = new Dados();
        private int id;
        private int idade;
        public Form2()
        {
            InitializeComponent();
        }

        private void cbxA_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(cbxA.SelectedValue.ToString());
            d1.Id = id;
            d1.PesquisaID();
            idade = DateTime.Parse(d1.Idade.ToString()).Year;
            switch (d1.Plano)
            {
                case 1:
                    {
                        txtbP.Text = "2x na Semana - R$ 120";
                        break;
                    }
                case 2:
                    {
                        txtbP.Text = "3x na Semana - R$ 150";
                        break;
                    }
                case 3:
                    {
                        txtbP.Text = "5x na Semana - R$ 200";
                        break;
                    }
            }
            txtbId.Text = (DateTime.Now.Year - idade).ToString();
        }

        private void btnS_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbxA.DisplayMember = "Nome";
            cbxA.ValueMember = "Id";
            cbxA.DataSource = d1.PesquisaDados().Tables[0];
        }
    }
}
