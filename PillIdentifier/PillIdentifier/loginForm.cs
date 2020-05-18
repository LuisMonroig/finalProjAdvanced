using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

/*
* Filename: LoginForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: login form for a user
* History:
*           5/10/2020 - File created. RRS
*           5/12/2020 - login layout made. RRS
*           5/17/2020 - added database functionality to login. RRS
*/

namespace PillIdentifier
{
    public partial class LoginForm : Form
    {
        PillDB pillDB;

        public LoginForm()
        {
            InitializeComponent();
            pillDB = new PillDB();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            pillDB.Username = usernameTextBox.Text;
            pillDB.Password = passwordTextBox.Text;

            try
            {
                pillDB.OpenConnection();
                correctLogin();
            }

            catch (ApplicationException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (MySqlException except)
            {
                int exceptNum;

                if (except.InnerException is MySqlException)
                {
                    exceptNum = ((MySqlException)except.InnerException).Number;
                }

                else
                {
                    exceptNum = except.Number;
                }

                //gives the type of error that occrued
                switch (exceptNum)
                {
                    //connection to the server failed
                    case 0:

                        MessageBox.Show("Connection to server failed", "server issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    //invalid username and/or password
                    case 1045:
                        MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void correctLogin()
        {
            //opens the main application 
            PillForm pillForm = new PillForm(ref pillDB);
            pillForm.Show();

            this.Hide();
        }
    }
}
