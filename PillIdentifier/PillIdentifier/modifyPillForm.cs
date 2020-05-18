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
* Filename: ModifyPillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to modify a pill 
* History:
*           5/17/2020 - file created and form layout made. RRS
*/

namespace PillIdentifier
{
    public partial class ModifyPillForm : Form
    {
        private PillForm pillForm; //reference to pillForm

        public ModifyPillForm(PillForm pillForm)
        {
            InitializeComponent();

            this.pillForm = pillForm;
        }

        private void modifyPillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }
    }
}
