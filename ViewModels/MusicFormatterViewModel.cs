using System;
using System.Collections.Generic;
using System.Text;
using MusicApp.ViewModels.Base;
using MusicApp.View.InterfaceLanguage;
using System.Windows.Input;
using MusicApp.Infrastructure.Commands;
using MusicApp.Model.Formatter;

namespace MusicApp.ViewModels
{
	public class MusicFormatterViewModel : BaseViewModel
	{
		private FormatterInterfaceLanguage formatterInterfaceLanguage;
		public FormatterInterfaceLanguage FormatterInterfaceLanguage { get => formatterInterfaceLanguage; set =>
				Set(ref formatterInterfaceLanguage, value);
		}

		public Conductor Conductor { get; private set; }

		public MusicFormatterViewModel()
		{
			FormatterInterfaceLanguage = new FormatterInterfaceLanguage(null);
			Conductor = new Conductor();
			Conductor.FileInfos.Add(new System.IO.FileInfo("C:\\Projects\\VisualStudio\\Hobby\\MusicApp\\App.xaml"));
			Conductor.FileInfos.Add(new System.IO.FileInfo("C:\\Projects\\VisualStudio\\Hobby\\MusicApp\\App.xaml"));
			Conductor.FileInfos.Add(new System.IO.FileInfo("C:\\Projects\\VisualStudio\\Hobby\\MusicApp\\App.xaml"));
			Conductor.FileInfos.Add(new System.IO.FileInfo("C:\\Projects\\VisualStudio\\Hobby\\MusicApp\\App.xaml"));

			StartProcedureCommand = new LambdaCommand(OnStartProcedureCommandExecuted, CanStartProcedureCommandExecute);
		}

		private bool limitFilesLenght = false;
		public bool LimitFilesLenght { get => limitFilesLenght;
			set
			{
				Set(ref limitFilesLenght, value);
				TxtBoxLimitFilesLenghtEnable = value;
			}
		}

		private bool txtBoxLimitFilesLenghtEnable = false;
		public bool TxtBoxLimitFilesLenghtEnable { get => txtBoxLimitFilesLenghtEnable; set => Set(ref txtBoxLimitFilesLenghtEnable, value); }

		private bool uppercase = false;
		public bool Uppercase { get => uppercase; set => Set(ref uppercase, value); }

		private bool lowercase = false;
		public bool Lowercase { get => lowercase; set => Set(ref lowercase, value); }

		private bool registerDefault = true;
		public bool RegisterDefault { get => registerDefault; set => Set(ref registerDefault, value); }

		private bool cyrillic = false;
		public bool Cyrillic { get => cyrillic; set => Set(ref cyrillic, value); }

		private bool latin = false;
		public bool Latin { get => latin; set => Set(ref latin, value); }

		private bool alphabetDefault = true;
		public bool AlphabetDefault { get => alphabetDefault; set => Set(ref alphabetDefault, value); }

		private string txtLimitFilesLenght = "";
		public string TxtLimitFilesLenght { get => txtLimitFilesLenght; set => Set(ref txtLimitFilesLenght, value); }

		#region Commands
		public ICommand StartProcedureCommand { get; }
		private void OnStartProcedureCommandExecuted(object param)
		{

		}
		private bool CanStartProcedureCommandExecute(object param)
		{
			if (limitFilesLenght == true)
			{
				if (!int.TryParse(TxtLimitFilesLenght, out int num))
				{
					return false;
				}
				else if (num < 0)
				{
					return false;
				}
			}
			else if (AlphabetDefault == true && RegisterDefault == true)
			{
				return false;
			}
			return true;
		}
		#endregion

	}
}
