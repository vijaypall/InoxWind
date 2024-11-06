<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="media-coverage.aspx.cs" Inherits="InoxWind.media_coverage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="inner-banner">
        <img src="./assets/images/media-banner.jpg" alt="" />
    </section>
    <section class="media-content">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title"><span>Media Coverage</span></p>
                    <p>
                        Discover what the outside world is saying about Inox Wind, and know about the various explore media coverage, industry insights, and external perspectives to stay updated on our impact, innovations, and the latest industry trends.
                    </p>
                </div>
                <div class="mcontainer media-listbox">
                    <div class="daily-side">
                        <p class="min-title">
                            Daily Reports
                        </p>
                        <div class="media-list mcontainer" id="PopulateDailyNews">

                            
                        </div>
                    </div>
                    <div class="latest-side">
                        <p class="min-title">
                            Latest News
                        </p>
                        <div class="media-list" runat="server" id="populateLatestNews">
                           
                        </div>
                    </div>
                </div>
                <div class="loadbuttons mcontainer">
                    <button class="main-button" id="btnLoadMoreDailyNews">
                        <span>Load More</span>
                    </button>
                    <input type="hidden" name="name" value="0" id="hdLoadMoreDailyNews" />
                </div>
            </div>
        </div>
    </section>
    <section class="newspaper-adv">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title"><span>Newspaper Advertisements</span></p>
                    <p>
                        Stay updated with the top newspaper headlines about Inox Wind. Read about our achievements, industry impact, and innovations as covered by leading publications, and see how our advancements are making headlines in the broader media landscape.
                    </p>
                </div>
                <div class="news-tabs mcontainer">
                    <div class="tab-news active">
                        <p>
                            Notice of Board Meeting
                        </p>
                    </div>
                    <div class="tab-news">
                        <p>
                            Financials Results
                        </p>
                    </div>
                    <div class="tab-news">
                        <p>
                            Notice to Shareholders
                        </p>
                    </div>
                </div>
                <div class="tab-contents">

                    <div class="content-table">
                        <table id="data-table-firstTab" class="inox_windtable">
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
                            <button class="main-button" id="btnFirstLoadMore">
                                <span>Load More</span>
                            </button>
                        </div>
                        <input type="hidden" id="hdFtabLastLoadedID" value="0" />
                    </div>
                    <div class="content-table">
                        <table id="data-table-SecondTab" class="inox_windtable">
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
                            <button class="main-button" id="btnSecondLoadMore">
                                <span>Load More</span>
                            </button>
                        </div>
                        <input type="hidden" id="hdSecabLastLoadedID" value="0" />
                    </div>
                    <div class="content-table">
                        <table id="data-table-ThirdTab" class="inox_windtable">
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
                            <button class="main-button" id="btnThirdLoadMore">
                                <span>Load More</span>
                            </button>
                            <input type="hidden" value="0" id="hdThirdabLastLoadedID" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div class="media-popup">
        <div class="media-container">
            <div class="media-video">
                <p class="video-title">Devansh Jain - IWL -CNBC AWAAZ</p>
                <div class="main-video">
                    <video playsinline>
                        <source src="https://inoxwind.com/uploads/video/Devansh%20Jain%20-%20IWL%20-CNBC%20AWAAZ%20-%2001.09.15.mp4" />
                        Your browser does not support video tag.
                    </video>
                </div>
                <div class="close-popup">
                    <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                        <path d="M18 6L6 18M6 6L18 18" stroke="black" stroke-linecap="round" stroke-linejoin="round"></path>
                    </svg>
                </div>
            </div>
        </div>
    </div>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            // Tab functionality (unchanged)
            const tabs = document.querySelectorAll('.tab-news');
            const contents = document.querySelectorAll('.content-table');
            let actTab = tabs[0];
            let actContent = contents[0];

            tabs.forEach((elem, i) => {
                elem.addEventListener('click', function () {
                    actTab.classList.remove('active');
                    elem.classList.add('active');
                    actContent.style.display = 'none';
                    contents[i].style.display = 'block';
                    actTab = elem;
                    actContent = contents[i];
                });
            });

            // Event delegation for media-pop items
            const mediaPop = document.querySelector('.media-popup');
            const mediaTitle = document.querySelector('.media-popup .video-title');
            const mediaVideo = document.querySelector('.media-popup video');
            const closeBtn = document.querySelector('.close-popup');

            document.addEventListener('click', function (event) {
                // Check if the clicked element is a `.media-pop`
                const media = event.target.closest('.media-pop');
                if (media) {
                    const video = media.dataset.video;
                    const title = media.querySelector('.title');

                    mediaTitle.innerHTML = title.innerHTML;
                    mediaVideo.src = video;
                    mediaPop.style.display = 'block';
                    mediaVideo.play();
                }
            });

            closeBtn.addEventListener('click', function () {
                mediaVideo.pause();
                mediaPop.style.display = 'none';
            });
        });
    </script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script> 
        $(document).ready(function () {
            DailyNewsloadMoreData();
            $("#btnLoadMoreDailyNews").click(function () {
                DailyNewsloadMoreData();
                $(this).focus();
            });
            FirstTabloadMoreData();
            SecondTabloadMoreData();
            ThirdTabloadMoreData();
            $("#btnFirstLoadMore").click(function () {
                FirstTabloadMoreData();
                $(this).focus();
            });
            $("#btnSecondLoadMore").click(function () {
                SecondTabloadMoreData();
                $(this).focus();
            });
            $("#btnThirdLoadMore").click(function () {
                ThirdTabloadMoreData();
                $(this).focus();
            });
            function DailyNewsloadMoreData() {
                var lastID = $('#hdLoadMoreDailyNews').val();
                $.ajax({
                    type: "POST",
                    url: "/WebService.asmx/GetDailyNews",
                    data: JSON.stringify({ Id: lastID }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        if (response.d) {
                            var DailyNews = response.d;
                            var Div = $('#PopulateDailyNews');
                            $.each(DailyNews, function (index, DailyNews) {
                                var NewsImage = window.location.origin + "/WebsiteImages/" + DailyNews.NewsImage;
                                NewsImage = "'" + NewsImage + "'";
                                var NewsLink = "'" + DailyNews.NewsLink + "'";
                                if (DailyNews.OpenMediaPopup == true) {
                                    var popup = "<div class='media-card media-pop' data-video=" + NewsLink + "><img src=" + NewsImage + " alt='' style='height:157px;width:286px' /><div class='content-side'><div class='tag'> <p>" + DailyNews.ChannelName + "</p></div> <p class='title'>" + DailyNews.NewsHeading + " </p> <p>" + DailyNews.NewsContent + " </p></div></div>";
                                    Div.append(popup)
                                    //Div.append('<div class="media-card media-pop" data-video="https://inoxwind.com/uploads/video/Devansh%20Jain%20-%20IWL%20-CNBC%20AWAAZ%20-%2001.09.15.mp4"><img src="http://localhost:53378/WebsiteImages/report2_638657831116250064.jpg" alt="" style="height:157px;width:286px" /><div class="content-side"><div class="tag"> <p>NDTV PRIME</p></div> <p class="title">Sector seeing investments, eyeing 1500MW orders: Inox Wind </p> <p>NDTV PRIME </p></div></div>');
                                }
                                else {
                                    Div.append('<div class="media-card"><a href=' + NewsLink + ' target="_blank" class="video-ext"> <img src=' + NewsImage + ' alt="" style="height:157px;width:286px"  /> <div class="content-side">  <div class="tag">  <p>' + DailyNews.ChannelName + '</p></div> <p class="title">' + DailyNews.NewsHeading + ' </p> <p>' + DailyNews.NewsContent + ' </p> </div> </a> </div >')
                                }

                            });

                            $('#hdLoadMoreDailyNews').val(DailyNews[DailyNews.length - 1].Id);
                        }
                    },
                    error: function (error) {
                        console.error(error);
                    }
                });
            }

            function ThirdTabloadMoreData() {
                var lastID = $('#hdThirdabLastLoadedID').val();
                $.ajax({
                    type: "POST",
                    url: "/WebService.asmx/GetNews",
                    data: JSON.stringify({ Id: lastID, NewsType: "Notice to Shareholders" }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {

                        if (response.d) {
                            var NewsRoom = response.d;
                            var tableBody = $('#data-table-ThirdTab tbody');
                            $.each(NewsRoom, function (index, NewsRoom) {
                                debugger;
                                var href = window.location.origin + NewsRoom.NewsDoc;
                                href = "'" + href + "'";
                                tableBody.append('<tr onclick="window.open(' + href + ')"><td><i class="bi bi-file-earmark-text" style="font-size:18px; color:#0154A4"></i>' + NewsRoom.ParticularsORNewspaper + '</td><td><i class="bi bi-calendar4"  style="font-size:16px; color:#0154A4"></i>' + NewsRoom.NewsDATE + '</td></tr>');
                            });

                            $('#hdThirdabLastLoadedID').val(NewsRoom[NewsRoom.length - 1].Id);
                        }
                    },
                    error: function (error) {
                        console.error(error);
                    }
                });
            }
            function SecondTabloadMoreData() {
                var lastID = $('#hdSecabLastLoadedID').val();
                $.ajax({
                    type: "POST",
                    url: "/WebService.asmx/GetNews",
                    data: JSON.stringify({ Id: lastID, NewsType: "Financials Results" }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        if (response.d) {
                            var NewsRoom = response.d;
                            var tableBody = $('#data-table-SecondTab tbody');
                            $.each(NewsRoom, function (index, NewsRoom) {

                                debugger;
                                var href = window.location.origin + NewsRoom.NewsDoc;
                                href = "'" + href + "'";
                                tableBody.append('<tr onclick="window.open(' + href + ')"><td><i class="bi bi-file-earmark-text" style="font-size:18px; color:#0154A4"></i>' + NewsRoom.ParticularsORNewspaper + '</td><td><i class="bi bi-calendar4"  style="font-size:16px; color:#0154A4"></i>' + NewsRoom.NewsDATE + '</td></tr>');
                            });

                            $('#hdSecabLastLoadedID').val(NewsRoom[NewsRoom.length - 1].Id);
                        }
                    },
                    error: function (error) {
                        console.error(error);
                    }
                });
            }
            function FirstTabloadMoreData() {
                var lastID = $('#hdFtabLastLoadedID').val();
                $.ajax({
                    type: "POST",
                    url: "/WebService.asmx/GetNews",
                    data: JSON.stringify({ Id: lastID, NewsType: "Notice of Board Meeting" }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        if (response.d) {
                            var NewsRoom = response.d;
                            var tableBody = $('#data-table-firstTab tbody');
                            $.each(NewsRoom, function (index, NewsRoom) {
                                debugger;
                                var href = window.location.origin + NewsRoom.NewsDoc;
                                href = "'" + href + "'";
                                tableBody.append('<tr onclick="window.open(' + href + ')"><td><i class="bi bi-file-earmark-text" style="font-size:18px; color:#0154A4"></i>' + NewsRoom.ParticularsORNewspaper + '</td><td><i class="bi bi-calendar4"  style="font-size:16px; color:#0154A4"></i>' + NewsRoom.NewsDATE + '</td></tr>');
                            });

                            $('#hdFtabLastLoadedID').val(NewsRoom[NewsRoom.length - 1].Id);
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
