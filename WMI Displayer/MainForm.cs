using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;

namespace WMI_Displayer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		private string[] namespaces;
		
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
			SetButtonsActive(false);
			ThreadPool.QueueUserWorkItem(result=>{
			      classValuesField.Invoke(new Action(()=>{
			        this.classValuesField.Text = getWmiData(classesListBox.Text);
			        SetButtonsActive(true);
			      }));
			});
        }
		
		private void RefreshNamespaces() {
			SetButtonsActive(false);
			ThreadPool.QueueUserWorkItem(result=>{
			      namespaces = getWmiNamespaces(pathListbox.Text);
			      classesListBox.Invoke(new Action(()=>{
			         this.classesListBox.DataSource = namespaces;
			         SetButtonsActive(true);
			      }));
			});
		}

        private void MainForm_Load(object sender, EventArgs e) {
			RefreshNamespaces();
        }
		
		void ClassesButtonClick(object sender, EventArgs e) {
			RefreshNamespaces();
		}
		
		private void SetButtonsActive(bool state) {
			this.classesButton.Enabled = state;
			this.getPropsButton.Enabled = state;
		}
        
        private static string getWmiData(string cls) {
            try {
            	ManagementClass mngcls = new ManagementClass(cls);
           		StringBuilder buffer = new StringBuilder();
            	mngcls.Get();
            	foreach (ManagementObject obj in mngcls.GetInstances()) {
                    foreach (PropertyData data in obj.Properties) {
		    			buffer.AppendLine(data.Name + ": " + data.Value);
                    }
                }
		    	return buffer.ToString();
            }
            catch (Exception e) {
                return e.ToString();
            }
            
        }

		private static string[] getWmiNamespaces(string path) {
            List<string> namespaces = new List<string>();
            try {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
            	new ManagementScope(path),
				new WqlObjectQuery("select * from meta_class"), null);
           	ManagementObjectCollection col = searcher.Get();
                foreach (ManagementObject obj in col) {
                    namespaces.Add(obj.ClassPath.ClassName);
                }
            }
            catch { }
            return namespaces.ToArray();
        }
		
		void GithubLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://github.com/acessors/WMI-Displayer");	
		}
		
		void AboutLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			Process.Start("https://en.wikipedia.org/wiki/Windows_Management_Instrumentation");
		}
	}
}
