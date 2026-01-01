using GameConsoleBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.DB
{
	internal static class GameDB
	{
		private static List<User> users = new List<User>()
		{
			new User("tal Simon", "talsi","1234")
		};

		public static bool RegisterUser(User user)
		{
			if(user==null) return false;
			if(users.Any(u=>u.UserName==user.UserName)) 
				return false;
			users.Add(user);
			return true;

		}
		
	}
}
