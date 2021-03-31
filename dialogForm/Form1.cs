using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            String errorText = "";
            if (this.nameTextBox.Text == "")
            {
                errorText += "Please enter your name\n";
            }
            if (!this.genderRadioButtonMale.Checked && !this.genderRadioButtonFemale.Checked)
            {
                errorText += "Please select your gender\n";
            }
            
            if (errorText != "")
            {
                MessageBox.Show(this, errorText, "Required fields", MessageBoxButtons.OK);
            } else
            {
                MessageBox.Show("Hello " + (this.genderRadioButtonMale.Checked ? "Mr" : "Mrs") + " " + this.nameTextBox.Text, "Greetings", MessageBoxButtons.OK);
            }
        }

        private void clearInputButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Clear();
            this.genderRadioButtonMale.Checked = false;
            this.genderRadioButtonFemale.Checked = false;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Focus();
        }

        private void genderLabel_Click(object sender, EventArgs e)
        {
            this.genderRadioButtonMale.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
