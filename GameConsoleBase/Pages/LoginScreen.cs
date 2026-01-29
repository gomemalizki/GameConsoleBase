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
    internal class LoginScreen : MenuScreen
    {
        // בנאי (Constructor) של LoginScreen
        // קורא לבנאי של המחלקה הבסיסית (Screen) ומגדיר את הכותרת של המסך כ-"Login Page"
        public LoginScreen() : base("Login Page")
        {
        }

        // שיטה שמציגה את מסך ההתחברות
        public override void Show()
        {
            // מציג את הכותרת של המסך
            base.Show();

            // בקשה מהמשתמש להזין שם משתמש וסיסמה
            Console.WriteLine("Please enter user name and password:");
            Console.Write("User Name: ");
            string userName = Console.ReadLine(); // קריאת שם המשתמש מהקלט
            Console.Write("Password: ");
            string password = Console.ReadLine(); // קריאת הסיסמה מהקלט

            // ניסיון להתחבר עם שם המשתמש והסיסמה
            User user = DB.GameDB.Login(userName, password);

            // לולאה שממשיכה עד שהמשתמש מזין פרטים נכונים
            while (user == null)
            {
                // אם הפרטים שגויים, מציג הודעת שגיאה ומבקש לנסות שוב
                Console.WriteLine("Invalid credentials. Please try again.");
                Console.Write("User Name: ");
                userName = Console.ReadLine();
                Console.Write("Password: ");
                password = Console.ReadLine();
                user = DB.GameDB.Login(userName, password); // ניסיון נוסף להתחבר
            }

            // אם ההתחברות הצליחה, מציג הודעת ברוכים הבאים
            Console.WriteLine($"Welcome back, {user.Name}!");

            // שומר את המשתמש המחובר במשתנה הסטטי LoggedUser של GameApp
            GameApp.LoggedUser = user;

            // מחכה שהמשתמש ילחץ על מקש כלשהו לפני שמנקה את המסך
            Console.ReadKey();
            Console.Clear();

            // עובר למסך הבא
            AddMenuItem("User Operations", new UserOperationMenu());
            AddMenuItem("Game menu", new GameMenuScreen());

        }
    }
}
