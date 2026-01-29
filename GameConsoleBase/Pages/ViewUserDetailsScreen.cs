using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class ViewUserDetailsScreen:Screen
    {
        public ViewUserDetailsScreen() : base($"{GameApp.LoggedUser.Name} Details")
        {
        }
        public override void Show()
        {
            base.Show();
            User foundUser = DB.GameDB.GetUser(GameApp.LoggedUser.UserName);
            if (foundUser != null)
            {
                Console.WriteLine("Unknown user - Error");
                Screen login = new LoginScreen();
                login.Show();
            }
            else
            {
                Console.WriteLine($"Ur Name is: {foundUser.Name}");
                Console.WriteLine($"Ur Username is: {foundUser.UserName}");
                Console.WriteLine($"Ur Password is: {foundUser.Password}");
            }
            Screen login2 = new LoginScreen();
            login2.Show();
        }

    }
}
