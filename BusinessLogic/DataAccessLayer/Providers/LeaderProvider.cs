using BusinessLogic.BusinessObjectModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataAccessLayer.Providers
{
   public abstract class LeaderProvider
    {
        public static LeaderProvider _instance = null;
        static LeaderProvider()
        {
            if (_instance == null)
                _instance = (LeaderProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Leader"].ToString()));
        }
        #region Abstract Class 
        public abstract Leader GetLeaderById(int Id);
        public abstract DataTable GetLeaderList();
        public abstract int InsertLeader(Leader leader);
        public abstract int UpdateLeader(Leader leader);
        public abstract int DeleteLeader(Leader leader); 
        #endregion
    }
}
