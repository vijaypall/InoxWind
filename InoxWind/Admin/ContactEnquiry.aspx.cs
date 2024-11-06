using BusinessLogic.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InoxWind.Admin
{
    public partial class ContactEnquiry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["NewsToken"] = Guid.NewGuid().ToString();
                BindData();
            }

        }

        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = ContactEnquiryController.GetContactList();
            StringBuilder Sb = new StringBuilder();
            string StrHead = @"<table class='table table-striped table-bordered table-hover' id='example'  border='1' runat='server'><thead>
            <tr>
            <th>Id</th>
             <th>Full Name</th>
            <th class='hidden-480'>Email Id</th> 
            <th>Mobile Number</th> 
  <th>Nature Of Enquiry</th> 
<th>Description</th> 
<th>Date</th>
            </tr> 
            </thead>
            <tbody id='tableBody' runat='server'>";
            Sb.Append(StrHead);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DateTime createdDate = (DateTime)dataTable.Rows[i]["CreatedDate"];
                    string formattedDate = createdDate.ToString("dd-MM-yyyy");
                    Sb.Append("<tr><td>" + Convert.ToInt32(i + 1) + "</td><td>" + dataTable.Rows[i]["FullName"].ToString() + "</td><td>" + dataTable.Rows[i]["EmailId"].ToString() + "</td><td>" + dataTable.Rows[i]["MobileNo"].ToString() + "</td><td>" + dataTable.Rows[i]["NatureOfEnquiry"].ToString() + "</td><td>" + dataTable.Rows[i]["Description"].ToString() + "</td><td>" + formattedDate + "</td></tr>");
                }
            }
            string HeadEnd = "</tbody></table>";
            Sb.Append(HeadEnd);
            PopulateTable.InnerHtml = Sb.ToString();
        }
    }
}