<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="press-release.aspx.cs" Inherits="InoxWind.press_release" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="inner-banner">
        <img src="./assets/images/press-banner.jpg" alt="" />
    </section>
    <section class="newspaper-adv press-release">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title"><span>Press Releases</span></p>
                    <p>
                        Stay informed with the latest updates and press releases from Inox Wind, featuring project launches, financial reports, corporate announcements, industry insights, and essential information for stakeholders and partners.
                    </p>
                </div>
                <div class="tab-contents">
                    <div class="content-table">
                        <div id="Populatetable" runat="server"></div>
                        <table id="data-table" class="inox_windtable">
                            <thead>
                                <tr>
                                    <th>Particulars
                                    </th>
                                    <th>Date
                                    </th>
                                </tr>
                            </thead>
                            <tbody> 
                            </tbody>
                        </table>
                        <div class="loadbuttons mcontainer">
                            <button class="main-button" id="btnLoadMore">
                                <span>Load More</span>
                            </button>
                        </div>
                        <%--       <div id="loading">  Loading more products...</div>--%>
                        <input type="hidden" id="hfLastLoadedID" value="0" />
                    </div>
                </div>
            </div>
        </div>
    </section>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script>
        /*const { table } = require("node:console");*/

        $(document).ready(function () {
            loadMoreData();

            $("#btnLoadMore").click(function () {
                loadMoreData();
                $(this).focus();
            });
            function loadMoreData() {
                var lastID = $('#hfLastLoadedID').val();
                $.ajax({
                    type: "POST",
                    url: "/WebService.asmx/GetNews",
                    data: JSON.stringify({ Id: lastID, NewsType:"Press Releases" }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        if (response.d) {
                            var NewsRoom = response.d;
                            var tableBody = $('#data-table tbody');

                            $.each(NewsRoom, function (index, NewsRoom) {
                                //tableBody.append('<tr><td>' + product.ProductID + '</td><td>' + product.ProductName + '</td><td>' + product.Price + '</td></tr>');

                                var href = window.location.origin + NewsRoom.NewsDoc;
                                href = "'" + href + "'";
                                tableBody.append('<tr onclick="window.open('+ href+')"><td><i class="bi bi-file-earmark-text" style="font-size:18px; color:#0154A4"></i>' + NewsRoom.ParticularsORNewspaper + '</td><td><i class="bi bi-calendar4"  style="font-size:16px; color:#0154A4"></i>' + NewsRoom.NewsDATE + '</td></tr>');
                            });

                            // Update the last loaded ID
                            $('#hfLastLoadedID').val(NewsRoom[NewsRoom.length - 1].Id);
                        }
                    },
                    error: function (error) {
                        console.error(error);
                    }
                });
            }
        });
    </script>
</asp:Content>
