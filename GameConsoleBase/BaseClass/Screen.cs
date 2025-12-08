using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.BaseClass
{
	internal class Screen
	{
		private string title;

		public Screen(string title)
		{
			this.title = title;

		}
		public virtual void Show()
		{
			Console.Clear();
			Console.ForegroundColor= ConsoleColor.Magenta;
			CenterText(title);
			Console.ResetColor();
		}

		public void CenterText(string text)
		{
			Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
			Console.WriteLine(text);
		}

		public void HorizontalCenter(string text)
		{
			Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight/2-Console.CursorTop/2);
			Console.WriteLine(text);
		}
	}
}
