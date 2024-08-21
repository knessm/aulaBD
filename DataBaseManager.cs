using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace AulaBd
{
    class DataBaseManager
    {
        public string stringDeConexao;

        public DataBaseManager(string nomeBanco)
        {
            stringDeConexao = "server=localhost;database=" + nomeBanco +
            ";uid=root;pwd='';SSL Mode = None";
        }

        public void Cadastrar(string comando)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand(comando, conexao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente cadastrado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        public DataTable ConsultarBanco(string comandoDQL)
        {
            try
            {
                using(MySqlConnection conexao = new MySqlConnection(stringDeConexao))
                {
                    DataTable tabela;
                    MySqlCommand comando = new MySqlCommand(comandoDQL, conexao);
                    using (MySqlDataReader leitor = comando.ExecuteReader())
                    {
                        tabela = new DataTable();
                        tabela.Load(leitor);
                    }
                    return tabela;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}


