using MySql.Data.X.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Filename: SearchPillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to search for a pill through its imprint
* History:
*           5/17/2020 - form created and form layout made. RRS
*/

namespace PillIdentifier
{
    public partial class SearchPillForm : Form
    {

        private PillForm pillForm; //reference to pillForm
        private readonly SearchType searchType; //holds if the search was done to modify a pill 
                                                //or to Identify a pill (display its information)
        
        public SearchPillForm(PillForm pillForm, SearchType searchType)
        {
            InitializeComponent();

            this.pillForm = pillForm;
            this.searchType = searchType;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void pillNotFound()
        {
            MessageBox.Show("Error: pill was not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pillFound()
        {
            ModifyPillForm modifyForm = new ModifyPillForm(pillForm);

            pillForm.Hide();
            modifyForm.Show();
            this.Close();
        }
    }
}
