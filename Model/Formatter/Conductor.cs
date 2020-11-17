using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MusicApp.Model.Formatter
{
	public class Conductor
	{
		public Conductor()
		{
			FileInfos = new List<FileInfo>();
		}

		public void ReloadFiles(string directory)
		{
			FileInfos.Clear();
			string[] files = Directory.GetFiles(directory);
			for (int i = 0; i < FileInfos.Count; i++)
			{
				FileInfos.Add(new FileInfo(files[i]));
			}
		}

		public List<FileInfo> FileInfos { get; private set; }
	}
}
