<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Milestones.aspx.cs" Inherits="InoxWind.Admin.Milestones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="hidden" id="MilestonesToken" value="<%= Session["MilestonesToken"] %>" />
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                   <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Website Home</a>
                    </li> 
                    <li>
                   <a href="Milestones.aspx">MileStones</a>
                    </li> 
                </ul>
                <!-- /.breadcrumb -->


                <!-- /.nav-search -->
            </div>

            <div class="page-content">
                <div class="page-header">
                    <h1>Milestones List <span class="pull-right"><a href="AddMilestones.aspx" class="btn btn-primary btn-xs">Add New Editor</a></span>
                    </h1>
                </div>

                <div class="row">
                    <div class="col-xs-12">
                        <!-- PAGE CONTENT BEGINS -->

                        <div class="row">
                            <div class="col-xs-12">
                                <!-- div.dataTables_borderWrap -->
                                <div runat="server" id="PopulateTable">
                                    <%--<form runat="server">
                                    <table class="table table-striped table-bordered table-hover">
                                            <thead>
                                                <tr>
                                                    <th>Id</th>
                                                    <th>Partner image</th>
                                                    <th class="hidden-480">Partner Name</th> 
                                                    <th>action</th>
                                                </tr>
                                            </thead>

                                            <tbody id="tablebody" runat="server">
                                                <tr>
                                                    <td>1</td>
                                                    <td>data</td>
                                                    <td>data</td> 
                                                    <td>
                                                        <div class="hidden-sm hidden-xs action-buttons">
                                                            <a class="green" href="#">
                                                                <i class="ace-icon fa fa-pencil bigger-130"></i>
                                                            </a>
                                                            <a class="red" href="#">
                                                                <i class="ace-icon fa fa-trash-o bigger-130"></i>
                                                            </a>
                                                        </div>

                                                    </td>
                                                </tr>

                                            </tbody>
                                        </table>
                                    </form>--%>
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

    <script>  
        function deleteItem(id, status) {
            if (confirm("Are you sure you want to " + status + " this item?")) {
                debugger;
                var __RequestVerificationToken = $('#MilestonesToken').val();
                var url = '/WebService.asmx/MilestonesDelete'; //$('#csrfToken').attr('data-href-url');
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
            var url = 'EditMilestones.aspx?data=' + encodedData;
            window.location.href = url;
        }
        // $(document).ready(function () {
        //$('#myElement').removeClass('active').addClass('class2')

        $('#WebsiteHome').addClass('active open');
        $('#Milestones').addClass('active');
      // });

    </script>
</asp:Content>
