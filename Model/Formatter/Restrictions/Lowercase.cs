using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MusicApp.Model.Formatter.Restrictions
{
	public class Lowercase : Restriction
	{
		public override void ApplyRestriction(string fullName)
		{
			if (File.Exists(fullName))
			{
				string name = Path.GetFileNameWithoutExtension(fullName);
				name = name.ToLower();
				string ext = Path.GetExtension(fullName);
				string dir = Path.GetDirectoryName(fullName);
				File.Copy(fullName, Path.Combine(dir, name, ext));
				File.Delete(fullName);
			}
		}
	}
}
