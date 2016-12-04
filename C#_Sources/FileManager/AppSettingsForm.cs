using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileManager
{
	public partial class AppSettingsForm : Form
	{
		public AppSettingsForm()
		{
			InitializeComponent();
			AppSettingsModel settings = new AppSettingsModel();
			this.propertyGrid1.SelectedObject = settings;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
			Close();
		}





	}




}
