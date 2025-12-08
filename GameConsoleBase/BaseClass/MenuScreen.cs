using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.BaseClass
{
	internal class MenuScreen : Screen
	{
		protected Dictionary<string,Screen> menuItems = new Dictionary<string, Screen>();
		public MenuScreen(string title) : base(title)
		{

		}
		protected void AddMenuItem(string name, Screen screen)
		{
			menuItems.Add(name, screen);
		}

		public override void Show()
		{
			base.Show();
			bool exit = false;
			while (!exit)
			{
				int index = 1;
				int choose = 0;
				foreach (var item in menuItems.Keys)
				{
					Console.WriteLine($"{index}-{item}");
					index++;
				}
				Console.WriteLine($"{index}-Exit");
				Console.Write("Choose an option: ");
				if (int.TryParse(Console.ReadLine(), out choose))
				{
					if (choose >= 1 && choose < index)
					{
						menuItems.ElementAt(choose - 1).Value.Show();
					}
					else if (choose == index)
					{
						exit = true;
					}
					else
					{
						Console.WriteLine("Invalid option. Please try again.");
						Show();
					}

				}
			}
		}
			
	}
}
