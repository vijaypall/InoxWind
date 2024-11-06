using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.BusinessObjectModel;
using BusinessLogic.DataAccessLayer.Providers;

namespace BusinessLogic.Controller
{
    public static class MilestonesController
    {
        public static DataTable GetMilestonesList() { return DbProvider.Milestones.GetMilestonesList(); }
        public static int InsertMilestones(Milestones milestones) { return DbProvider.Milestones.InsertMilestones(milestones); }
        public static int UpdateMilestones(Milestones milestones) { return DbProvider.Milestones.UpdateMilestones(milestones); }
        public static int DeleteMilestones(Milestones milestones) { return DbProvider.Milestones.DeleteMilestones(milestones); }
        public static Milestones GetMilestonesById(int Id) { return DbProvider.Milestones.GetMilestonesById(Id); }
    }
}
