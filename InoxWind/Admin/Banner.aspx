﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Banner.aspx.cs"
    Inherits="InoxWind.Admin.Banner" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="hidden" id="csrfToken" value="<%= Session["csrfToken"] %>" data-href-url="<%= ResolveUrl("~/Banner.aspx/DeleteItem") %>" />
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Website Home</a>
                    </li>

                    <li class="active">
                        <a href="#">Banner</a>
                    </li>
                </ul>
                <!-- /.breadcrumb -->

                <!-- /.nav-search -->
            </div>

            <div class="page-content">
                <div class="page-header">
                    <h1>Home Banner List <span class="pull-right"><a href="AddBanner.aspx" class="btn btn-primary btn-xs">Add New Banner</a></span>
                    </h1>
                </div>
                <!-- /.page-header -->

                <div class="row">
                    <div class="col-xs-12">
                        <!-- PAGE CONTENT BEGINS -->

                        <div class="row">
                            <div class="col-xs-12">
                                <!-- div.dataTables_borderWrap -->

                                <div runat="server" id="PopulateTable">
                                </div>
                            </div>
                        </div>

                        <!-- PAGE CONTENT ENDS -->
                    </div>
                    <!-- /.col -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /.page-content -->
        </div>
    </div>
    <!-- /.main-content --> 

    <script>   
        $('#WebsiteHome').addClass('active open');
        $('#Banner').addClass('active');
        function deleteItem(id, status)  {
            if (confirm("Are you sure you want to " + status + " this item?")) {
                debugger;
                var __RequestVerificationToken = $('#csrfToken').val();
                var url = '/WebService.asmx/BannerDelete'; //$('#csrfToken').attr('data-href-url');
                $.ajax({
                    type: "POST",
                    url: url,
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify({ id: id, __RequestVerificationToken: __RequestVerificationToken }),
                    success: function (response) {
                        debugger;
                        if (response.d == "success") {
                            if (status == 'Active') {
                                status = 'Activated';
                            } else if (status == 'In-Active') {
                                status = 'In-Activated';
                            }
                            alert("Item " + status + " Sucessfully");
                            location.reload();
                        } else {
                            alert(response.d);
                        }
                    },
                    error: function () {
                        alert("An error occurred while trying to delete the item.");
                    }
                });
            }
        }

        function EditItem(data) {
            var encodedData = encodeURIComponent(data);
            var url = 'EditBanner.aspx?data=' + encodedData;
            window.location.href = url;
        }

    </script>
</asp:Content>
