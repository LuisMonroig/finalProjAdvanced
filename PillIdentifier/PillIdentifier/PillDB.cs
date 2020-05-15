using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
* Filename: PillDB.cs
* Author: Ricardo J. Ramirez Santiago
* Description: database for the pill app
* History:
*           5/14/2020 - File created. RRS
*/

namespace PillIdentifier
{
    class PillDB
    {
        private MySqlConnection connection;

        public PillDB()
        {
            //TODO: cambiar el connection setting, ver minuto 24:06 del video de abri 23 del profe
            string connectionSettings = @"conneciton=stuff, aqui es q van los settings del connection";

            connection = new MySqlConnection(connectionSettings);
            connection.Open();
        }
    }
}
