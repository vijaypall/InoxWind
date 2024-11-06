<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Editor.Master" ClientIDMode="Static" ValidateRequest="false" AutoEventWireup="true" CodeBehind="AddProductImage.aspx.cs" Inherits="InoxWind.Admin.AddProductImage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                   <ul class="breadcrumb">
                <li>
                    <i class="ace-icon fa fa-home home-icon"></i>
                    <a href="#">Product</a>
                </li>
                <li> 
                    <a href="Product.aspx">Product Image</a>
                </li>
                <li class="active">Add Product Image</li>
            </ul>
                <!-- /.breadcrumb -->


                <!-- /.nav-search -->
            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Add Product Image</h1>
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
                                                    <label>Product*</label>
                                                    <asp:DropDownList runat="server" CssClass="form-control" ID="DdlProduct">
                                                    </asp:DropDownList>
                                                    <span>
                                                        <asp:Label Text="" ID="lblProductError" ForeColor="Red" runat="server" /></span>
                                                </div> 
                                                <div class="form-group col-sm-4">
                                                    <label>Upload Product Image*</label>
                                                    <asp:FileUpload runat="server" ID="fileProductimage" AllowMultiple="false" />
                                                    <span>The height*width ratio must be 440*601.</span>
                                                    <br />
                                                    <span>
                                                        <asp:Label Text="" ID="lblProductimageError" runat="server" ForeColor="Red" />

                                                    </span>
                                                </div>
                                            </div>
                                            <div class="row">
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
                                            </div>

                                            <asp:Button Text="Submit" ID="btnSubmit" runat="server" class="btn btn-sm btn-success"
                                                OnClientClick="return CallJavaScript();" OnClick="btnSubmit_Click" />

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
        $('#Product').addClass('active open');
        $('#ProductImage').addClass('active');
        function CallJavaScript() {
            var editorContent = $('#editor1').html();
            $('#hdHtmleditor').val(editorContent);
            return true;
        }
    </script>
</asp:Content>
