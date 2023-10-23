using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Academia
{
    internal class Dados
    {
        private ConexaoDados cDados = new ConexaoDados();

        private int id;
        private string nome;
        private string idade;
        private int plano;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Idade { get => idade; set => idade = value; }
        public int Plano { get => plano; set => plano = value; }

        public void Cadastrar()
        {
            string sql = $"Insert into Cadastro (Nome, DataNasc, Plano) " +
            $"values ('{Nome}','{Idade}','{Plano}')";
            cDados.Executar(sql);
        }

        public void Alterar()
        {
            string sql = $"UPDATE Cadastro SET Plano = '{Plano}' WHERE Id = " + Id.ToString();
            cDados.Executar(sql);
        }

        public void Excluir()
        {
            string sql = $"DELETE Cadastro WHERE Id = " + Id.ToString();
            cDados.Executar(sql);
        }

        public void PesquisaID()
        {

            string sql = $"Select * from Cadastro where Id = " + id.ToString();
            cDados.ConsultarID(sql);
            string[] vetorCampos = cDados.Campos.Split(';');
            Idade = vetorCampos[2];
            Plano = int.Parse(vetorCampos[3]);
        }

        public DataSet PesquisaDados()
        {
            string sql = $"SELECT * FROM Cadastro";
            return cDados.ListarDados(sql);
        }

        public DataSet PesquisaPorNome()
        {
            string sql = $"SELECT Nome, DataNasc, Plano FROM Cadastro WHERE Nome LIKE '%'+'{nome}'+'%'";
            return cDados.ListarDados(sql);
        }

        public DataSet PesquisaPorIdade()
        {
            string sql = $"SELECT Nome, DataNasc, Plano FROM Cadastro WHERE year(DataNasc) = '{Idade}'";
            return cDados.ListarDados(sql);
        }

        public DataSet PesquisaPorPlano()
        {
            string sql = $"SELECT Nome, DataNasc, Plano FROM Cadastro WHERE Plano = '{Plano}'";
            return cDados.ListarDados(sql);
        }

        public DataSet PesquisaPlanos()
        {
            string sql = $"SELECT DISTINCT(Plano) FROM Cadastro";
            return cDados.ListarDados(sql);
        }
    }
}
