using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoNariz.Classes
{
    class ConectaMySQL
    {
        public MySqlConnection AbreMySQL()
        {
                MySqlConnection conexao = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;DATABASE=codorna;UID=root;PASSWORD=gerasol2019");
                conexao.Open();
                return conexao;
        }
        public MySqlConnection FechaMySQL()
        {
            MySqlConnection conexao = new MySqlConnection();
            conexao.Close();
            return conexao;
        }
        public void ExecutaComando(string SQL)
        {
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = SQL;

            mySqlCommand.Connection = AbreMySQL();

            mySqlCommand.ExecuteNonQuery();
        }
        public MySqlDataReader ExecutaConsulta(string SQL)
        {
            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = SQL;

            mySqlCommand.Connection = AbreMySQL();

            return mySqlCommand.ExecuteReader();
        }

    }
}