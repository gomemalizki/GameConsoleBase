using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class UserOperationMenu : MenuScreen
    {

        public UserOperationMenu() : base("user operations")
        {
            AddMenuItem("Update user name", new UpdateUserNameScreen());
            AddMenuItem("Update password", new UpdatePassword());
            AddMenuItem("View user details", new LoginScreen());
        }
    }
}
