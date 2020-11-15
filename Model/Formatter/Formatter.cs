using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MusicApp.Model.Formatter.Restrictions;

namespace MusicApp.Model.Formatter
{
	public class Formatter
	{
		public Formatter()
		{
			restrictions = new List<Restriction>();
		}
		private List<Restriction> restrictions;
		public void AddRestriction(Restriction value)
		{
			if (value != null) restrictions.Add(value);
		}
		public void DeleteRestriction(Restriction value)
		{
			restrictions.RemoveAll(restriction => restriction == value);
		}

		public void FormatFile(string path)
		{
			for (int i = 0; i < restrictions.Count; i++)
			{
				restrictions[i].ApplyRestriction(path);
			}
		}

		public void AddAttributeToFile(string fullName, FileAttributes fileAttribute)
		{
			if (File.Exists(fullName))
			{
				File.SetAttributes(fullName, File.GetAttributes(fullName) | fileAttribute);
			}
		}
		public void DeleteAttributeOfFile(string fullName, FileAttributes attribute)
		{
			if (File.Exists(fullName))
			{
				File.SetAttributes(fullName, File.GetAttributes(fullName) ^ attribute);
			}
		}
		public bool IsThisFileHaveSameAttribute(string fullName, FileAttributes attribute)
		{
			bool flag = false;
			if (File.Exists(fullName))
			{
				if (File.GetAttributes(fullName).HasFlag(attribute))
				{
					flag = true;
				}
			}
			return flag;
		}
	}
}
