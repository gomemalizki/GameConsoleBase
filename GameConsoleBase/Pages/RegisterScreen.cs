using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
	internal class RegisterScreen : Screen
	{
		public RegisterScreen() : base("Register Page")
		{
		}
		public override void Show()
		{

			base.Show();
			string name;
			string userName;
			string password;
			Console.WriteLine("Enter Name");
			name = Console.ReadLine();
			bool success = false;
			while (!success)
			{
				Console.WriteLine("enter desired user name  ");
				userName = Console.ReadLine();
				Console.WriteLine("Enter Password");
				password = Console.ReadLine();
				while (!IsValidPassword(password))
				{
					Console.WriteLine("Enter new Password");
					password = Console.ReadLine();
				}
				while (!IsValidUserName(userName))
				{
					Console.WriteLine("enter valid userName:");
					userName = Console.ReadLine();
				}

				success = GameDB.RegisterUser(new User(name, userName, password));
				if (success)
				{
					Console.WriteLine("Registration Successful!");
				}
				else
				{
					Console.WriteLine("Registration Failed! UserName already exists.");
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		private bool IsValidUserName(string? userName)
		{
			if (string.IsNullOrWhiteSpace(userName) || userName.Length < 4)
			{
				Console.WriteLine("UserName must be at least 4 characters long and cannot be empty.");
				return false;
			}
			return true;
		}

		private bool IsValidPassword(string? password)
		{
			if (password == null || password.Length < 6 || !password.Contains("@") || string.IsNullOrEmpty(password))
			{
				Console.WriteLine("Password must be at least 6 characters long and contain '@' symbol.");
				return false;
			}
			return true;
		}
	}
}
