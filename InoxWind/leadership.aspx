<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="leadership.aspx.cs" Inherits="InoxWind.leadership" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="inner-banner">
        <img src="./assets/images/leadership.jpg" alt="" />
    </section>
    <section class="about-text manufacabout">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title">Our <span>Leadership</span></p>
                    <p>
                        Our leadership embodies these principles, guiding teams towards success through collaboration and innovation. With a commitment to excellence and a focus on inspiring others, we pave the way for transformative growth.
                    </p>
                </div>
            </div>
        </div>
    </section>
    <form runat="server">
        <section class="directors">
            <div class="mcontainer">
                <div class="w90 margin-center">
                    <div class="mcontainer common-headings">
                        <p class="main-title">Our <span>Directors</span></p>
                    </div>
                    <div class="mcontainer leaderlist" id="Divdirector" runat="server">
                         
                        <%-- <div class='col-lg-4 col-md-4 col-sm-12 leaderbox'><div class='leadercard linked-card' data-about
                        ="<p style="margin-bottom: 0px; padding: 0px; font-family: Avenir-mid; outline: none; font-size: 16px; color: rgb(86, 86, 86); 
line-height: 1.5;">Shri Brij Mohan Bansal is a B. Tech in Chemical Engineering and PG Diploma in Process Plant Engineering, both 
                            from the prestigious Indian Institute of Technology, Delhi.</p><p style="margin-bottom: 0px; padding: 0px;
font-family: Avenir-mid; outline: none; font-size: 16px; color: rgb(86, 86, 86); line-height: 1.5;">He has been a former Chairman of Indian
                                Oil Corporation Limited. He possesses more than four decades of experience in the oil and gas sector in areas 
                                of Business Development, R&amp;D, Refinery Operations, Project Execution and Technical Services.</p>
                        <p style="margin-bottom: 0px; padding: 0px; font-family: Avenir-mid; outline: none; font-size: 16px; 
color: rgb(86, 86, 86); line-height: 1.5;">He had spearheaded Indian Oil's green agenda by guiding initiatives in alternative energy
                            options such as wind and solar energy and also bio-fuels.</p><p style="margin-bottom: 0px; padding: 0px; 
font-family: Avenir-mid; outline: none; font-size: 16px; color: rgb(86, 86, 86); line-height: 1.5;">He has chaired many sessions
                                and presented several papers on refining, petrochemicals &amp; LNG in seminars/ conferences, both
                                in India and overseas. He has received many accolades from various professional bodies and organisations 
                                for his significant contribution to the field of oil and gas.</p><p style="margin-bottom: 0px;
padding: 0px; font-family: Avenir-mid; outline: none; font-size: 16px; color: rgb(86, 86, 86); line-height: 1.5;">He has also 
                                    been the Chairman of Chennai Petroleum Corporation Ltd., Indian Oil Mauritius Ltd. and IOT 
                                    Infrastructure &amp; Energy Services Ltd., a joint venture for building and operating terminalling 
                                    services for petroleum products.</p><p style="margin-bottom: 0px; padding: 0px; font-family: Avenir-mid;
