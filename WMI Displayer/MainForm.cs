using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;

namespace WMI_Displayer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void button1_Click(object sender, EventArgs e) {
            classValuesField.Text = getWmiData(classesListBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            classesListBox.DataSource = getWmiNamespaces();
        }
        
        
        private static string getWmiData(string cls) {
            ManagementObjectSearcher mgmtObjSearcher = new ManagementObjectSearcher("SELECT * FROM "+cls);
		    ManagementObjectCollection colDisks = mgmtObjSearcher.Get();
            string info = "";
            try {
                foreach (ManagementObject objDisk in colDisks) {
                    foreach (PropertyData data in objDisk.Properties) {
                        info += data.Name + ": " + data.Value + "\n";
                    }
                }
                return info;
            }
            catch (Exception e) {
                return e.ToString();
            }
            
        }

        private static List<string> getWmiNamespaces() {
            List<string> namespaces = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM meta_class");
            ManagementObjectCollection col = searcher.Get();
            try {
                foreach (ManagementObject obj in col) {
                    namespaces.Add(obj.ClassPath.ClassName);
                }
            }
            catch (Exception e) {
                return null;
            }
            return namespaces;
        }
	}
}
