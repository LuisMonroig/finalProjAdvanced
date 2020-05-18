using MySql.Data.X.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Filename: SearchPillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to search for a pill through its imprint
* History:
*           5/17/2020 - form created, form layout made, and search and modify functionality added. RRS
*           5/18/2020 - search and identify functionality added. RRS
*/

namespace PillIdentifier
{
    public partial class SearchPillForm : Form
    {

        private PillForm pillForm; //reference to pillForm
        private PillDB pillDB; //reference to pillDB
        private readonly SearchType searchType; //holds if the search was done to modify a pill 
                                                //or to Identify a pill (display its information)
        IPill pill; //stores pill when found
        
        public SearchPillForm(PillForm pillForm, ref PillDB pillDB, SearchType searchType)
        {
            InitializeComponent();

            this.pillForm = pillForm;
            this.pillDB = pillDB;
            this.searchType = searchType;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string imprint = pillImprintTextBox.Text;
                pill = pillDB.SelectPill(imprint);

                pillFound();
            }

            catch (InvalidDataException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pillNotFound()
        {
            MessageBox.Show("Error: pill was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pillFound()
        {
            if (searchType == SearchType.SearchAndIdentify)
            {
                IdentifyPillForm identifyForm = new IdentifyPillForm(pillForm, pill);
                identifyForm.Show();
                this.Close();
            }

            else if (searchType == SearchType.SearchAndModify)
            {
                ModifyPillForm modifyForm = new ModifyPillForm(pillForm, ref pillDB, pill);

                pillForm.Hide();
                modifyForm.Show();
                this.Close();
            }
        }
    }
}
