using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;

/*
* Filename: ModifyPillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to modify a pill 
* History:
*           5/17/2020 - file created and form layout made. RRS
*           5/18/2020 - connected file to the database and added all functionality. RRS
*           5/19/2020 - added more validation checks and improved code readability. RRS
*/

namespace PillIdentifier
{
    public partial class ModifyPillForm : Form
    {
        private PillForm pillForm; //reference to main pill form
        private PillDB pillDB; //reference to pill database
        IPill pill;  //holds data of selected pill
        string pillOriginalImprint;  //holds pill oroginal imprint in case that it is modified

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
            selectImageTextBox.Text = pill.Photo;
            creationTimeDateTimePicker.Value = DateTime.Parse(pill.CreationTimestamp);

            pillOriginalImprint = pill.Imprint;

        }

        private void modifyPillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }

        //modifies pill values
        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                //assigns modified values to the pill
                pill.Imprint = imprintTextBox.Text;
                pill.Color = colorComboBox.Text;
                pill.Shape = shapeComboBox.Text;
                pill.DrugName = drugNameTextBox.Text;
                pill.DrugStrength = drugStrengthTextBox.Text;
                pill.Photo = selectImageTextBox.Text;
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

                else if (pill.Shape.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Shape must not be empty");
                }

                else if (pill.DrugName.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Drug name must not be empty");
                }

                else if (pill.DrugStrength.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Drug strength must not be empty");
                }

                else if (pill.Photo.Replace(" ", "") == "")
                {
                    throw new ArgumentException("photo must be selected");
                }

                //attempts pill update
                pillDB.UpdatePill(pill, pillOriginalImprint);

                //updates original pill imprint value, in case that imprint is modified again
                pillOriginalImprint = pill.Imprint;

                MessageBox.Show("Pill updated successfully!", "Success", MessageBoxButtons.OK);
            }

            catch (Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //prompts the user to select the directory of the image to be used for the pill
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            if (selectImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //saves image filename
                    selectImageTextBox.Text = selectImageOpenFileDialog.SafeFileName;
                }

                catch (SecurityException except)
                {
                    MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception except)
                {
                    MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
