using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MusicApp.View.InterfaceLanguage.CommonInterface;

namespace MusicApp.View.InterfaceLanguage
{
	public class FormatterInterfaceLanguage : CommonInterfaceLanguage
	{
		private readonly string languageFile;
		public FormatterInterfaceLanguage(string languageFile)
		{
			this.languageFile = languageFile;
			if (System.IO.File.Exists(languageFile))
			{
				if (Path.GetExtension(languageFile) == ".lang")
				{
					Build();
				}
			}
		}

		private string file = "File";
		public string File { get => file; set => Set(ref file, value); }


		private string help = "Help";
		public string Help { get => help; set => Set(ref help, value); }

		private string groupBoxSetSettings = "Set common setting to format files";
		public string GroupBoxSetSettings { get => groupBoxSetSettings; set => Set(ref groupBoxSetSettings, value); }

		private string checkBoxLimitFileLenght = "Limit file's lenght";
		public string CheckBoxLimitFileLenght { get => checkBoxLimitFileLenght; set => Set(ref checkBoxLimitFileLenght, value); }

		private string groupBoxChangeAlphabet = "Change alphabet";
		public string GroupBoxChangeAlphabet { get => groupBoxChangeAlphabet; set => Set(ref groupBoxChangeAlphabet, value); }

		private string radioButtonCyrillic = "Cyrillic";
		public string RadioButtonCyrillic { get => radioButtonCyrillic; set => Set(ref radioButtonCyrillic, value); }

		private string radioButtonLatin = "Latin";
		public string RadioButtonLatin { get => radioButtonLatin; set => Set(ref radioButtonLatin, value); }

		private string radioButtonDefault = "Default";
		public string RadioButtonDefault { get => radioButtonDefault; set => Set(ref radioButtonDefault, value); }

		private string groupBoxChangeRegister = "Change register";
		public string GroupBoxChangeRegister { get => groupBoxChangeRegister; set => Set(ref groupBoxChangeRegister, value); }

		private string radioButtonUppercase = "Uppercase";
		public string RadioButtonUppercase { get => radioButtonUppercase; set => Set(ref radioButtonUppercase, value); }

		private string radioButtonLowercase = "Lowercase";
		public string RadioButtonLowercase { get => radioButtonLowercase; set => Set(ref radioButtonLowercase, value); }

		private string buttonStartProcedure = "Start procedure";
		public string ButtonStartProcedure { get => buttonStartProcedure; set => Set(ref buttonStartProcedure, value); }

		private string groupBoxWorkWithSeparateFile = "Work with a separate file";
		public string GroupBoxWorkWithSeparateFile { get => groupBoxWorkWithSeparateFile; 
			set => Set(ref groupBoxWorkWithSeparateFile, value); }

		private string textBlockChosenFile = "Chosen file";
		public string TextBlockChosenFile { get => textBlockChosenFile; set => Set(ref textBlockChosenFile, value); }

		private string checkBoxAllowFileRename = "allow file rename";
		public string CheckBoxAllowFileRename { get => checkBoxAllowFileRename; set => Set(ref checkBoxAllowFileRename, value); }

		private string groupBoxAttributes = "Attributes";
		public string GroupBoxAttributes { get => groupBoxAttributes; set => Set(ref groupBoxAttributes, value); }

		private string checkBoxArchive = "Archive";
		public string CheckBoxArchive { get => checkBoxArchive; set => Set(ref checkBoxArchive, value); }

		private string checkBoxCompressed = "Compressed";
		public string CheckBoxCompressed { get => checkBoxCompressed; set => Set(ref checkBoxCompressed, value); }

		private string checkBoxDirectory = "Directory";
		public string CheckBoxDirectory { get => checkBoxDirectory; set => Set(ref checkBoxDirectory, value); }

		private string checkBoxEncrypted = "Encrypted";
		public string CheckBoxEncrypted { get => checkBoxEncrypted; set => Set(ref checkBoxEncrypted, value); }

		private string checkBoxHidden = "Hidden";
		public string CheckBoxHidden { get => checkBoxHidden; set => Set(ref checkBoxHidden, value); }

		private string checkBoxIntegrityStream = "IntegrityStream";
		public string CheckBoxIntegrityStream { get => checkBoxIntegrityStream; set => Set(ref checkBoxIntegrityStream, value); }

		private string checkBoxNormal = "Normal";
		public string CheckBoxNormal { get => checkBoxNormal; set => Set(ref checkBoxNormal, value); }

		private string checkBoxNoScrubData = "NoScrubData";
		public string CheckBoxNoScrubData { get => checkBoxNoScrubData; set => Set(ref checkBoxNoScrubData, value); }

		private string checkBoxOffline = "Offline";
		public string CheckBoxOffline { get => checkBoxOffline; set => Set(ref checkBoxOffline, value); }

		private string checkBoxReadOnly = "ReadOnly";
		public string CheckBoxReadOnly { get => checkBoxReadOnly; set => Set(ref checkBoxReadOnly, value); }

		private string checkBoxReparsePoint = "ReparsePoint";
		public string CheckBoxReparsePoint { get => checkBoxReparsePoint; set => Set(ref checkBoxReparsePoint, value); }

		private string checkBoxSparseFile = "SparseFile";
		public string CheckBoxSparseFile { get => checkBoxSparseFile; set => Set(ref checkBoxSparseFile, value); }

		private string checkBoxSystem = "System";
		public string CheckBoxSystem { get => checkBoxSystem; set => Set(ref checkBoxSystem, value); }

		private string checkBoxTemporary = "Temporary";
		public string CheckBoxTemporary { get => checkBoxTemporary; set => Set(ref checkBoxTemporary, value); }

		private string textBlockCreationDate = "Creation date";
		public string TextBlockCreationDate { get => textBlockCreationDate; set => Set(ref textBlockCreationDate, value); }

		private string textBlockLastAccessDate = "Last access date";
		public string TextBlockLastAccessDate { get => textBlockLastAccessDate; set => Set(ref textBlockLastAccessDate, value); }

		private string buttonChange = "Change";
		public string ButtonChange { get => buttonChange; set => Set(ref buttonChange, value); }

		private string textBlockFilesList = "List of filese in changed directory";
		public string TextBlockFilesList { get => textBlockFilesList; set => Set(ref textBlockFilesList, value); }



		public override void Build()
		{
			try
			{
				StreamReader reader = new StreamReader(languageFile);
				// тут код занесения в существующие свойства их перевода 
				reader.Close();
			}
			catch(Exception e)
			{
				return;
			}
		}

		private string GetTranslation(string propertyName, StreamReader reader)
		{
			string translation = null;
			string str = reader.ReadLine();
			while (str != null && (string.IsNullOrWhiteSpace(str) || str.TrimStart().StartsWith('#')))
			{
				str = reader.ReadLine();
			}
			if (str != null)
			{
				str = str.TrimStart();
				string[] propertyAndTranslation = str.Split('=', StringSplitOptions.RemoveEmptyEntries);
				if (propertyAndTranslation[0].Trim() == propertyName)
				{
					translation = propertyAndTranslation[1].TrimStart();
				}
			}			
			return translation;
		}
	}
}
