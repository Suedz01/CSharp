using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios
{
    class Conexao
    {
        NpgsqlConnection con = new NpgsqlConnection("Server = localhost; Port = 5432;Username = postgres; " +
                                                    "Password = 123456789; Database = dbescola");
        public void getConectar()
        {
            con.Open();
            MessageBox.Show("Conectado");
        }
    }
}
