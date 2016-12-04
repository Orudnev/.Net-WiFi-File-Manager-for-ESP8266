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
	public partial class ViewDocForm :Form
	{
		public ViewDocForm(string fileName,string text)
		{
			InitializeComponent();
			this.Text = fileName;
			this.richTextBox1.Text = text;
		}
	}
}
