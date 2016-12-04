using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public class EspFiles
	{
		public List<EspFile> files;
		public EspFiles(string fileListStr)
		{
			if (!string.IsNullOrEmpty(fileListStr))
			{
				files = new List<EspFile>();
				string[] rows = fileListStr.Split(',');
				foreach (string row in rows)
				{
					EspFile ef = new EspFile(row);
					files.Add(ef);
				}
			}
		}
		
	}

	public class EspFile
	{
		public string name { get; set; }
		public int size { get; set; }
		public EspFile(string row)
		{
			string[] sa = row.Split(';');
			name = sa[0];
			int _size = 0;
			int.TryParse(sa[1], out _size);
			size = _size;
		}
	}
}
