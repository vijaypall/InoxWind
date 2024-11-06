<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Editor.Master" ClientIDMode="Static"  ValidateRequest="false" AutoEventWireup="true" CodeBehind="EditLeader.aspx.cs" Inherits="InoxWind.Admin.EditLeader" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="#">Home</a>
                    </li>
                    <li>
                        <a href="Leader.aspx">Leader</a>
                    </li>
                    <li class="active">Add Leader</li>
                </ul>
                <!-- /.breadcrumb -->


                <!-- /.nav-search -->
            </div>

            <div class="page-content">

                <div class="page-header">
                    <h1>Add Leader </h1>
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
                                            <label>Category*</label>
                                            <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCategory">
                                                <asp:ListItem Text="SELECT" Value="0" />
                                                <asp:ListItem Text="Directors" Value="Directors" />
                                                <asp:ListItem Text="Leaders" Value="Leaders" />
                                            </asp:DropDownList>
                                            <span>
                                                <asp:Label Text="" ID="lblErrorCategoy" ForeColor="Red" runat="server" /></span>
                                        </div>
                                        <div class="form-group col-sm-4">
                                            <label>Name*</label>
                                            <asp:TextBox runat="server" ID="txtName" CssClass="form-control" />
                                            <span>
                                                <asp:Label Text="" ID="lblErrortxname" ForeColor="Red" runat="server" /></span>
                                        </div>
                                        <div class="form-group col-sm-4">
                                            <label>Designation*</label>
                                            <asp:TextBox runat="server" ID="txtDesignation" CssClass="form-control" />
                                            <span>
                                                <asp:Label Text="" ID="lblErrorDesignation" ForeColor="Red" runat="server" /></span>
                                        </div>
                                        <div class="form-group col-sm-4">
                                            <label>Lnikedin Url</label>
                                            <asp:TextBox runat="server" ID="txtlinkedin" CssClass="form-control" />
                                            <span>
                                                <asp:Label Text="" ID="lblerrortxtlinkedin" ForeColor="Red" runat="server" /></span>
                                        </div>
                                        <div class="form-group col-sm-4">
                                            <label>Profile Image*</label>
                                            <asp:FileUpload runat="server" ID="ftpprofileimg" AllowMultiple="false" />
                                            <span>The height*width ratio must be 250*392.</span>
                                            <br />
                                            <span>
                                                <asp:Label Text="" ID="lblerrorftpprofileimg" runat="server" ForeColor="Red" />

                                            </span>
                                        </div>

                                        <div class="form-group col-sm-4" style="margin-top: 20px">
                                            <div class="checkbox">
                                                <label class="block">
                                                    <%--<input name="form-field-checkbox" type="checkbox" class="ace input-lg">--%>
                                                    <asp:CheckBox ID="chkopenpoup" runat="server"  name="form-field-checkbox" Text="Open Poup" class="ace input-lg" />

                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="form-group col-sm-8" style="display: none;" id="htmleditor" runat="server">
                                            <div class="wysiwyg-editor" id="editor1" style="border: solid 1px #2C6AA0"  runat="server"></div>
                                            <asp:HiddenField ID="hdHtmleditor" runat="server" />
                                            <div class="hr hr-double dotted"></div>
                                        </div>
                                        <div class="form-group col-sm-4"></div>
                                    </div>

                                    <asp:Button Text="Submit" ID="btnSubmit" runat="server" class="btn btn-sm btn-success"
                                        OnClientClick="return CallJavaScript();" OnClick="btnSubmit_Click" />

                                    <asp:Button Text="Back" ID="Back" runat="server" class="btn btn-sm btn-danger" OnClientClick="window.history.go(-1); return false;" />
                               </div></div> </div>
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

        $('#Leader').addClass('active');
        function CallJavaScript() {
            var editorContent = $('#editor1').html();
            $('#hdHtmleditor').val(editorContent);
            return true;
        }
        function checkedunchecked() { 
            //if (($('#chkopenpoup').is(':checked')))
            if ($('#chkopenpoup:checked').length)
            {
                $('#htmleditor').show();
            } else {
                $('#htmleditor').hide();
            }
        }
        $(document).ready(function () {
            checkedunchecked();
            $('#chkopenpoup').change(function () {
                debugger;
                checkedunchecked();
            });
        });
    </script>
</asp:Content>
