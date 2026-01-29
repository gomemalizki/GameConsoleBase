using GameConsoleBase.BaseClass;
using GameConsoleBase.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
	internal class PostLoginMenuScreen : MenuScreen
	{
		public PostLoginMenuScreen() : base("Post Login Menu")
		{
			AddMenuItem("Game menu", new GameMenuScreen());
			AddMenuItem("User operations", new UserOperationMenu());

		}
	}
}
