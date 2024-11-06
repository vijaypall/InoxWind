<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="newspaper-advertisements.aspx.cs" Inherits="InoxWind.newspaper_advertisements" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="inner-banner">
        <img src="./assets/images/investors-banner.jpg" alt="" />
    </section>
    <section class="investor-content-page">
        <div class="mcontainer">
            <div class="w90 margin-center">
                <nav class="breadcrumbs mcontainer">
                    <ul>
                        <li>
                            <a href="Default.aspx" title="Home">Home</a>
                        </li>
                        /
                        <li>
                            <a href="investors.aspx" title="Investors">Investors</a>
                        </li>
                        /
                        <li>
                            <p>Newspaper Advertisements</p>
                        </li>
                    </ul>
                </nav>
                <div class="page-content mcontainer">
                    <div class="mcontainer common-headings detail-content">
                        <p class="main-title"><span>Notice of Board Meeting</span></p>
                    </div>
                    <div class="content-table">
                        <table>
                            <tbody>
                                <tr>
                                    <th>
                                        Newspaper
                                    </th>
                                    <th>
                                        Date
                                    </th>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                                <tr onclick="window.open('https://inoxwind.com/uploads/2021/02/FE-D_5-Feb-2021_p12_IWL_Notice-BM_Q3FY21.pdf')">
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" viewBox="0 0 16 18" fill="none">
                                            <path d="M10.0016 1H3.20156C2.77722 1 2.37025 1.16857 2.07019 1.46863C1.77013 1.76869 1.60156 2.17565 1.60156 2.6V15.4C1.60156 15.8243 1.77013 16.2313 2.07019 16.5314C2.37025 16.8314 2.77722 17 3.20156 17H12.8016C13.2259 17 13.6329 16.8314 13.9329 16.5314C14.233 16.2313 14.4016 15.8243 14.4016 15.4V5.4L10.0016 1Z" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M9.60156 1V5.8H14.4016" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 9.80005H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M11.2008 13H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                            <path d="M6.40078 6.6001H4.80078" stroke="#0154A4" stroke-width="1.4" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>    
                                        Financial Express
                                    </td>
                                    <td>
                                        <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24" fill="none">
                                            <path d="M8.88889 4V7.2M15.1111 4V7.2M5 10.4H19M6.55556 5.6H17.4444C18.3036 5.6 19 6.31634 19 7.2V18.4C19 19.2837 18.3036 20 17.4444 20H6.55556C5.69645 20 5 19.2837 5 18.4V7.2C5 6.31634 5.69645 5.6 6.55556 5.6Z" stroke="#0154A4" stroke-width="1.2" stroke-linecap="round" stroke-linejoin="round"/>
                                        </svg>
                                        12/06/2024
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                        <div class="loadbuttons mcontainer">
                            <button class="main-button">
                                <span>Load More</span>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
