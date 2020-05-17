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
* Filename: PillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: main form for the pill app
* History:
*           5/12/2020 - File created and menu layout made. RRS
*/

namespace PillIdentifier
{
    public partial class PillForm : Form
    {
        public PillForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string infoMessage = "Made by:\n" +
                "Ricardo Ramirez Santiago #119372\n" +
                "Luis Monroig";

            MessageBox.Show(infoMessage, "About", MessageBoxButtons.OK);
        }

        private void addPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPillForm addForm = new AddPillForm(this);
            addForm.Show();
            this.Hide();
        }

        private void PillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void modifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPillForm searchForm = new searchPillForm(this, SearchType.SearchAndModify);
            searchForm.Show();
        }

        private void IdentifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPillForm searchForm = new searchPillForm(this, SearchType.SearchAndIdentify);
            searchForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PillReportForm reportForm = new PillReportForm(this);
            reportForm.Show();
            this.Hide();
        }
    }
}
