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
*           5/19/2020 - improved code readability. RRS
*/

namespace PillIdentifier
{
    public partial class LoginForm : Form
    {
        PillDB pillDB; //pill database

        public LoginForm()
        {
            InitializeComponent();
            pillDB = new PillDB();
        }

        //attempts login
        private void enterButton_Click(object sender, EventArgs e)
        {
            //stores unsername and password to database
            pillDB.Username = usernameTextBox.Text;
            pillDB.Password = passwordTextBox.Text;

            try
            {
                pillDB.OpenConnection(); //will fail if login information is incorrect
                CorrectLogin();
            }

            catch (ApplicationException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (MySqlException except)
            {
                //mysql exceptions give a number that indicate the error that occured
                int exceptNum;

                //catches error number if the error was an inner error
                if (except.InnerException is MySqlException)
                {
                    exceptNum = ((MySqlException)except.InnerException).Number;
                }
                else
                {
                    exceptNum = except.Number;
                }

                //selects the mysql error that occured
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

                    default:
                        MessageBox.Show("unrecognized MySql error occured", "Unrecognized Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //login correct, proceeds to main app form
        private void CorrectLogin()
        {
            //opens the main application 
            PillForm pillForm = new PillForm(ref pillDB);
            pillForm.Show();

            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
