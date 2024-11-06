using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind
{
    public partial class ApplyNow : System.Web.UI.Page
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
                    if (QueryStringParam.Count > 0)
                    {
                    //Code
                    }
                }
                catch
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", $"alert('URL Tampered.'); window.location.href ='Career.aspx'", true);
                    return;
                }
            }
            if (!IsPostBack)
            { }

        }
    }
}