
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller
{
    public static class LoginController
    {
        public static int UpdateLogin(Login login) { return DbProvider.Login.UpdateLogin(login); }
        public static Login GetLoginEmailDetail(string Email) { return DbProvider.Login.GetLoginEmailDetail(Email); }
        public static Login ValidateLogin(string Email,string password) { return DbProvider.Login.ValidateLogin(Email, password); }
    }
}
