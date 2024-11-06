using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.Controller
{
    public class AccountController
    {
        #region Abstract methods 
        public static User GetUserByEmail(string email)
        {
            User User = DbProvider.Account.GetUserByEmail(email);
            return User;
        }
        public static bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt)
        {
           return  DbProvider.Account.VerifyPassword(enteredPassword, storedHash, storedSalt);

        }
        public static string generatePwd(string password)
        {
            return DbProvider.Account.generatePwd(password);
        }
        #endregion
    }
}
