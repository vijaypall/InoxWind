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
    public abstract class MilestonesProvider
    {
        public static MilestonesProvider _instance = null;
        static MilestonesProvider()
        {
            if (_instance == null)
                _instance = (MilestonesProvider)Activator.CreateInstance(Type.GetType(ConfigurationManager.AppSettings["Milestones"].ToString()));
        }
        public abstract DataTable GetMilestonesList();
        public abstract int InsertMilestones(Milestones milestones);
        public abstract int UpdateMilestones(Milestones milestones);
        public abstract int DeleteMilestones(Milestones milestones);
        public abstract Milestones GetMilestonesById(int Id);
    }
}
