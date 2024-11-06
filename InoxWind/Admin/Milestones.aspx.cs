﻿using BusinessLogic.Controller;
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
    public partial class Milestones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["MilestonesToken"] = Guid.NewGuid().ToString();
                BindData();
            }

        }
        private void BindData()
        {
            DataTable dataTable = new DataTable();
            dataTable = MilestonesController.GetMilestonesList();
            StringBuilder Sb = new StringBuilder();
            string StrHead = @"<table class='table table-striped table-bordered table-hover'id='example'  border='1' runat='server'><thead>
            <tr>
            <th>Id</th> 
            <th>Milestones Name</th>
            <th>Milestones Value</th>
            <th>Status</th>
             <th>Action</th>
            </tr> 
            </thead>
            <tbody id='tableBody' runat='server'>";
            Sb.Append(StrHead);
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {

                    string EncriptQS = CommonClass.QueryStringHelper.Encrypt("Id=" + dataTable.Rows[i]["ID"].ToString());
                    string Status = "Active";
                    if (!Convert.ToBoolean(dataTable.Rows[i]["IsActive"]))
                    {
                        Status = "In-Active";
                        Sb.Append("<tr><td>" + Convert.ToInt32(i + 1) + "</td><td>" + dataTable.Rows[i]["MilestonesName"].ToString() + "</td><td>" + dataTable.Rows[i]["MilestonesValue"].ToString() + "</td><td>" + Status + "</td>   <td> <div class='hidden-sm hidden-xs action-buttons'><a class='gray' style='color:gray' /><i class='ace-icon fa fa-pencil bigger-130'></i></a> <a class='green' attr-href-data='In-Active'  onclick=\"deleteItem('" + dataTable.Rows[i]["ID"] + "','Active')\" /> <i class='ace-icon fa fa-check bigger-130'></i> </a> </div></td></tr>");
                    }
                    else
                    {
                        Sb.Append("<tr><td>" + Convert.ToInt32(i + 1) + "</td><td>" + dataTable.Rows[i]["MilestonesName"].ToString() + "</td><td>" + dataTable.Rows[i]["MilestonesValue"].ToString() + "</td><td>" + Status + "</td>   <td>  <div class='hidden-sm hidden-xs action-buttons'><a class='blue' onclick=\"EditItem('" + HttpUtility.HtmlEncode(EncriptQS) + "')\" /><i class='ace-icon fa fa-pencil bigger-130'></i></a> <a class='red' onclick=\"deleteItem('" + dataTable.Rows[i]["ID"] + "','In-Active')\" /> <i class='ace-icon fa fa-times bigger-130'></i> </a> </div> </td></tr>");
                    }
                }
            }
            string HeadEnd = "</tbody></table>";
            Sb.Append(HeadEnd);
            PopulateTable.InnerHtml = Sb.ToString();
        }
    }
}