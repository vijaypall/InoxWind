<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddQualityCertificate.aspx.cs" Inherits="InoxWind.Admin.AddQualityCertificate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content-inner">
        <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                <li>
                    <i class="ace-icon fa fa-home home-icon"></i>
                    <a href="#">Home</a>
                </li>

                <li>
                    <a href="QualityCertificate.aspx">Quality Certificate</a>
                </li>
                <li class="active">Add Quality Certificate</li>
            </ul>
            <!-- /.breadcrumb -->

            
            <!-- /.nav-search -->
        </div>

        <div class="page-content">
            <div class="page-header">
                <h1>Add Quality Certificate
                </h1>
            </div>
            <!-- /.page-header -->

            <div class="row">
                <div class="col-xs-12">
                    <!-- PAGE CONTENT BEGINS -->
                    <form role="form" runat="server">
                        <div class="row">
                            <!-- /.span -->
                            <div class="col-xs-12 col-sm-12">
                                <div class="widget-box">
                                    <div class="widget-header">
                                    </div>
                                    <div class="widget-body">
                                        <div class="widget-main">
                                            <div class="row">
                                                <div class="form-group col-sm-4">
                                  
                                                <label>Certificate Content*</label>
                                                <asp:TextBox runat="server" ID="txtCertificateContent" CssClass="form-control" />  
                                                <span>
                                                    <asp:Label Text="" ID="lblContentError" runat="server" ForeColor="Red" /></span>
                                            </div>
                                                <div class="form-group col-sm-4">
                                                <label>Upload Quality Certificate*</label>

                                                <asp:FileUpload runat="server" ID="ftpBannerUpload"  AllowMultiple="false" />
                                                    <span>The uploaded document must be in PDF format.</span><br />
                                                <span>
                                                    <asp:Label Text="" ID="lblerroruploadlogo" runat="server" ForeColor="Red" /></span>
                                            </div></div>
                                            <asp:Button Text="Submit" ID="btSubmit" runat="server" class="btn btn-sm btn-success" OnClick="btSubmit_Click" />
                                            <asp:Button Text="Back" ID="Back" runat="server" class="btn btn-sm btn-danger" OnClientClick="window.history.go(-1); return false;" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- /.span -->

                        </div>
                        <!-- /.row -->

                    </form>

                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
        <!-- /.page-content -->
    </div>
     
  <script type="text/javascript">$("#QualityCertificate").addClass("active");</script>
</asp:Content>
