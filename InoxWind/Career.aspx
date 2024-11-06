<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Career.aspx.cs" Inherits="InoxWind.Career" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section class="inner-banner">
        <img src="./assets/images/career-banner.jpg" alt="" />
    </section>
    <section class="career-content">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings">
                    <p class="main-title">Life at <span>Inox</span></p>
                    <p>
                        At Inox, we take pride in offering our employees a unique opportunity to fulfil their aspirations while contributing to a higher purpose. We are committed to being at the forefront of shaping a greener, more sustainable future in the energy sector.
                    </p>
                </div>
                <div class="mcontainer career-contentbox">
                    <img src="./assets/images/career1.jpg" alt="" />
                    <div class="content">
                        <p>
                            Diversity and inclusion are fundamental values at Inox. We believe that a diverse workforce brings together a variety of perspectives, experiences, and ideas, leading to more innovative solutions and better decision-making. By championing diversity and inclusivity, we create a work environment that values honesty, fosters creativity, and drives excellence.
                        </p>
                        <p>
                            In line with our commitment to transparency and an open-door policy, we actively seek input from our employees and value their suggestions. Every voice matter, and we encourage an atmosphere where ideas are freely shared and implemented to the extent possible.
                        </p>
                    </div>
                </div>
                <div class="mcontainer career-contentbox">
                    <img src="./assets/images/career2.jpg" alt="" />
                    <div class="content">
                        <p>
                            Our dedication to employee development extends beyond technical skills. We invest substantially in training and skills development, empowering our employees to grow both personally and professionally. 
                        </p>
                        <p>
                            By providing a mix of challenging tasks and opportunities for advancement, we ensure that our team members are continuously motivated to achieve greater heights.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="openings">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <div class="mcontainer common-headings center-text centered-headings">
                    <p class="main-title"><span>Current Openings</span></p>
                    <p>
                        At Inox Wind, we recognize and reward talent. As you become a part of the Inox Wind family, your contributions will be valued, and your voice will be heard. 
                    </p>
                </div>
                <div class="mcontainer careersbox">
                    <form runat="server">
                        <div id="PoplateTable" runat="server"></div>
                    </form>
                    <%--<table>
                        <tbody>
                            <tr>
                                <th>
                                    Position Name
                                </th>
                                <th>
                                    Location
                                </th>
                                <th>
                                    Minimum Qualification
                                </th>
                                <th></th>
                            </tr>
                            <tr>
                                <td>
                                    Manager - Utilities And Energy
                                </td>
                                <td>
                                    Dahej - B, Gujarat
                                </td>
                                <td>
                                    B.E. Or B.Tech - Mechanical
                                </td>
                                <td>
                                    <a href="https://www.gfl.co.in/upload/job/ef5a4a745830a92cc65038de8d994820.pdf" title="" target="_blank">View Details</a>
                                    <a href="ApplyNow.aspx" title="" class="apply-btn">Apply Now</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Manager - Utilities And Energy
                                </td>
                                <td>
                                    Dahej - B, Gujarat
                                </td>
                                <td>
                                    B.E. Or B.Tech - Mechanical
                                </td>
                                <td>
                                    <a href="https://www.gfl.co.in/upload/job/ef5a4a745830a92cc65038de8d994820.pdf" title="" target="_blank">View Details</a>
                                    <a href="ApplyNow.aspx" title="" class="apply-btn">Apply Now</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Manager - Utilities And Energy
                                </td>
                                <td>
                                    Dahej - B, Gujarat
                                </td>
                                <td>
                                    B.E. Or B.Tech - Mechanical
                                </td>
                                <td>
                                    <a href="https://www.gfl.co.in/upload/job/ef5a4a745830a92cc65038de8d994820.pdf" title="" target="_blank">View Details</a>
                                    <a href="ApplyNow.aspx" title="" class="apply-btn">Apply Now</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Manager - Utilities And Energy
                                </td>
                                <td>
                                    Dahej - B, Gujarat
                                </td>
                                <td>
                                    B.E. Or B.Tech - Mechanical
                                </td>
                                <td>
                                    <a href="https://www.gfl.co.in/upload/job/ef5a4a745830a92cc65038de8d994820.pdf" title="" target="_blank">View Details</a>
                                    <a href="ApplyNow.aspx" title="" class="apply-btn">Apply Now</a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Manager - Utilities And Energy
                                </td>
                                <td>
                                    Dahej - B, Gujarat
                                </td>
                                <td>
                                    B.E. Or B.Tech - Mechanical
                                </td>
                                <td>
                                    <a href="https://www.gfl.co.in/upload/job/ef5a4a745830a92cc65038de8d994820.pdf" title="" target="_blank">View Details</a>
                                    <a href="ApplyNow.aspx" title="" class="apply-btn">Apply Now</a>
                                </td>
                            </tr>
                        </tbody>
                    </table>--%>
                    <div class="join-linkedin">
                        <a href="https://in.linkedin.com/company/inox-wind-limited" title="Linkedin" target="_blank">
                            Join us on:
                            <svg xmlns="http://www.w3.org/2000/svg" width="134" height="33" viewBox="0 0 134 33" fill="none">
                                <g clip-path="url(#clip0_2384_7861)">
                                  <path d="M130.849 28.5261C130.268 28.5318 129.713 28.7711 129.306 29.1917C128.898 29.6122 128.671 30.1798 128.674 30.7704C128.676 31.3609 128.909 31.9262 129.321 32.3428C129.732 32.7593 130.289 32.9932 130.87 32.9932C131.451 32.9932 132.008 32.7593 132.419 32.3428C132.831 31.9262 133.064 31.3609 133.066 30.7704C133.069 30.1798 132.842 29.6122 132.434 29.1917C132.027 28.7711 131.472 28.5318 130.891 28.5261H130.849ZM130.849 32.7375C130.468 32.7439 130.094 32.6354 129.774 32.4256C129.453 32.2157 129.202 31.9141 129.05 31.5587C128.898 31.2034 128.854 30.8103 128.922 30.4291C128.99 30.048 129.168 29.696 129.432 29.4175C129.697 29.1391 130.037 28.9468 130.41 28.8649C130.782 28.783 131.17 28.8152 131.524 28.9575C131.878 29.0998 132.183 29.3457 132.4 29.6641C132.617 29.9826 132.736 30.3593 132.743 30.7466V30.7794C132.753 31.2875 132.565 31.7791 132.219 32.1461C131.874 32.5131 131.399 32.7255 130.899 32.7365H130.849M122.417 27.9159H117.645V20.3153C117.645 18.5028 117.613 16.1697 115.162 16.1697C112.676 16.1697 112.296 18.1444 112.296 20.1833V27.9154H107.523V12.2854H112.105V14.4214H112.169C112.628 13.6242 113.29 12.9683 114.086 12.5237C114.883 12.0791 115.782 11.8624 116.69 11.8966C121.527 11.8966 122.419 15.1322 122.419 19.3416L122.417 27.9159ZM102.138 10.1489C101.59 10.149 101.055 9.98392 100.599 9.67452C100.143 9.36513 99.7884 8.92532 99.5787 8.41071C99.369 7.8961 99.314 7.32981 99.4208 6.78344C99.5276 6.23707 99.7913 5.73517 100.179 5.34121C100.566 4.94725 101.059 4.67891 101.597 4.57014C102.134 4.46136 102.691 4.51704 103.197 4.73012C103.703 4.9432 104.136 5.30412 104.44 5.76723C104.744 6.23035 104.907 6.77486 104.907 7.33191C104.907 7.70178 104.836 8.06804 104.696 8.40977C104.557 8.75151 104.353 9.06204 104.096 9.32362C103.839 9.5852 103.534 9.79272 103.198 9.93432C102.862 10.0759 102.502 10.1488 102.138 10.1489ZM104.524 27.9159H99.7465V12.2854H104.524V27.9159ZM124.797 0.00882262H97.3482C96.7252 0.00167327 96.1248 0.246334 95.6791 0.689041C95.2334 1.13175 94.9788 1.73628 94.9712 2.3698V30.3977C94.9786 31.0316 95.233 31.6365 95.6787 32.0797C96.1244 32.5229 96.7249 32.768 97.3482 32.7612H124.797C125.421 32.7692 126.023 32.5248 126.471 32.0816C126.918 31.6385 127.175 31.0328 127.183 30.3977V2.36778C127.174 1.733 126.918 1.12778 126.471 0.685087C126.023 0.24239 125.421 -0.00157157 124.797 0.00680037M81.9807 16.0579C79.5943 16.0579 78.1625 17.6783 78.1625 20.0392C78.1625 22.4002 79.5938 24.0221 81.9807 24.0221C84.3676 24.0221 85.8024 22.4043 85.8024 20.0392C85.8024 17.6742 84.3701 16.0579 81.9807 16.0579ZM90.1964 27.9068H85.8024V25.834H85.7373C85.1861 26.588 84.4711 27.2023 83.648 27.6292C82.825 28.0561 81.9162 28.284 80.9923 28.2951C76.4065 28.2951 73.3857 24.9296 73.3857 20.1702C73.3857 15.7991 76.0589 11.7854 80.4534 11.7854C82.4286 11.7854 84.2736 12.335 85.356 13.8582H85.4186V4.84858H90.1959L90.1964 27.9068ZM67.2576 18.2769C67.2667 17.8831 67.1971 17.4916 67.0531 17.1259C66.909 16.7603 66.6935 16.4283 66.4195 16.1499C66.1455 15.8714 65.8188 15.6525 65.4592 15.5062C65.0996 15.36 64.7145 15.2895 64.3273 15.2991C63.4933 15.2463 62.6724 15.5289 62.0415 16.0859C61.4106 16.643 61.0202 17.4298 60.9545 18.2769H67.2576ZM71.3005 25.2031C70.5074 26.1811 69.5103 26.9675 68.3815 27.5053C67.2527 28.0432 66.0203 28.319 64.7737 28.3128C60.0009 28.3128 56.1797 25.0731 56.1797 20.0564C56.1797 15.0397 60.0004 11.8016 64.7737 11.8016C69.2348 11.8016 72.0324 15.0372 72.0324 20.0564V21.5782H60.9545C61.0924 22.4412 61.5324 23.2245 62.1934 23.7837C62.8544 24.3429 63.6919 24.6403 64.5515 24.6212C65.2308 24.6169 65.8983 24.4399 66.4932 24.1063C67.0881 23.7727 67.5915 23.2931 67.9576 22.7111L71.3005 25.2031ZM23.8538 12.2814H28.4372V14.4174H28.5023C28.9601 13.6198 29.6224 12.9636 30.4183 12.519C31.2143 12.0743 32.1141 11.8578 33.0216 11.8926C37.8615 11.8926 38.7524 15.1307 38.7524 19.3375V27.9088H33.9796V20.3097C33.9796 18.4958 33.9468 16.1641 31.4938 16.1641C29.0129 16.1641 28.6301 18.1393 28.6301 20.1778V27.9068H23.8573L23.8538 12.2814ZM41.1727 4.8501H45.9455V18.6343L51.3547 12.2728H57.2063L50.942 19.5089L57.0746 27.9164H51.0757L46.0091 20.1904H45.9465V27.9154H41.1736L41.1727 4.8501ZM16.4346 12.2799H21.2074V27.9099H16.4346V12.2799ZM18.821 4.50935C19.3686 4.50945 19.9038 4.67466 20.3591 4.98409C20.8143 5.29352 21.1691 5.73327 21.3786 6.24774C21.5881 6.76221 21.6428 7.3283 21.5359 7.87441C21.4291 8.42053 21.1653 8.92215 20.7781 9.31586C20.3909 9.70956 19.8975 9.97766 19.3604 10.0863C18.8234 10.1948 18.2667 10.1391 17.7608 9.92595C17.2549 9.71284 16.8225 9.35197 16.5183 8.88898C16.2141 8.42598 16.0517 7.88166 16.0517 7.32483C16.0517 6.95505 16.1234 6.5889 16.2625 6.24728C16.4017 5.90565 16.6057 5.59525 16.8629 5.33381C17.12 5.07236 17.4253 4.86498 17.7613 4.72352C18.0972 4.58206 18.4573 4.50928 18.821 4.50935ZM0.0722656 4.85364H5.04047V23.2561H14.2381V27.9185H0.0722656V4.85364ZM131.197 30.9013C131.279 30.9021 131.36 30.8858 131.435 30.8535C131.511 30.8212 131.579 30.7734 131.635 30.7133C131.692 30.6531 131.735 30.5818 131.763 30.5038C131.792 30.4258 131.804 30.3427 131.799 30.2597C131.799 29.8047 131.529 29.5873 130.975 29.5873H130.08V31.9695H130.417V30.9311H130.83L130.84 30.9437L131.482 31.9695H131.842L131.151 30.9079L131.197 30.9013ZM130.808 30.6627H130.418V29.8573H130.912C131.168 29.8573 131.459 29.8998 131.459 30.24C131.459 30.6313 131.165 30.6627 130.806 30.6627" fill="white"/>
                                </g>
                                <defs>
                                  <clipPath id="clip0_2384_7861">
                                    <rect width="133" height="33" fill="white" transform="translate(0.0722656)"/>
                                  </clipPath>
                                </defs>
                            </svg>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </section>
   
</asp:Content>
