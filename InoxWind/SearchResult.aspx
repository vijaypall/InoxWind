<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="InoxWind.SearchResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .search_rslt p a {
            text-decoration: none;
            margin-right: 3px;
        }

        .search_rslt {
            padding: 50px 0;
        }

            .search_rslt p a.active {
                color: #d92020;
                font-weight: 600;
            }

        .dt-length, .dt-search, .dt-column-order, .dt-layout-start {
            display: none !important;
        }

        .dt-paging nav {
            z-index: 99;
        }

        .dt-layout-end {
            display: block !important;
            margin: 0 !important;
        }

        .active > .page-link, .page-link.active {
            background-color: #177CB4 !important;
            border-color: #177CB4 !important;
        }
    </style>
    <!-- Datatable -->
    <link rel="stylesheet" href="https://cdn.datatables.net/2.1.8/css/dataTables.bootstrap.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="inner-banner">
        <img src="./assets/images/leadership.jpg" alt="" />
    </section>
    <%--  <section class="about-text manufacabout">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title"> <span>Search Result</span></p>
                    <p>
                     </p>
                </div>
            </div>
        </div>
    </section>--%>

    <%--<div class="search_rslt">
	<div class="container">
		<p>Results <b>1</b> - <b>10</b> of <b>00</b> for <b>Bank</b>.</p>

		<h6><a href="#">About Us</a></h6>
		<p><b>Bank</b> Commitments and Contingencies Income Taxes Derivative Instruments Geographic Information Minority Business Investment Subsequent Events Accounting Policies Description of Business and Summary ...</p>

		<h6><a href="#">About Inox</a></h6>
		<p><b>Bank</b> Commitments and Contingencies Income Taxes Derivative Instruments Geographic Information Minority Business Investment Subsequent Events Accounting Policies Description of Business and Summary ...</p>

		<h6><a href="#">Home</a></h6>
		<p><b>Bank</b> Commitments and Contingencies Income Taxes Derivative Instruments Geographic Information Minority Business Investment Subsequent Events Accounting Policies Description of Business and Summary ...</p>

		<p>Result Page: 
			<a href="#" class="active">1</a> 
			<a href="#">2</a> 
			<a href="#">3</a> 
			<a href="#">4</a> 
			<a href="#">5</a> 
			<a href="#">Next</a> 
		</p>

	</div>
</div>--%>
    <div class="search_rslt">
        <div class="container">
            <p class="main-title" style="padding-top: 10px">
                <span>Results <b>
                    <asp:Label ID="TotalSearch" Text="0" runat="server" /></b> for <b>  <asp:Label ID="lblSearchText" ClientIDMode="Static" Text="0" runat="server" /></b></span>
            </p> 
            <div class="row">
                <div class="col-xs-12">
                    <!-- PAGE CONTENT BEGINS -->
                    <div id="PouplateData" runat="server"></div>
                    <%--<table id="example" style="width: 100%">
                        <thead>
                            <tr>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <h6><a href="#">About Us</a></h6>
                                    <p><b>Bank</b> Commitments and Contingencies Income Taxes Derivative Instruments Geographic Information Minority Business Investment Subsequent Events Accounting Policies Description of Business and Summary ...</p>


                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h6><a href="#">About Inox</a></h6>
                                    <p><b>Bank</b> Commitments and Contingencies Income Taxes Derivative Instruments Geographic Information Minority Business Investment Subsequent Events Accounting Policies Description of Business and Summary ...</p>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <h6><a href="#">Home</a></h6>
                                    <p><b>Bank</b> Commitments and Contingencies Income Taxes Derivative Instruments Geographic Information Minority Business Investment Subsequent Events Accounting Policies Description of Business and Summary ...</p>
                                </td>
                            </tr>
                          
                        </tbody>
                    </table>--%>
                    <!-- PAGE CONTENT ENDS -->
                </div>
                <!-- /.col -->
            </div>
            <!-- /.row -->
        </div>
    </div>
    <!-- Datatable -->
    <!-- basic scripts -->

    <!--[if !IE]> -->
    <script src="Admin/assets/js/jquery-2.1.4.min.js"></script>

    <!-- Datatable -->
    <script src="https://cdn.datatables.net/2.1.8/js/dataTables.js"></script>
    <script src="https://cdn.datatables.net/2.1.8/js/dataTables.bootstrap.js"></script>
    <script type="text/javascript">
        new DataTable('#example');

        $(document).ready(function () {  
            $("#txtsearh").val($("#lblSearchText").text());
        }); 

    </script>
</asp:Content>
