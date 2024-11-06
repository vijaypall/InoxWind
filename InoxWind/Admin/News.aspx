<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="InoxWind.Admin.News" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="hidden" id="NewsToken" value="<%= Session["NewsToken"] %>" />
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="News.aspx">News Room</a>
                    </li>

                    <li class="active">
                        <a href="#">News</a>
                    </li>
                </ul>
                <!-- /.nav-search -->
            </div>

            <div class="page-content">
                <div class="page-header">
                    <h1>News List <span class="pull-right"><a href="AddNews.aspx" class="btn btn-primary btn-xs">Add News</a></span>
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

   <%-- <div class="modal fade" id="myModal" role="dialog">
        <div class="modal-dialog" style="background:none; opacity: 1;" > 
            <!-- Modal content-->
            <div class="modal-content" style="background:none; opacity: 1;" >
                <div class="modal-header" style="border:none;">
                </div>
                <div class="modal-body">
                    <div id="progressbar" class="ui-progressbar ui-widget ui-widget-content ui-corner-all progress progress-striped active" role="progressbar" aria-valuemin="0" aria-valuemax="100" aria-valuenow="37">
                        <div class="ui-progressbar-value ui-widget-header ui-corner-left progress-bar progress-bar-success" style="width: 37%;"></div>
                    </div>

                </div>
            </div>
        </div>
    </div>
     <button type="button" class="btn btn-info btn-lg" data-toggle="modal" id="btnmodelcall" data-target="#myModal"></button>--%>
    <script>
        //$(document).ready(function () {
        //    $('#btnmodelcall').trigger('click');
        //}); 

        $('#NewRoomUI').addClass('active open');
        $('#Newsli').addClass('active');
        function deleteItem(id, status) {
            if (confirm("Are you sure you want to " + status + " this item?")) {
                debugger;
                var __RequestVerificationToken = $('#NewsToken').val();
                var url = '/WebService.asmx/DeleteNews'; //$('#csrfToken').attr('data-href-url');
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
            var url = 'EditNews.aspx?data=' + encodedData;
            window.location.href = url;
        }
    </script>
</asp:Content>
