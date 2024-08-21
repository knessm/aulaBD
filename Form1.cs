using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AulaBd
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            string stringdeconexao = "server = localhost; database = cadastrobd; uid = root; pwd = ''; SSL Mode = None";
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(stringdeconexao))
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("Insert into CLIENTE(CPF,NOME,ENDERECO) values (@CPF,@NOME,@ENDERECO)", conexao);
                    cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta pag = new Consulta();
            pag.ShowDialog();
        }
    }
}
