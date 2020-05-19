using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
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
*           5/18/2020 - added select, update, and insert queries. RRS
*           5/19/2020 - improved code readability. RRS
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

        //closes connection to the database
        public void CloseConneciton()
        {
            connection.Close();
        }

        //inserts a pill into the database
        public void InsertPill(IPill pill)
        { 
            //insert query
            string query = String.Format("INSERT INTO pills VALUES('{0}','{1}','{2}','{3}','{4}', '{5}',TIMESTAMP('{6}'));",
                pill.Imprint, pill.Color, pill.Shape, pill.DrugName, pill.DrugStrength,
                pill.Photo, pill.CreationTimestamp);

            //runs insert
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        //inserts a pill into the database
        public void InsertPill(string imprint, string color, string shape, string drugName, string drugStrength, string photo, string creationTimestamp)
        {

            //insert query
            string query = String.Format("INSERT INTO pills VALUES('{0}','{1}','{2}','{3}','{4}', {5},TIMESTAMP('{6}'));",
                imprint, color, shape, drugName, drugStrength, photo, creationTimestamp);

            //runs insert
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }

        //selects a pill from the database
        public IPill SelectPill(string imprint)
        {
            string query = String.Format("SELECT * FROM pills WHERE pill_imprint = '{0}'", imprint);

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();

            //checks if the pill_imprint is null
            if (dataReader.IsDBNull(0))
            {
                throw new InvalidDataException("Pill not found");
            }

            IPill pill = new Pill(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2),
                dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6));

            dataReader.Close();

            return pill;
        }
        
        //returns all pills from the database
        public List<IPill> SelectAllPills()
        {
            //will hold data of al pills
            List<IPill> pills = new List<IPill>();

            string query = String.Format("SELECT * FROM pills");

            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            //reads information of each pill
            while(dataReader.Read())
            {
                IPill pill = new Pill(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2),
                dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6));

                pills.Add(pill);
            }


            dataReader.Close();

            return pills;
        }

        //updates the data of a pill by its imprint
        public void UpdatePill(IPill pill, string pillOriginalImprint)
        {
            string query = String.Format("UPDATE pills SET pill_imprint='{0}', pill_color='{1}'," +
                " pill_shape='{2}', drug_name='{3}', drug_strength='{4}', pill_photo = '{5}'," +
                "creation_date=TIMESTAMP('{6}') WHERE pill_imprint='{7}'", 
                pill.Imprint, pill.Color, pill.Shape, pill.DrugName, pill.DrugStrength, pill.Photo,
                pill.CreationTimestamp, pillOriginalImprint);

            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
