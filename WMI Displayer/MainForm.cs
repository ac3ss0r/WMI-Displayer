using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WMI_Displayer {

    public partial class MainForm : Form {

		public MainForm() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			SetButtonsActive(false);
			ThreadPool.QueueUserWorkItem(x => {
				classValuesField.Invoke((MethodInvoker)delegate() { 
					classValuesField.Text = getWmiData(classesListBox.Text);
					SetButtonsActive(true);
				});
			});
		}

		private void RefreshNamespaces() {
			SetButtonsActive(false);
			ThreadPool.QueueUserWorkItem(result => {
				classesListBox.Invoke((MethodInvoker)delegate () {
					classesListBox.DataSource = getWmiNamespaces(pathListbox.Text);
					SetButtonsActive(true);
				});
			});
		}

		private void MainForm_Load(object sender, EventArgs e) {
			RefreshNamespaces();
		}

		void ClassesButtonClick(object sender, EventArgs e) {
			RefreshNamespaces();
		}

		private void SetButtonsActive(bool state) {
			classesButton.Enabled = state;
			getPropsButton.Enabled = state;
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
			} catch (Exception e) {
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
			} catch { }
			return namespaces.ToArray();
		}

		private static void OpenBrowserSafe(string url) {
			try {
				Process.Start(url);
			} catch {
				Clipboard.Clear();
				Clipboard.SetText(url);
				MessageBox.Show("Your computer doesn't have a default browser selected. " +
								"The URL was copied to your clipboard instead.", "Warning",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		void GithubLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			OpenBrowserSafe("https://github.com/ac3ss0r/WMI-Displayer");
		}

		void AboutLinkLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			OpenBrowserSafe("https://en.wikipedia.org/wiki/Windows_Management_Instrumentation");
		}
    }
}