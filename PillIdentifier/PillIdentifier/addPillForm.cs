using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.IO;

/*
* Filename: AddPillForm.cs
* Author: Ricardo J. Ramirez Santiago
* Description: form used to add a pill 
* History:
*           5/17/2020 - file created and form layout made. RRS
*           5/18/2020 - connected file to the database and added all functionality. RRS
*/

namespace PillIdentifier
{
    public partial class AddPillForm : Form
    {

        private PillForm pillForm; //reference to pillForm
        PillDB pillDB; //reference to pillDB

        //receives pillForm and stores it
        public AddPillForm(PillForm pillForm, ref PillDB pillDB)
        {
            InitializeComponent();

            this.pillForm = pillForm;
            this.pillDB = pillDB;

            //allows for date time picker to accept both date and time
            creationTimeDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            try
            {
                //saves the pill information
                string imprint = imprintTextBox.Text;
                string color = colorComboBox.Text;
                string shape = shapeComboBox.Text;
                string drugName = drugNameTextBox.Text;
                string drugStrength = drugStrengthTextBox.Text;
                string photo = selectImageTextBox.Text;
                string creationTime = creationTimeDateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");

                //checks that no fields were left in blank
                if (imprint.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Imprint must not be empty");
                }

                else if (color.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Color must not be empty");
                }

                else if (drugName.Replace(" ", "") == "")
                {
                    throw new ArgumentException("Drug name must not be empty");
                }
                
                else if (photo.Replace(" ", "") == "")
                {
                    throw new ArgumentException("photo must be selected");
                }


                //inserts the pill
                IPill pill = new Pill(imprint, color, shape, drugName, drugStrength, photo, creationTime);
                pillDB.InsertPill(pill);

                MessageBox.Show("Pill added successfully!", "Success", MessageBoxButtons.OK);
            }

            catch(ArgumentException except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch(Exception except)
            {
                MessageBox.Show(except.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //shows the pillForm once the add form is closing
        private void addPillForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            pillForm.Show();
        }

        //prompts the user to select the directory of the image to be used for the pill
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            if (selectImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
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
