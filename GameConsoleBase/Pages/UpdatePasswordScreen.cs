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
        internal class UpdatePassword : Screen
        {
            public UpdatePassword() : base("Update Password Page")
            {
            }
            // הצגת מסך עדכון סיסמה
            public override void Show()
            {
                base.Show();

                User foundUser = DB.GameDB.GetUser(GameApp.LoggedUser.UserName);

                if (foundUser == null)
                {
                    Console.WriteLine("User not found.");
                    Screen login = new LoginScreen();
                    login.Show();
                }
                else
                {
                    Console.WriteLine("Enter New Password:");
                    String newPass = Console.ReadLine();
                    bool passwordUpdated = DB.GameDB.UpdatePassword(foundUser, newPass);
                    if (passwordUpdated == false)
                    {
                        Console.WriteLine("Failed to update password. Please try again.");
                        Screen login = new LoginScreen();
                        login.Show();
                    }
                    else
                    {
                        Console.WriteLine("Password updated successfully!");
                        Screen login = new LoginScreen();
                        login.Show();
                    }
                }
            }
        }
}
