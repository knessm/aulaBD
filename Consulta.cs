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
using static System.Net.Mime.MediaTypeNames;

namespace AulaBd
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string comando = "";
            try
            {
                DataBaseManager bd = new DataBaseManager("cadastrobd");
                if(rdButtonNome.Checked == true)
                {
                    comando = string.Format("Select nome,CPF, endereco FROM CLIENTE Where NOME = '{0}'", txtNomeBuscar.Text);
                }
                else if (rdButtonCPF.Checked == true)
                {
                    comando = string.Format("Select nome,CPF, endereco FROM CLIENTE Where CPF  = '{1}'",txtCpfBuscar.Text);                    
                }
                bd.ConsultarBanco(comando);
                DataTable tabela;
                tabela = bd.ConsultarBanco(comando);

                if(tabela.Rows.Count > 0)
                {
                    string nome, CPF;
                    for (int i = 0; i< tabela.Rows.Count; i++)
                    {
                        nome = tabela.Rows[1]["NOME"].ToString();
                        CPF = tabela.Rows[1]["CPF"].ToString();
                        txtNome_C.Text = nome;
                        txtCpf_C.Text = CPF;  
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void rdButtonCPF_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonNome.Checked = false;
        }

        private void rdButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            rdButtonCPF.Checked = false;
        }
    }
}
