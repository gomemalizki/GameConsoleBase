using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.BaseClass;

namespace GameConsoleBase.Pages
{
	internal class WelcomeScreen: Screen
	{

		public WelcomeScreen() : base("Welcome to my Game Console")
		{
		}
		public override void Show()
		{
			base.Show();
			Console.ForegroundColor= ConsoleColor.Yellow;
			Console.BackgroundColor= ConsoleColor.Blue;
			HorizontalCenter("Enjoy a variety of classic games!");
			Console.ResetColor();
		}
	}
}
