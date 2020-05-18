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
* Filename: PillReportForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to show the information of all pills in the database
* History:
*           5/17/2020 - file created. RRS
*/

namespace PillIdentifier
{
    public partial class PillReportForm : Form
    {
        private PillForm pillForm; //reference to pillForm

        public PillReportForm(PillForm pillForm)
        {
            InitializeComponent();

            this.pillForm = pillForm;
        }

        private void pillReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }
    }
}
