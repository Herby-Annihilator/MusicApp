using System;
using System.Collections.Generic;
using System.Text;
using MusicApp.ViewModels.Base;
using MusicApp.View.InterfaceLanguage;

namespace MusicApp.ViewModels
{
	public class MusicFormatterViewModel : BaseViewModel
	{
		private FormatterInterfaceLanguage formatterInterfaceLanguage;
		public FormatterInterfaceLanguage FormatterInterfaceLanguage { get => formatterInterfaceLanguage; set =>
				Set(ref formatterInterfaceLanguage, value);
		}

		public MusicFormatterViewModel()
		{
			FormatterInterfaceLanguage = new FormatterInterfaceLanguage(null);
		}
	}
}
