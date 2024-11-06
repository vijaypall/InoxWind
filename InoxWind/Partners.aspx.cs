using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind
{
    public partial class Partners : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }

        }
        private string GetBaseDomain()
        {
            string baseDomain = Request.ServerVariables["HTTP_HOST"];
            string protocol = Request.IsSecureConnection ? "https://" : "http://";
            return protocol + baseDomain;
        }
        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = PartnerController.GetPartnerList();
            DataRow[] SupplyPartners = dataTable.Select("PartnerType ='Key Supply Partners' and Isactive=True");
            Array.Sort(SupplyPartners, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));
            DataRow[] ValuableCustomers = dataTable.Select("PartnerType ='Valuable Customers' and Isactive=True ");
            Array.Sort(ValuableCustomers, (x, y) => Comparer<int>.Default.Compare((int)x["ID"], (int)y["ID"]));
            StringBuilder SbSupplyPartners = new StringBuilder();
            foreach (DataRow row in SupplyPartners)
            {
                string path = GetBaseDomain() + "/WebsiteImages/" + row["PartnerImage"].ToString();
                SbSupplyPartners.Append("<div class='logo'><img src='" + path + "' alt=''></div>");
            }
            DIV_SupplyPartners.InnerHtml = SbSupplyPartners.ToString();
            StringBuilder SbValuableCustomers = new StringBuilder();
            foreach (DataRow row in ValuableCustomers)
            {
                string path = GetBaseDomain() + "/WebsiteImages/" + row["PartnerImage"].ToString();
                SbValuableCustomers.Append("<div class='logo'><img src='" + path + "' alt=''></div>");
            }
            DIV_ValuableCustomers.InnerHtml = SbValuableCustomers.ToString();

        }
    }
}