using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Filename: PillReportForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to show the information of all pills in the database
* History:
*           5/17/2020 - file created. RRS
*           5/17/2020 - connected data grid view to database. RRS
*           5/18/2020 - changed data grid view size values. RRS
*/

namespace PillIdentifier
{
    public partial class PillReportForm : Form
    {
        private PillForm pillForm; //reference to main pill form
        private PillDB pillDB; //reference to the database

        public PillReportForm(PillForm pillForm, ref PillDB pillDB)
        {
            InitializeComponent();

            this.pillForm = pillForm;
            this.pillDB = pillDB;

            InitializePillDataGridView();
        }

        //adds all the pills to the data grid view
        private void InitializePillDataGridView()
        {
            try
            {
                //holds information of all pills in the database
                List<IPill> pills = pillDB.SelectAllPills();

                //outputs information of each pill to the data grid view
                foreach (IPill pill in pills)
                {
                    pillDataGridView.Rows.Add(pill.Imprint, pill.Color, pill.Shape, pill.DrugName,
                        pill.DrugStrength, pill.Photo, pill.CreationTimestamp);
                }
            }

            catch (SqlNullValueException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pillReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }
    }
}
