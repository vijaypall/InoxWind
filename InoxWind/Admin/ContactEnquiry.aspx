<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ContactEnquiry.aspx.cs" Inherits="InoxWind.Admin.ContactEnquiry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="main-content">
        <div class="main-content-inner">
            <div class="breadcrumbs ace-save-state" id="breadcrumbs">
                <ul class="breadcrumb">
                    <li>
                        <i class="ace-icon fa fa-home home-icon"></i>
                        <a href="ContactEnquiry.aspx">Contact Enquiry</a>
                    </li>

                    <li class="active">
                        <a href="#">Contact Enquiry</a>
                    </li>
                </ul>
                <!-- /.nav-search -->
            </div>

            <div class="page-content">
                <div class="page-header">
                    <h1>Contact Enquiry List  <span class="pull-right"><i id="btnExportExcel" class="fa fa-file-excel-o" aria-hidden="true"></i></span>
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
    <script src="https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.18.5/xlsx.full.min.js"></script>
    <script>  
        $('#ContactEnquiry').addClass('active open');
     
    </script>
    <script>
        $("#btnExportExcel").click(function () {
            // Get table element
            var table = document.getElementById("example");  
            var workbook = XLSX.utils.table_to_book(table, { sheet: "Sheet1" });

            // Enforce text format on all cells
            workbook.Sheets["Sheet1"] = enforceTextFormat(workbook.Sheets["Sheet1"]);

            // Export to Excel
            XLSX.writeFile(workbook, "ContactEnquiry.xlsx");
        });
        function enforceTextFormat(sheet) {
            const range = XLSX.utils.decode_range(sheet['!ref']);
            for (let row = range.s.r; row <= range.e.r; row++) {
                for (let col = range.s.c; col <= range.e.c; col++) {
                    const cellAddress = XLSX.utils.encode_cell({ r: row, c: col });
                    const cell = sheet[cellAddress];

                    if (cell && cell.v !== undefined) {
                        cell.t = 's'; // Set the cell type to 's' for text
                        cell.z = '@'; // Set text format
                    }
                }
            }
            return sheet;
        }
</script>
</asp:Content>
