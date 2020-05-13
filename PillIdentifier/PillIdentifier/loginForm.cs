using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using MySql.Data.MySqlClient; I dunno the path, look it up

/*
* Filename: loginForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: login form for a user
* History:
*           5/10/2020 - File created. RRS
*           5/12/2020 - login layout made. RRS
*/

namespace PillIdentifier
{
    public partial class loginForm : Form
    {
        //TODO: implement mysql connection

        public loginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            //default entry for testing
            if(username == "root" && password == "password")
            {
                OpenPillAppForm();
            }

            else
            {

            }
        }

        private void OpenPillAppForm()
        {
            PillForm pillForm = new PillForm();
            pillForm.Show();
            Hide();
        }
    }
}
