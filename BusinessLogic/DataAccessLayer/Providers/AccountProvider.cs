using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;

namespace BusinessLogic.DataAccessLayer.Providers
{
    public abstract class AccountProvider
    {
        public static AccountProvider _instance = null;
        static AccountProvider()
        {
            if (_instance == null)
                _instance = (AccountProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Account"].ToString()));
        } 
        #region Abstract Class
        public abstract User GetUserByEmail(string email);
        public abstract bool VerifyPassword(string enteredPassword, string storedHash, string storedSalt);
        public abstract string generatePwd(string password);
        #endregion
    }
}