outline: none; font-size: 16px; color: rgb(86, 86, 86); line-height: 1.5;">He headed Green Gas Limited, a JV of Indian Oil &amp;
                                        GAIL engaged in City Gas Distribution Business as its Chairman. He was elected as Chairman 
                                        Emeritus of Bio-Diesel Association of India, a body of organizations working in the field 
                                        of Bio-diesel. He was also elected as the first Chairman of India Di-Methyl Ether (DME) Chapter 
                                        of International DME Association (IDA), based out of USA. He has also served on the Boards 
                                        of various companies including Engineers India Limited, Bongaigaon Refinery
                                        &amp; Petrochemicals Limited, Petronet LNG Limited and JBF Industries Limited.
                                        Currently, he is on the Boards of various companies including Kothari Petrochemicals
                                        Limited and Asian Energy Services Limited.</p>">
                        
                        <img src = 'http://localhost:53378/WebsiteImages/brijmohansharma_638658994594795286.jpg' alt='' /><div class='leadercontent mcontainer'><div class='leadername-side'><p class='leadername'>Brij Mohan Bansal</p <p>Independent Director </p> </div> <div class='linked-img'><a href = 'https://www.linkedin.com/' title='' target='_blank'><img src ='./assets/images/linkedin.svg' alt='' /></a></div></div></div></div>--%>
                        <%--    <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card" 
                        data-about="11111">
                            <img src="./assets/images/lead2.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Brij Mohan Bansal
                                    </p>
                                    <p>
                                        Independent Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>--%>
                        <%-- <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card">
                            <img src="./assets/images/lead1.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Devansh Jain
                                    </p>
                                    <p>
                                        Whole-time Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card" 
                        data-about="<p>Shri Brij Mohan Bansal is a B. Tech in Chemical Engineering and PG Diploma in Process Plant Engineering, both from the prestigious Indian Institute of Technology, Delhi.</p><p>
                                He has been a former Chairman of Indian Oil Corporation Limited. He possesses more than four decades of experience in the oil and gas sector in areas of Business Development, R&D, Refinery Operations, Project Execution and Technical Services.
                            </p>
                            <p>
                                He had spearheaded Indian Oil's green agenda by guiding initiatives in alternative energy options such as wind and solar energy and also bio-fuels.
                            </p><p>
                                He has chaired many sessions and presented several papers on refining, petrochemicals & LNG in seminars/ conferences, both in India and overseas. He has received many accolades from various professional bodies and organisations for his significant contribution to the field of oil and gas.
                            </p><p>
                                He has also been the Chairman of Chennai Petroleum Corporation Ltd., Indian Oil Mauritius Ltd. and IOT Infrastructure & Energy Services Ltd., a joint venture for building and operating terminalling services for petroleum products.
                            </p>
                            <p>
                                He headed Green Gas Limited, a JV of Indian Oil & GAIL engaged in City Gas Distribution Business as its Chairman. He was elected as Chairman Emeritus of Bio-Diesel Association of India, a body of organizations working in the field of Bio-diesel. He was also elected as the first Chairman of India Di-Methyl Ether (DME) Chapter of International DME Association (IDA), based out of USA. He has also served on the Boards of various companies including Engineers India Limited, Bongaigaon Refinery & Petrochemicals Limited, Petronet LNG Limited and JBF Industries Limited. Currently, he is on the Boards of various companies including Kothari Petrochemicals Limited and Asian Energy Services Limited.
                            </p>">
                            <img src="./assets/images/lead2.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Brij Mohan Bansal
                                    </p>
                                    <p>
                                        Independent Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card">
                            <img src="./assets/images/lead3.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Bindu Saxena
                                    </p>
                                    <p>
                                        Independent Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card">
                            <img src="./assets/images/lead4.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Manoj Dixit
                                    </p>
                                    <p>
                                        Whole-time Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card">
                            <img src="./assets/images/lead5.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Mukesh Manglik
                                    </p>
                                    <p>
                                        Non-Executive Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12 leaderbox">
                        <div class="leadercard linked-card">
                            <img src="./assets/images/lead6.jpg" alt="" />
                            <div class="leadercontent mcontainer">
                                <div class="leadername-side">
                                    <p class="leadername">
                                        Sanjeev Jain
                                    </p>
                                    <p>
                                        Independent Director
                                    </p>
                                </div>
                                <div class="linked-img">
                                    <a href="https://www.linkedin.com/" title="" target="_blank">
                                        <img src="./assets/images/linkedin.svg" alt="" />
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>--%>
                    </div>
                </div>
            </div>
        </section>
        <section class="directors">
            <div class="mcontainer">
                <div class="w90 margin-center">
                    <div class="mcontainer common-headings">
                        <p class="main-title">Our <span>Leaders</span></p>
                    </div>
                    <div class="mcontainer leaderlist" id="DivPopulateLeader" runat="server">
                       <%-- <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead7.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Kailash Tarachandani
                                        </p>
                                        <p>
                                            Chief Executive Officer
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead8.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Rahul Roongta
                                        </p>
                                        <p>
                                            Chief Finance Officer
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead9.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. R. Narayan Kumar
                                        </p>
                                        <p>
                                            Chief Business Officer
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead10.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Nitesh Kumar
                                        </p>
                                        <p>
                                            Head – Projects
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead11.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Ajay Gupta
                                        </p>
                                        <p>
                                            Chief Supply Chain Officer
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead12.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Rajesh Kumar Goel
                                        </p>
                                        <p>
                                            Head – Manufacturing
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/lead13.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Goviind Vijay
                                        </p>
                                        <p>
                                            Head – Legal
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-4 col-sm-12 leaderbox">
                            <div class="leadercard linked-card">
                                <img src="./assets/images/default-lead.jpg" alt="" />
                                <div class="leadercontent mcontainer">
                                    <div class="leadername-side">
                                        <p class="leadername">
                                            Mr. Shailendra Tandon
                                        </p>
                                        <p>
                                            Sr. HR Business Partner
                                        </p>
                                    </div>
                                    <div class="linked-img">
                                        <a href="https://www.linkedin.com/" title="" target="_blank">
                                            <img src="./assets/images/linkedin.svg" alt="" />
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
        </section>
    </form>
    <div class="leaders-popup">
        <div class="popup-content">
            <div class="imageside leadercard">
                <div class="name-details">
                    <img src="./assets/images/lead2.jpg" alt="" class="pop-img" />
                    <div class="leadercontent mcontainer">
                        <div class="leadername-side">
                            <p class="leadername">
                                Brij Mohan Bansal
                            </p>
                            <p>
                                Independent Director
                            </p>
                        </div>
                        <div class="linked-img">
                            <a href="https://www.linkedin.com/" title="" target="_blank">
                                <img src="./assets/images/linkedin.svg" alt="" />
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="about-content">
            </div>
            <div class="close-popup">
                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                    <path d="M18 6L6 18M6 6L18 18" stroke="black" stroke-linecap="round" stroke-linejoin="round" />
                </svg>
            </div>
        </div>
    </div>
    <script>
        const closePop = document.querySelector('.close-popup');
        const leaderPop = document.querySelector('.leaders-popup');
        const imageSide = document.querySelector('.leaders-popup .imageside')
        const contentSide = document.querySelector('.leaders-popup .about-content')
        const leaderCard = document.querySelectorAll('.linked-card');
        closePop.addEventListener('click', function () {
            leaderPop.style.display = 'none'
        });
        leaderCard.forEach((card, index) => {
            card.addEventListener('click', function () {
                const about = card.dataset.about;
                const html = card.innerHTML;
                if (about != undefined && about != '') {
                    imageSide.innerHTML = html;
                    contentSide.innerHTML = about;
                    leaderPop.style.display = 'block'
                }
            })
        });
    </script>
</asp:Content>
