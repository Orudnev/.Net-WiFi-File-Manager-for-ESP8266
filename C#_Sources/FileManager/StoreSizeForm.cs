using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace FileManager
{
	public class StoreSizeForm:Form
	{

		private Point lastLocation;
		private bool timerStarted;

		public StoreSizeForm()
		{
			lastLocation = this.Location;
			timerStarted = false;
			restoreSizeAndLocation();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			restoreSizeAndLocation();
		}
		protected override void OnResizeEnd(EventArgs e)
		{
			base.OnResizeEnd(e);
			storeSizeAndLocation();
		}

		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);
			detectEndOfMoveForm();
		}


		private void detectEndOfMoveForm()
		{
			if (!timerStarted)
			{
				System.Threading.Timer t = new System.Threading.Timer(onTimerInterval, null, 1000, System.Threading.Timeout.Infinite);
				timerStarted = true;
			}
			lastLocation = this.Location;
		}

		private void onTimerInterval(Object stateInfo)
		{
			timerStarted = false;
			if (lastLocation == this.Location)
				storeSizeAndLocation();
		}


		private string getUserSettingsFolderPath()
		{
			System.Configuration.Configuration config =
				System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal);
			return Path.GetDirectoryName(config.FilePath);
		}
		
		public string formSettignsFilePath
		{
			get { return getUserSettingsFolderPath()+"\\formSettings.txt";}
		}
	

		private void storeSizeAndLocation()
		{
			// Name,X,Y,Width,Height
			string newRow = string.Format("{0},{1},{2},{3},{4}",
				this.Name,this.Location.X,this.Location.Y,this.Size.Width,this.Size.Height
				);
			string formSettignsBody = "";
			bool isRowUpdated = false;
			string crlf = "\r\n";
			if (File.Exists(formSettignsFilePath))
			{
				string[] rows = File.ReadAllLines(formSettignsFilePath);
				foreach(string row in rows)
				{
					try
					{
						string[] rowFields = row.Split(',');
						string rowValue = row;
						string rowName = rowFields[0];
						if (rowName==this.Name)
						{
							rowValue = newRow;
							isRowUpdated = true;
						}
						formSettignsBody += ((formSettignsBody == "") ? "" : crlf) + rowValue;
					}
					catch(Exception ex)
					{
						//file is damaged, recreate it
						formSettignsBody = "";
						isRowUpdated = false;
						break;
					}
				}
			}
			if (!isRowUpdated)
			{
				formSettignsBody += ((formSettignsBody == "") ? "" : crlf) + newRow;
			}
			if (Directory.Exists(getUserSettingsFolderPath()))
			{
				File.WriteAllText(formSettignsFilePath, formSettignsBody);
			}
		}

		private void restoreSizeAndLocation()
		{
			if (File.Exists(formSettignsFilePath))
			{
				string[] rows = File.ReadAllLines(formSettignsFilePath);
				foreach (string row in rows)
				{
					try
					{
						// Name,X,Y,Width,Height
						string[] rowFields = row.Split(',');
						string rowName = rowFields[0];
						if (rowName == this.Name)
						{
							Point newLocation = new Point(int.Parse(rowFields[1]),int.Parse(rowFields[2]));
							this.Location = newLocation;
							System.Drawing.Size newSize = new System.Drawing.Size(int.Parse(rowFields[3]),int.Parse(rowFields[4]));
							this.Size = newSize;
						}
					}
					catch (Exception ex)
					{
						break;
					}
				}
			}
		}
		


	}

	[Serializable()]
	public class SizePosition
	{
		public Point location { get; set; }

		public Size size { get; set; }

		public SizePosition(Point location,Size size)
		{
			this.location = location;
			this.size = size;
		}
	}
}
