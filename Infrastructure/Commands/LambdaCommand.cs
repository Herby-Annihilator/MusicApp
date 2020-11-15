using System;
using System.Collections.Generic;
using System.Text;
using MusicApp.Infrastructure.Commands.Base;

namespace MusicApp.Infrastructure.Commands
{
	public class LambdaCommand : Command
	{
		private Action<object> execute;
		private Func<object, bool> canExecute;

		public LambdaCommand(Action<object> execute, Func<object, bool> canExecute)
		{
			this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
			this.canExecute = canExecute;
		}
		public override bool CanExecute(object parameter)
		{
			return canExecute?.Invoke(parameter) ?? true;
		}

		public override void Execute(object parameter)
		{
			execute.Invoke(parameter);
		}
	}
}
