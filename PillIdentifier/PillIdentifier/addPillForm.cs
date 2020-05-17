using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PillIdentifier
{
    public partial class AddPillForm : Form
    {

        private PillForm pillForm; //reference to pillForm

        //receives pillForm and stores it
        public AddPillForm(PillForm pillForm)
        {
            InitializeComponent();

            this.pillForm = pillForm;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

        }

        //shows the pillForm once the add form is closing
        private void addPillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }
    }
}
