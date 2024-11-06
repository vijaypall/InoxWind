using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Controller
{
  public static class LeaderController
    {
        public static Leader GetLeaderById(int Id) { return DbProvider.Leader.GetLeaderById(Id); }
        public static DataTable GetLeaderList() { return DbProvider.Leader.GetLeaderList(); }
        public static int InsertLeader(Leader leader) { return DbProvider.Leader.InsertLeader(leader); }
        public static int UpdateLeader(Leader leader) { return DbProvider.Leader.UpdateLeader(leader); }
        public static int DeleteLeader(Leader leader) { return DbProvider.Leader.DeleteLeader(leader); }
    }
}
