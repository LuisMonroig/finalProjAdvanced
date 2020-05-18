using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/*
* Filename: PillDB.cs
* Author: Ricardo J. Ramirez Santiago
* Description: database for the pill app
* History:
*           5/14/2020 - File created. RRS
*           5/17/2020 - added open and close connection functionality. RRS
*/

namespace PillIdentifier
{
    public class PillDB
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string username;
        private string password;

        public string Username {set => username = value; }
        public string Password {set => password = value; }

        public PillDB()
        {
            this.server = "localhost";
            this.database = "pharma";
            this.Username = "";
            this.Password = "";
        }

        //TODO: add connection already open check
        //opens a connection to the database
        public void OpenConnection()
        {
            string connectionSettings = String.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};",
                server, database, username, password);

            connection = new MySqlConnection(connectionSettings);

            //throws an exceptino if cannot connect to the server or if the username
            //or password is invalid
            connection.Open();
        }

        public void CloseConneciton()
        {
            connection.Close();
        }
    }
}
