using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoNariz.Classes
{
    class ConectaBanco
    {
        public  SqlConnection AbreBanco()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projetos\DesktopRato\ProjetoNariz\ProjetoNariz\Banco\BD.mdf;Integrated Security=True;Connect Timeout=30";
            conexao.Open();
            return conexao;
        }

        public  SqlDataReader ExecutaConsulta(string SQL)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = SQL;

            comando.Connection = AbreBanco();

            return comando.ExecuteReader();
        }
        public void ExecutaComando(string SQL)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = SQL;
            comando.Connection = AbreBanco();

            comando.ExecuteNonQuery();
        }

        public SqlConnection FechaBanco()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.Close();
            return conexao;
        }
    }
}
