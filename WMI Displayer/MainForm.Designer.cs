/*
 * Created by SharpDevelop.
 * User: админ
 * Date: 23.02.2022
 * Time: 15:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WMI_Displayer {
    partial class MainForm {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.classesListBox = new System.Windows.Forms.ComboBox();
            this.getPropsButton = new System.Windows.Forms.Button();
            this.classValuesField = new System.Windows.Forms.RichTextBox();
            this.pathListbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.classesButton = new System.Windows.Forms.Button();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // classesListBox
            // 
            this.classesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classesListBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classesListBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classesListBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.classesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classesListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(85, 35);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(191, 24);
            this.classesListBox.TabIndex = 0;
            // 
            // getPropsButton
            // 
            this.getPropsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getPropsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getPropsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPropsButton.Location = new System.Drawing.Point(280, 35);
            this.getPropsButton.Name = "getPropsButton";
            this.getPropsButton.Size = new System.Drawing.Size(97, 24);
            this.getPropsButton.TabIndex = 1;
            this.getPropsButton.Text = "Get properties";
            this.getPropsButton.UseVisualStyleBackColor = false;
            this.getPropsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // classValuesField
            // 
            this.classValuesField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classValuesField.BackColor = System.Drawing.Color.White;
            this.classValuesField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classValuesField.Location = new System.Drawing.Point(12, 65);
            this.classValuesField.Name = "classValuesField";
            this.classValuesField.ReadOnly = true;
            this.classValuesField.Size = new System.Drawing.Size(365, 254);
            this.classValuesField.TabIndex = 2;
            this.classValuesField.Text = "";
            // 
            // pathListbox
            // 
            this.pathListbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathListbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.pathListbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.pathListbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pathListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathListbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pathListbox.FormattingEnabled = true;
            this.pathListbox.Items.AddRange(new object[] {
            "",
            "\\\\.\\root",
            "\\\\.\\root\\wmi"});
            this.pathListbox.Location = new System.Drawing.Point(81, 4);
            this.pathListbox.Name = "pathListbox";
            this.pathListbox.Size = new System.Drawing.Size(158, 24);
            this.pathListbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "WMI Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "WMI Class";
            // 
            // classesButton
            // 
            this.classesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classesButton.Location = new System.Drawing.Point(245, 3);
            this.classesButton.Name = "classesButton";
            this.classesButton.Size = new System.Drawing.Size(132, 24);
            this.classesButton.TabIndex = 6;
            this.classesButton.Text = "Update classes";
            this.classesButton.UseVisualStyleBackColor = false;
            this.classesButton.Click += new System.EventHandler(this.ClassesButtonClick);
            // 
            // githubLink
            // 
            this.githubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(12, 324);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(72, 13);
            this.githubLink.TabIndex = 8;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Project github";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinkLinkClicked);
            // 
            // aboutLink
            // 
            this.aboutLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.aboutLink.AutoSize = true;
            this.aboutLink.Location = new System.Drawing.Point(90, 324);
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.Size = new System.Drawing.Size(59, 13);
            this.aboutLink.TabIndex = 9;
            this.aboutLink.TabStop = true;
            this.aboutLink.Text = "Information";
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLinkLinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 346);
            this.Controls.Add(this.aboutLink);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.classesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathListbox);
            this.Controls.Add(this.classValuesField);
            this.Controls.Add(this.getPropsButton);
            this.Controls.Add(this.classesListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WMI Displayer by Acessor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.LinkLabel githubLink;
        private System.Windows.Forms.Button classesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pathListbox;

        private System.Windows.Forms.ComboBox classesListBox;
        private System.Windows.Forms.Button getPropsButton;
        private System.Windows.Forms.RichTextBox classValuesField;
    }
}