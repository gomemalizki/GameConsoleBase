using GameConsoleBase.BaseClass;
using GameConsoleBase.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.App
{
	internal class GameApp
	{
		private Screen MainPage;

		public GameApp() {
			MainPage = new WelcomeScreen();
		}
		public void StartApp()
		{
			MainPage.Show();
		}

	}
}
