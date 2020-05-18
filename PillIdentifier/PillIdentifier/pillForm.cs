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
*           5/17/2020 - linked menu items to their respective forms and added database reference. RRS
*           5/18/2020 - added welcome labels. RRS
*/

namespace PillIdentifier
{
    public partial class PillForm : Form
    {

        private PillDB pillDB;
        public PillForm(ref PillDB pillDB)
        {
            InitializeComponent();
            this.pillDB = pillDB;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string infoMessage = "Made by:\n" +
                "Ricardo Ramirez Santiago #119372\n" +
                "Luis E Monroig Perez #111604";

            MessageBox.Show(infoMessage, "About", MessageBoxButtons.OK);
        }

        private void addPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPillForm addForm = new AddPillForm(this, ref pillDB);
            addForm.Show();
            this.Hide();
        }

        private void PillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillDB.CloseConneciton();
            Application.Exit();
        }

        private void modifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPillForm searchForm = new SearchPillForm(this, ref pillDB, SearchType.SearchAndModify);
            searchForm.Show();
        }

        private void IdentifyPillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchPillForm searchForm = new SearchPillForm(this, ref pillDB, SearchType.SearchAndIdentify);
            searchForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pillReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PillReportForm reportForm = new PillReportForm(this,ref pillDB);
            reportForm.Show();
            this.Hide();
        }
    }
}
