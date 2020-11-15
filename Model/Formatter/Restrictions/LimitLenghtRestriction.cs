using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MusicApp.Model.Formatter.Restrictions
{
	class LimitLenghtRestriction : Restriction
	{
		private readonly int lenght;
		public LimitLenghtRestriction(int lenght)
		{
			this.lenght = lenght;
		}
		public override void ApplyRestriction(string fullName)
		{
			string name = Path.GetFileNameWithoutExtension(fullName);
			if (name.Length > lenght)
			{
				name = name.Substring(0, lenght);
				string ext = Path.GetExtension(fullName);
				string dir = Path.GetDirectoryName(fullName);
				File.Copy(fullName, Path.Combine(dir, name, ext));
				File.Delete(fullName);
			}
		}
	}
}
