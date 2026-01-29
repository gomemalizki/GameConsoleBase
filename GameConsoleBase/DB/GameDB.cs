using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.DB
{
    // מחלקה סטטית שמדמה בסיס נתונים של משתמשים
    internal static class GameDB
    {
        // רשימה שמכילה את כל המשתמשים הרשומים
        // התחלנו עם משתמש אחד לדוגמה: "tal Simon"
        private static List<User> users = new List<User>()
        {
            new User("tal Simon", "talsi", "1234")
        };

        // שיטה לרישום משתמש חדש
        // user - אובייקט שמייצג את המשתמש החדש
        // מחזירה true אם הרישום הצליח, אחרת false
        public static bool RegisterUser(User user)
        {
            // בדיקה אם המשתמש שהתקבל הוא null
            if (user == null) return false;

            // בדיקה אם שם המשתמש כבר קיים ברשימה
            if (users.Any(u => u.UserName == user.UserName))
                return false;

            // הוספת המשתמש החדש לרשימה
            users.Add(user);
            return true;
        }

        // שיטה להתחברות משתמש
        // userName - שם המשתמש
        // password - הסיסמה
        // מחזירה את המשתמש אם הפרטים נכונים, אחרת מחזירה null
        public static User Login(string userName, string password)
        {
            // חיפוש משתמש ברשימה לפי שם משתמש וסיסמה
            return users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }
        public static bool UpdateUserName(string userName, string userNameToUpdate)
        {
            if ( string.IsNullOrEmpty(userName)) return false;
            if ( string.IsNullOrEmpty(userNameToUpdate)) return false;

            var userToUpdate = users.FirstOrDefault(u => u.UserName == userName);
            if (userToUpdate == null)
            {
                return false;
            }
            userToUpdate.UserName = userNameToUpdate;

            return true;

        }
        public static User GetUser(string userName)
        {
            return users.FirstOrDefault(u => u.UserName == userName);
        }
        private static bool ValidPassword(string? password)
        {
            // סיסמה חייבת להיות לפחות 6 תווים, להכיל את הסימן '@', ואינה יכולה להיות ריקה
            if (password == null || password.Length < 6 || password.Contains("@") || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Password must be at least 6 characters long and contain '@' symbol.");
                return false;
            }
            return true;
        }


        public static bool UpdatePassword(User user, string newPassword)
        {
            if (user == null || newPassword == null)
                return false;

            else
            {
                // בדיקה שהסיסמה החדשה שונה מהישנה
                if ((user.Password != newPassword) && ValidPassword(newPassword))
                {
                    user.Password = newPassword;
                    return true;
                }
                else
                    return false;
            }


            // משתמש לא נמצא
            return false;
        }


    }
}
