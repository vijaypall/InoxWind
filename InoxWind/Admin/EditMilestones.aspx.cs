using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Admin
{
    public partial class EditMilestones : System.Web.UI.Page
    {
        Dictionary<string, object> QueryStringParam = new Dictionary<string, object>();
        protected void Page_Load(object sender, EventArgs e)
        {
            string encryptedData = Request.QueryString["data"];
            if (!string.IsNullOrEmpty(encryptedData))
            {
                try
                {
                    QueryStringParam = CommonClass.QueryStringHelper.Decrypt(encryptedData);

                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('URL Tampered.'); window.location.href ='Login'", true);
                }
            }
            if (!IsPostBack)
            {
                FillValue(Convert.ToInt32(QueryStringParam["Id"]));
            }



        }
        private void FillValue(int Id)
        {
            BusinessLogic.BusinessObjectModel.Milestones milestones = MilestonesController.GetMilestonesById(Id);
            txtMilestonesName.Text = milestones.MilestonesName;
            txtMilestonesValue.Text = milestones.MilestonesValue;
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
        private void Clearall()
        {

            lblMilestonesName.Text = "";

            lblerrorMilestonesValue.Text = "";


        }
        protected void btSubmit_Click(object sender, EventArgs e)
        {
            Clearall();
            if (!Checkvalidation())
            {


                BusinessLogic.BusinessObjectModel.Milestones milestones = new BusinessLogic.BusinessObjectModel.Milestones();
                milestones.MilestonesName = txtMilestonesName.Text;
                milestones.MilestonesValue = txtMilestonesValue.Text;
                milestones.Id = Convert.ToInt32(QueryStringParam["Id"]);
                int result = MilestonesController.UpdateMilestones(milestones);
                if (result > 0)
                {
                    Response.Redirect("Milestones.aspx");
                }
            }
            else { return; }
        }
    }
}