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
            MessageBox.Show("made by two cool guys");
        }
    }
}
