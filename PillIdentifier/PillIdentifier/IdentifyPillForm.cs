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
* Filename: IdentifyPillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to show the information of a pill
* History:
*           5/18/2020 - file created, form layout made. Added all functionlity. RRS
*           5/19/2020 - changed icon attributes to match database size limits. RRS
*/

namespace PillIdentifier
{
    public partial class IdentifyPillForm : Form
    {
        private PillForm pillForm; //reference to pillForm
        private IPill pill; //holds the pill whose information is shown
        public IdentifyPillForm(PillForm pillForm, IPill pill)
        {
            InitializeComponent();

            this.pillForm = pillForm;
            this.pill = pill;

            //adds pil information to form
            imprintTextBox.Text = pill.Imprint;
            colorTextBox.Text = pill.Color;
            shapeTextBox.Text = pill.Shape;
            drugNameTextBox.Text = pill.DrugName;
            drugStrengthTextBox.Text = pill.DrugStrength;
            imageTextBox.Text = pill.Photo;
            creationTimeDateTimePicker.Value = DateTime.Parse(pill.CreationTimestamp);

            //trick to make the date time picker unchangable
            creationTimeDateTimePicker.MinDate = DateTime.Parse(pill.CreationTimestamp);
            creationTimeDateTimePicker.MaxDate = DateTime.Parse(pill.CreationTimestamp);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
