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

        public void InsertPill(IPill pill)
        { 
            //insert query
            string query = String.Format("INSERT INTO pills VALUES('{0}','{1}','{2}','{3}','{4}', null,TIMESTAMP('{5}'));",
                pill.Imprint, pill.Color, pill.Shape, pill.DrugName, pill.DrugStrength,
                pill.CreationTimestamp);

            //runs insert
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public void InsertPill(string imprint, string color, string shape, string drugName, string drugStrength, string creationTimestamp)
        {

            //insert query
            string query = String.Format("INSERT INTO pills VALUES('{0}','{1}','{2}','{3}','{4}', null,'{5}');",
                imprint, color, shape, drugName, drugStrength, creationTimestamp);

            //runs insert
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        public void SelectPill(string imprint)
        {
            string query = String.Format("SELECT * FROM pills WHERE imprint = '{0}'", imprint);

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            IPill pill = new Pill(dataReader["pill_imprint"] + "", dataReader["pill_color"] + "",
                dataReader["pill_shape"] + "", dataReader["drug_name"] + "", dataReader["drug_strength"] + "", 
                dataReader["creation_date"] + "");

            dataReader.Close();
        }
    }
}
