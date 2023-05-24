using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    class ConexaoString
    {
        string serverName = "localhost"; // localhost - servidor pessoal
        string port = "5432"; // porta default
        string userName = "postgres"; // nome do administrador
        string password = "123456789"; // Senha do SGDB
        string dataBaseName = "dbcolegio"; // Nome do Banco de Dados

        public string ConnString()
        {
            var connString = "Server =" + serverName + ";Port = " + port + ";Username = " + userName + ";Password=" + password +
                 ";Database=" + dataBaseName + ";";

            return connString;
        }
    }
}
