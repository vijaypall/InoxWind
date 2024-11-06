<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddOpening.aspx.cs" Inherits="InoxWind.Admin.AddOpening" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">career</a>
                    </li>
                    <li>
                        <a href="Opening.aspx">Opening</a>
                    </li>
                    <li class="active">Add Opening</li>
                </ul>
                <!-- /.breadcrumb -->


                <!-- /.nav-search -->
            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Add Opening </h1>
                </div>
                <!-- /.page-header -->

                <div class="row">
                    <div class="col-xs-12">
                        <form runat="server">

                            <div class="col-xs-12 col-sm-12">
                                <div class="widget-box">
                                    <div class="widget-header">
                                    </div>
                                    <div class="widget-body">
                                        <div class="widget-main">
                                            <div class="row" style="padding-left: 0;">
                                                <div class="form-group col-sm-4">
                                                    <label>Position Name*</label>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtPositionName" />
                                                    <span>
                                                        <asp:Label Text="" ID="lblPositionNameError" ForeColor="Red" runat="server" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>Location*</label>
                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtLocation" />
                                                    <span>
                                                        <asp:Label Text="" ID="lblLocationError" ForeColor="Red" runat="server" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>Minimum Qualification*</label>

                                                    <asp:TextBox runat="server" CssClass="form-control" ID="txtMinimumQual" />
                                                    <span>
                                                        <asp:Label Text="" ID="lbltxtMinimumQualError" ForeColor="Red" runat="server" /></span>
                                                </div>
                                                <div class="form-group col-sm-4">
                                                    <label>carrer Document*</label>
                                                    <asp:FileUpload runat="server" ID="fileCarrerDoc" AllowMultiple="false" />
                                                    <span>The uploaded document must be in PDF format.</span><br />
                                                    <br />
                                                    <span>
                                                        <asp:Label Text="" ID="lblcarrerDocumentError" runat="server" ForeColor="Red" />

                                                    </span>
                                                </div>
                                            </div>
                                            <%--   <div class="row">
                                                <div class="form-group col-sm-8" id="htmleditor" runat="server">
                                                    <div class="wysiwyg-editor" id="editor1" style="border: solid 1px #2C6AA0" runat="server"></div>
                                                    <asp:HiddenField ID="hdHtmleditor" runat="server" />
                                                    <div class="hr hr-double dotted"></div>
                                                </div>
                                                <div class="form-group col-sm-4"></div>
                                                <br />
                                                <span>
                                                    <asp:Label Text="" ID="lblhtmleditor" runat="server" ForeColor="Red" />

                                                </span>
                                            </div>--%>

                                            <asp:Button Text="Submit" ID="btnSubmit" runat="server" class="btn btn-sm btn-success" OnClick="btnSubmit_Click" />

                                            <asp:Button Text="Back" ID="Back" runat="server" class="btn btn-sm btn-danger" OnClientClick="window.history.go(-1); return false;" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- PAGE CONTENT ENDS -->
                        </form>
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
    <script type="text/javascript">  
        $('#career').addClass('active open');
        $('#Opening').addClass('active');
    
    </script>
</asp:Content>
