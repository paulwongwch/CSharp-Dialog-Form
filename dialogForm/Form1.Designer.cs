
using System;

namespace dialogForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderRadioButtonMale = new System.Windows.Forms.RadioButton();
            this.genderRadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.confirmChangesButton = new System.Windows.Forms.Button();
            this.clearInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Location = new System.Drawing.Point(50, 75);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 30);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(50, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(50, 140);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(72, 23);
            this.genderLabel.TabIndex = 2;
            this.genderLabel.Text = "Gender";
            // 
            // genderRadioButtonMale
            // 
            this.genderRadioButtonMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderRadioButtonMale.AutoSize = true;
            this.genderRadioButtonMale.Location = new System.Drawing.Point(50, 175);
            this.genderRadioButtonMale.Name = "genderRadioButtonMale";
            this.genderRadioButtonMale.Size = new System.Drawing.Size(77, 27);
            this.genderRadioButtonMale.TabIndex = 3;
            this.genderRadioButtonMale.TabStop = true;
            this.genderRadioButtonMale.Text = "male";
            this.genderRadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // genderRadioButtonFemale
            // 
            this.genderRadioButtonFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderRadioButtonFemale.AutoSize = true;
            this.genderRadioButtonFemale.Location = new System.Drawing.Point(250, 175);
            this.genderRadioButtonFemale.Name = "genderRadioButtonFemale";
            this.genderRadioButtonFemale.Size = new System.Drawing.Size(93, 27);
            this.genderRadioButtonFemale.TabIndex = 4;
            this.genderRadioButtonFemale.TabStop = true;
            this.genderRadioButtonFemale.Text = "female";
            this.genderRadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // confirmChangesButton
            // 
            this.confirmChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmChangesButton.Location = new System.Drawing.Point(50, 235);
            this.confirmChangesButton.Name = "confirmChangesButton";
            this.confirmChangesButton.Size = new System.Drawing.Size(400, 34);
            this.confirmChangesButton.TabIndex = 5;
            this.confirmChangesButton.Text = "Confirm changes";
            this.confirmChangesButton.UseVisualStyleBackColor = true;
            this.confirmChangesButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // clearInputButton
            // 
            this.clearInputButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearInputButton.Location = new System.Drawing.Point(50, 275);
            this.clearInputButton.Name = "clearInputButton";
            this.clearInputButton.Size = new System.Drawing.Size(400, 34);
            this.clearInputButton.TabIndex = 6;
            this.clearInputButton.Text = "Clear input";
            this.clearInputButton.UseVisualStyleBackColor = true;
            this.clearInputButton.Click += new System.EventHandler(this.clearInputButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.clearInputButton);
            this.Controls.Add(this.confirmChangesButton);
            this.Controls.Add(this.genderRadioButtonFemale);
            this.Controls.Add(this.genderRadioButtonMale);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        


        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.RadioButton genderRadioButtonMale;
        private System.Windows.Forms.RadioButton genderRadioButtonFemale;
        private System.Windows.Forms.Button confirmChangesButton;
        private System.Windows.Forms.Button clearInputButton;
    }
}

