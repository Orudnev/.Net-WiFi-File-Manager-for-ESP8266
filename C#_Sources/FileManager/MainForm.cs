using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Globalization;

namespace FileManager
{
	public partial class MainForm : StoreSizeForm
	{
		public EspRpcApi api;
		private LogForm logfrm;
		private List<FileInfo> projectFileList;
		private List<EspFile> espFileList;
		public MainForm()
		{
			SetLocale();
			InitializeComponent();
			logfrm = null;
			refreshDir();
			//EspFiles ef = new EspFiles(strFileList);
			//saveFile(@"W:\MP\ESP8266\C#\FileManager\FileManager\Form1.cs");
			//string s = "stop";
		}

		private void refreshDir()
		{
			Int32 port;
			if (!Int32.TryParse(Properties.Settings.Default.EspPort,out port))
			{
				showError(Properties.Resources.MsgWrongPort);
				return;
			}
			api = new EspRpcApi(new EspModule(Properties.Settings.Default.EspIp,port));
			if (ping())
			{
			    fillProjectDataGrid();
				fillEspDataGrid();
			}
		}

		private bool ping()
		{
			System.Net.IPAddress address = null;
			if (!System.Net.IPAddress.TryParse(Properties.Settings.Default.EspIp, out address))
			{
				showError(Properties.Resources.Msg_WrongIpAddress);
				return false;
			}
			if (!EspRpcApi.Ping(address))
			{
				showError(string.Format(Properties.Resources.Msg_NoPing, Properties.Settings.Default.EspIp));
				return false;
			}
			return true;
		}


		#region GUI handlers

		private void tsBtnSettings_Click(object sender, EventArgs e)
		{
			AppSettingsForm frm = new AppSettingsForm();
			frm.ShowDialog();
		}

		private void tsBtnLog_Click(object sender, EventArgs e)
		{
			if (logfrm == null || logfrm.IsDisposed)
			{
				logfrm = new LogForm();
				logfrm.Show();
			}			
		}

		private void tsBtnAbout_Click(object sender, EventArgs e)
		{
			About dlg = new About();
			dlg.ShowDialog();
		}

		private void dataGridProject_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn selcol = dataGridProject.Columns[e.ColumnIndex];
			DataGridViewColumnHeaderCell hdrCell = selcol.HeaderCell;
			SortOrder order = hdrCell.SortGlyphDirection;
			SortOrder newOrder = SortOrder.None;
			if (order == SortOrder.None || order == SortOrder.Descending)
			{
				newOrder = SortOrder.Ascending;
			}
			else
			{
				newOrder = SortOrder.Descending;
			}
			dataGridProjectSort(selcol.DataPropertyName, hdrCell.SortGlyphDirection);
			hdrCell.SortGlyphDirection = newOrder;
			foreach (DataGridViewColumn col in dataGridProject.Columns)
			{
				if (col.Index == e.ColumnIndex) continue;
				col.HeaderCell.SortGlyphDirection = SortOrder.None;
			}
		}

