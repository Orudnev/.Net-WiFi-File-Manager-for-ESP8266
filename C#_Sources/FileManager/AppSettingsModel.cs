using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;


namespace FileManager
{
	public class AppSettingsModel
	{
		public AppSettingsModel()
		{
			
		}	


		[DisplayNameRes("Settings_Language")]
		[TypeConverter(typeof(LocaleTypeConverter))]
		public string CurrentLocale
		{
			get
			{
				return Properties.Settings.Default.Language;
			}
			set
			{
				if (MessageBox.Show(
					Properties.Resources.
					Msg_ChangeLanguageRestartRequires, 
					"ESP WiFi File Manager", 
					MessageBoxButtons.OKCancel, 
					MessageBoxIcon.Information)==DialogResult.OK)
				{
					Properties.Settings.Default.Language = value;
					Properties.Settings.Default.Save();
				}
			}
		}

		[DisplayNameRes("Settings_ProjectFolder")]
		[Editor(typeof(System.Windows.Forms.Design.FolderNameEditor), typeof(UITypeEditor))]
		public string ProjectFolder 
		{ 
			get
			{
				return Properties.Settings.Default.ProjectFolder; 
			}
			set
			{
				Properties.Settings.Default.ProjectFolder = value;
			}
		}


		[DisplayNameRes("Settings_EspIp")]
		public string EspIp 
		{
			get
			{
				return Properties.Settings.Default.EspIp;
			}
			set
			{
				Properties.Settings.Default.EspIp = value;
			}
		}


		[DisplayNameRes("Settings_EspPort")]
		public string EspPort 
		{
			get
			{
				return Properties.Settings.Default.EspPort;
			}
			set
			{
				Properties.Settings.Default.EspPort = value;
			}
		}


	}


	class LocaleTypeConverter : StringConverter
	{
		public override bool GetStandardValuesSupported(
		  ITypeDescriptorContext context)
		{
			return true;
		}

		public override bool GetStandardValuesExclusive(
		  ITypeDescriptorContext context)
		{
			return true;
		}

		public override StandardValuesCollection GetStandardValues(
		  ITypeDescriptorContext context)
		{
			return new StandardValuesCollection(new string[] { "English", "Русский" });
		}
	}

	public class DisplayNameRes : DisplayNameAttribute
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="category"></param>
		public DisplayNameRes(string displayName)
			: base(Properties.Resources.ResourceManager.GetString(displayName))
		{

		}
	}

}
