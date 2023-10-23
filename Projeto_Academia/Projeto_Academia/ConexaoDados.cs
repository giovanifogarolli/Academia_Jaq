using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Academia
{
    internal class ConexaoDados
    {

        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        public string Campos;
        public void Conectar()
        {
            string aux = "Server = Giovani\\SQLEXPRESS; Database = Academia; UID = sa; PWD = 123";
            conn.ConnectionString = aux;
            conn.Open();
        }

        public void Desconectar()
        {
            conn.Close();
        }

        public void Executar(string sql)
        {
            Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            Desconectar();
        }
        public void ConsultarID(string sql)
        {
            Conectar();

            cmd.Connection = conn;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            Campos = $"";

            if (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Campos += dr[i].ToString() + ";";
                }
            }
            Desconectar();

        }

        public DataSet ListarDados(string sql)
        {
            Conectar();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Desconectar();
            return ds;
        }
    }
}
