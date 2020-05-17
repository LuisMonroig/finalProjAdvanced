﻿using System;
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