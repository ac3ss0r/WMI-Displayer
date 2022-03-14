/*
 * Created by SharpDevelop.
 * User: админ
 * Date: 23.02.2022
 * Time: 15:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace WMI_Displayer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
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
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.classesListBox = new System.Windows.Forms.ComboBox();
            this.getPropsButton = new System.Windows.Forms.Button();
            this.classValuesField = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // classesListBox
            // 
            this.classesListBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.classesListBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.classesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.Location = new System.Drawing.Point(12, 8);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.Size = new System.Drawing.Size(262, 24);
            this.classesListBox.TabIndex = 0;
            // 
            // getPropsButton
            // 
            this.getPropsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPropsButton.Location = new System.Drawing.Point(280, 6);
            this.getPropsButton.Name = "getPropsButton";
            this.getPropsButton.Size = new System.Drawing.Size(97, 27);
            this.getPropsButton.TabIndex = 1;
            this.getPropsButton.Text = "get props";
            this.getPropsButton.UseVisualStyleBackColor = true;
            this.getPropsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // classValuesField
            // 
            this.classValuesField.Location = new System.Drawing.Point(12, 39);
            this.classValuesField.Name = "classValuesField";
            this.classValuesField.Size = new System.Drawing.Size(365, 295);
            this.classValuesField.TabIndex = 2;
            this.classValuesField.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 346);
            this.Controls.Add(this.classValuesField);
            this.Controls.Add(this.getPropsButton);
            this.Controls.Add(this.classesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "WMI Displayer by Acessor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

		}

        private System.Windows.Forms.ComboBox classesListBox;
        private System.Windows.Forms.Button getPropsButton;
        private System.Windows.Forms.RichTextBox classValuesField;
	}
}
