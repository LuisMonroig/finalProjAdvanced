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
        private PillDB pillDB;
        IPill pill;
        string pillOriginalImprint;

        public ModifyPillForm(PillForm pillForm, ref PillDB pillDB, IPill pill)
        {
            InitializeComponent();

            this.pillForm = pillForm;
            this.pillDB = pillDB;
            this.pill = pill;

            //allows for date time picker to accept both date and time
            creationTimeDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            //moves pill information to the form
            imprintTextBox.Text = pill.Imprint;
            colorComboBox.Text = pill.Color;
            shapeComboBox.Text = pill.Shape;
            drugNameTextBox.Text = pill.DrugName;
            drugStrengthTextBox.Text = pill.DrugStrength;
            creationTimeDateTimePicker.Value = DateTime.Parse(pill.CreationTimestamp);

            pillOriginalImprint = pill.Imprint;

        }

        private void modifyPillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                //assigns the current values in the form to the pill
                pill.Imprint = imprintTextBox.Text;
                pill.Color = colorComboBox.Text;
                pill.Shape = shapeComboBox.Text;
                pill.DrugName = drugNameTextBox.Text;
                pill.DrugStrength = drugStrengthTextBox.Text;
                pill.CreationTimestamp = creationTimeDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss"); ;

                //checks that no fields were left in blank
                if (pill.Imprint.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Imprint must not be empty");
                }

                else if (pill.Color.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Color must not be empty");
                }

                else if (pill.DrugName.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Drug name must not be empty");
                }

                pillDB.UpdatePill(pill, pillOriginalImprint);

                pillOriginalImprint = pill.Imprint;
                MessageBox.Show("Pill updated successfully!", "Success", MessageBoxButtons.OK);
            }

            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
