using BusinessLogic.BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.Providers
{
   public abstract class LoginProvider
    {
        public static LoginProvider _instance = null;
        static LoginProvider()
        {
            if (_instance == null)
                _instance = (LoginProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Login"].ToString()));
        }

        public abstract int UpdateLogin(Login login); 
        public abstract Login GetLoginEmailDetail(string Email);
        public abstract Login ValidateLogin(string Email, string Password);
    }
}
