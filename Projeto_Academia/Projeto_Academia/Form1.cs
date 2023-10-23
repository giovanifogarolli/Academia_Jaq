namespace Projeto_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dados d1 = new Dados();

        private void btnE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtN.Text))
            {
                lblCadastro.Text = "O campo NOME não pode ficar vazio!";
                lblCadastro.ForeColor = Color.Red;
                lblCadastro.Visible = true;
                lblCadastro.Location = new Point(34, 381);
            }
            else
            {
                d1.Nome = txtN.Text;
                d1.Idade = dtpN.Value.Date.ToString("yyyy-MM-dd");
                if (rdbP1.Checked)
                    d1.Plano = 1;
                if (rdbP2.Checked)
                    d1.Plano = 2;
                if (rdbP3.Checked)
                    d1.Plano = 3;
                d1.Cadastrar();
                lblCadastro.Visible = true;
            }
        }

        private static int CalcIdade(DateTime DataNascimento)
        {
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade -= 1;
            }
            return idade;
        }

        private void dtpN_ValueChanged(object sender, EventArgs e)
        {
            int resultado = CalcIdade(dtpN.Value);
            txtbI.Text = resultado.ToString();
        }
    }
}