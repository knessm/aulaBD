using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AulaBd
{
    class Cliente
    {
        public string CPF {
            get;
            private set;
        }
        public string Nome { 
            get;
            set;
        }
        public string endereco {
            get;
            set;
        }
        public Cliente(string CPF, string Nome, string endereco)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.endereco = endereco;  
        }
    }
}
