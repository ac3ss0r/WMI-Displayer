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
            richTextBox1.Text = getWmiData(comboBox1.Text);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            foreach (string name in GetWmiNamespaces("root")) {
                comboBox1.Items.Add(name);
            }
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

        private static string[] GetWmiNamespaces(string root) {
            List<String> namespaces = new List<string>();
            ManagementObjectSearcher mgmtObjSearcher = new ManagementObjectSearcher("SELECT * FROM meta_class");
            ManagementObjectCollection colDisks = mgmtObjSearcher.Get();
            try {
                foreach (ManagementObject objDisk in colDisks) {
                    namespaces.Add(objDisk.ClassPath.ClassName);
                }
            }
            catch (Exception e) {
                return null;
            }

            return namespaces.ToArray();
        }
	}
}