		private void dataGridEsp_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewColumn selcol = dataGridEsp.Columns[e.ColumnIndex];
			DataGridViewColumnHeaderCell hdrCell = selcol.HeaderCell;
			SortOrder order = hdrCell.SortGlyphDirection;
			SortOrder newOrder = SortOrder.None;
			if (order == SortOrder.None || order == SortOrder.Descending)
			{
				newOrder = SortOrder.Ascending;
			}
			else
			{
				newOrder = SortOrder.Descending;
			}
			dataGridEspSort(selcol.DataPropertyName, hdrCell.SortGlyphDirection);
			hdrCell.SortGlyphDirection = newOrder;
			foreach (DataGridViewColumn col in dataGridEsp.Columns)
			{
				if (col.Index == e.ColumnIndex) continue;
				col.HeaderCell.SortGlyphDirection = SortOrder.None;
			}

		}



		#endregion

		public static void SetLocale()
		{
			string locale = Properties.Settings.Default.Language;
			if (locale == "Русский")
			{
				Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
			}
			else
			{
				Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
				Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
			}
		}

		private void fillProjectDataGrid()
		{
			string pf = Properties.Settings.Default.ProjectFolder;
			if (string.IsNullOrEmpty(pf) || !Directory.Exists(pf)) return;
			string[] farr = Directory.GetFiles(pf);
			projectFileList = new List<FileInfo>();
			foreach(string fname in farr)
			{
				FileInfo fi = new FileInfo(fname);
				projectFileList.Add(fi);
			}
			fileInfoBindingSource.DataSource = projectFileList;
		}

		private void fillEspDataGrid()
		{
			espFileList = api.Dir().files;
			espFileBindingSource.DataSource = espFileList;
		}


		private void showError(string errMes)
		{
			MessageBox.Show(errMes, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private DialogResult showWarning(string mes)
		{
			return MessageBox.Show(mes, "!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
		}

		int c = 0;
		private void button1_Click(object sender, EventArgs e)
		{
			c++;
			string mess = "jhkjhkjh kjhkjh kjh khkjhkjhkhkh khkh kh " + c.ToString();
			EspRpcApi.writeLineToLog(mess);
		}


		private void dataGridProjectSort(string dataFieldName,SortOrder order)
		{
			if (order==SortOrder.Ascending)
				fileInfoBindingSource.DataSource = projectFileList.OrderBy(f => f.GetType().GetProperty(dataFieldName).GetValue(f,null)).ToList();
			else
				fileInfoBindingSource.DataSource = projectFileList.OrderByDescending(f => f.GetType().GetProperty(dataFieldName).GetValue(f,null)).ToList();
		}

		private void dataGridEspSort(string dataFieldName,SortOrder order)
		{
			if (order == SortOrder.Ascending)
				espFileBindingSource.DataSource = espFileList.OrderBy(f => f.GetType().GetProperty(dataFieldName).GetValue(f, null)).ToList();
			else
				espFileBindingSource.DataSource = espFileList.OrderByDescending(f => f.GetType().GetProperty(dataFieldName).GetValue(f, null)).ToList();
		}

		private void tsBtnRefresh_Click(object sender, EventArgs e)
		{
			refreshDir();
		}

		private bool checkIfSystem(string fileName)
		{
			string fname = fileName.ToLower();
			if (fileName=="init.lua" || fileName=="servernode.lua" || fileName=="wifi_tools.lua")
			{
				if (showWarning(Properties.Resources.WarningConfirmSysFileChangeOrDelete) == DialogResult.Cancel) return false;
			}
			return true;
		}


		private void tsBtnEspDelete_Click(object sender, EventArgs e)
		{
			if (dataGridEsp.SelectedRows.Count == 0) return;
			string fileName = (espFileBindingSource.Current as EspFile).name;
			if (!checkIfSystem(fileName)) return;
			api.DeleteFile(fileName);
			refreshDir();
 		}

		private void tsBtnCopy_Click(object sender, EventArgs e)
		{
			if (dataGridProject.SelectedRows.Count == 0) return;
			if (!checkIfSystem((fileInfoBindingSource.Current as FileInfo).Name)) return;
			string filePath = (fileInfoBindingSource.Current as FileInfo).FullName;
			api.SaveFile(filePath);
			refreshDir();
		}

		private void tsBtnRead_Click(object sender, EventArgs e)
		{
			if (dataGridEsp.SelectedRows.Count == 0) return;
			string fileName = (espFileBindingSource.Current as EspFile).name;
			string fileBody = api.ReadFile(fileName);
			ViewDocForm frm = new ViewDocForm(fileName,fileBody);
			frm.ShowDialog();
		}

		private void tsBtnRun_Click(object sender, EventArgs e)
		{
			if (dataGridEsp.SelectedRows.Count == 0) return;
			string fileName = (espFileBindingSource.Current as EspFile).name;
			api.DoFile(fileName);

		}

		private void tsBtnCompile_Click(object sender, EventArgs e)
		{
			if (dataGridEsp.SelectedRows.Count == 0) return;
			string fileName = (espFileBindingSource.Current as EspFile).name;
			api.Compile(fileName);
			refreshDir();
		}

		private void tsBtnRestart_Click(object sender, EventArgs e)
		{
			api.Restart();
		}

		

	}

}
