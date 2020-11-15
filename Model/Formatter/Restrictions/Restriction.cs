using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MusicApp.Model.Formatter.Restrictions
{
	public abstract class Restriction
	{
		public abstract void ApplyRestriction(string fullName);
	}
}
