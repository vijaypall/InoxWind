using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Admin
{
    public partial class AddMilestones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool Checkvalidation()
        {
            bool _vall = false;
            if (string.IsNullOrEmpty(txtMilestonesName.Text))
            {
                lblMilestonesName.Text = "Please enter milestone name.";
                _vall = true;
            }
            if (string.IsNullOrEmpty(txtMilestonesValue.Text))
            {
                lblerrorMilestonesValue.Text = "Please enter milestone value.";
                _vall = true;
            }
            return _vall;

        }
        private void  Clearall() { lblMilestonesName.Text = ""; lblerrorMilestonesValue.Text = ""; }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {

                BusinessLogic.BusinessObjectModel.Milestones milestones = new BusinessLogic.BusinessObjectModel.Milestones();

                milestones.MilestonesName = txtMilestonesName.Text;
                milestones.MilestonesValue = txtMilestonesValue.Text;
                int result = MilestonesController.InsertMilestones(milestones);
                if (result > 0)
                {
                    Response.Redirect("MileStones.aspx");
                }
            }
            else { return; }

        }
    }
}