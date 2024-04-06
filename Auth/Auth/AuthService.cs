using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Auth
{
    public class AuthService
    {
        public string Login(string UserName, string password)
        {
            if (UserName == Const.Const.UserName  && password == Const.Const.Password) return Const.Const.SuccessfullLogin;
            else return Const.Const.LoginFail;
        }
        
    }
}
