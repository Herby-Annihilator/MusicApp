using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MusicApp.Model.Formatter.Restrictions
{
	public class ChangeExtension : Restriction
	{
		private readonly string ext;
		public ChangeExtension(string ext)
		{
			this.ext = ext;
		}
		public override void ApplyRestriction(string fullName)
		{
			if (File.Exists(fullName))
			{
				string name = Path.ChangeExtension(fullName, ext);
				File.Copy(fullName, name);
				File.Delete(fullName);
			}
		}
	}
}
