using GameConsoleBase.BaseClass;
using GameConsoleBase.Pages;

namespace GameConsoleBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//         Screen s=new Screen ("Game Console Base");
			//s.Show();
			WelcomeScreen s = new WelcomeScreen();
			s.Show();
			//Interfaces.IGamePlay game = new Games.FluffyBirdGame();
			// game.Play();
			// game=new Games.TetrisGame();
			// game.Play();
			// game=new Games.PacManGame();
			// game.Play();
		}
    }
}
