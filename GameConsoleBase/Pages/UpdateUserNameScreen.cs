using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameConsoleBase.Pages
{
    internal class UpdateUserNameScreen : Screen
    {
        public UpdateUserNameScreen() : base($"your current name is{GameApp.LoggedUser.Name}")
        {
        }
        public override void Show()
        {
            base.Show();
            string newUserName;
            bool success = false;
            while (!success)
            {
                // בקשה מהמשתמש להזין שם משתמש
                Console.WriteLine("enter new user name  ");
                newUserName = Console.ReadLine();

                // בדיקה אם שם המשתמש תקין
                while (!IsValidUserName(newUserName))
                {
                    Console.WriteLine("enter valid userName:");
                    newUserName = Console.ReadLine();
                }

                // ניסיון לרשום את שם המשתמש החדש בבסיס הנתונים
                success = GameDB.UpdateUserName(GameApp.LoggedUser.UserName, newUserName);

                //אם העדכון הצליח
                if (success)
                {
                    Console.WriteLine("updated name Successfuly!");
                }
                
                else
                {
                    Console.WriteLine("update name Failed!");
                }
            }

            // מחכה שהמשתמש ילחץ על מקש כלשהו לפני שמנקה את המסך
            Console.ReadKey();
            Console.Clear();
        }

        // שיטה שבודקת אם שם המשתמש תקין
        private bool IsValidUserName(string? userName)
        {
            // שם משתמש חייב להיות לפחות 4 תווים ואינו יכול להיות ריק
            if (string.IsNullOrWhiteSpace(userName) || userName.Length < 4)
            {
                Console.WriteLine("UserName must be at least 4 characters long and cannot be empty.");
                return false;
                
            }
            return true;
        }
    }
}