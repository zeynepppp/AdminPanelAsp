﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="giris.aspx.cs" Inherits="Aksan2.jeweler_master.giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8"/>
    <meta http-equiv="x-ua-compatible" content="ie=edge"/>
    <title>Giris| Admin Panel</title>
    <meta name="description" content=""/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- favicon
		============================================ -->
    <link rel="shortcut icon" type="image/x-icon" href="img/favicon.ico"/>
    <!-- Google Fonts
		============================================ -->
    <link href="https://fonts.googleapis.com/css?family=Play:400,700" rel="stylesheet"/>
    <!-- Bootstrap CSS
		============================================ -->
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <!-- Bootstrap CSS
		============================================ -->
    <link rel="stylesheet" href="css/font-awesome.min.css"/>
    <!-- owl.carousel CSS
		============================================ -->
    <link rel="stylesheet" href="css/owl.carousel.css"/>
    <link rel="stylesheet" href="css/owl.theme.css"/>
    <link rel="stylesheet" href="css/owl.transitions.css"/>
    <!-- animate CSS
		============================================ -->
    <link rel="stylesheet" href="css/animate.css"/>
    <!-- normalize CSS
		============================================ -->
    <link rel="stylesheet" href="css/normalize.css"/>
    <!-- main CSS
		============================================ -->
    <link rel="stylesheet" href="css/main.css"/>
    <!-- morrisjs CSS
		============================================ -->
    <link rel="stylesheet" href="css/morrisjs/morris.css"/>
    <!-- mCustomScrollbar CSS
		============================================ -->
    <link rel="stylesheet" href="css/scrollbar/jquery.mCustomScrollbar.min.css"/>
    <!-- metisMenu CSS
		============================================ -->
    <link rel="stylesheet" href="css/metisMenu/metisMenu.min.css"/>
    <link rel="stylesheet" href="css/metisMenu/metisMenu-vertical.css"/>
    <!-- calendar CSS
		============================================ -->
    <link rel="stylesheet" href="css/calendar/fullcalendar.min.css"/>
    <link rel="stylesheet" href="css/calendar/fullcalendar.print.min.css"/>
    <!-- forms CSS
		============================================ -->
    <link rel="stylesheet" href="css/form/all-type-forms.css"/>
    <!-- style CSS
		============================================ -->
    <link rel="stylesheet" href="style.css"/>
    <!-- responsive CSS
		============================================ -->
    <link rel="stylesheet" href="css/responsive.css"/>
    <!-- modernizr JS
		============================================ -->
    <script src="js/vendor/modernizr-2.8.3.min.js"></script>
 
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="color-line"></div>
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12"></div>
            <div class="col-md-4 col-md-4 col-sm-4 col-xs-12">
                <div class="text-center m-b-md custom-login">
                    <h3>
                        <asp:Literal ID="ltr_giris" runat="server"></asp:Literal></h3>
                     
                </div>
                <div class="hpanel">
                    <div class="panel-body">
                        <div   id="loginForm">
                            <div class="form-group">
                                <label class="control-label" for="username">Kullanıcı Adı</label>
                              <%--  <input type="text" placeholder="example@gmail.com" title="Please enter you username" required="" value="" name="username" id="username" class="form-control">--%>
                                <asp:TextBox ID="txt_kullaniciadi" class="form-control" placeholder="example@gmail.com" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label class="control-label" for="password">Şifre</label>
                              <%--  <input type="password" title="Please enter your password" placeholder="******" required="" value="" name="password" id="password" class="form-control">--%>
                                   <asp:TextBox ID="txt_sifre" type="password" class="form-control" placeholder="sifre" runat="server"></asp:TextBox>
                            </div>
                          
                          <%--  <button class="btn btn-success btn-block loginbtn">Giriş</button>--%>
                            <asp:Button ID="btn_giris" class="btn btn-success btn-block loginbtn" runat="server" Text="Giriş" OnClick="btn_giris_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12"></div>
        </div>
        <div class="row">
            <div class="col-md-12 col-md-12 col-sm-12 col-xs-12 text-center">
                <p>Copyright &copy; 2019 <a href="#"></a>Tüm hakları saklıdır.</p>
            </div>
        </div>
    </div>
        </div>
    </form>
</body>
       <script src="js/vendor/jquery-1.11.3.min.js"></script>
    <!-- bootstrap JS
		============================================ -->
    <script src="js/bootstrap.min.js"></script>
    <!-- wow JS
		============================================ -->
    <script src="js/wow.min.js"></script>
    <!-- price-slider JS
		============================================ -->
    <script src="js/jquery-price-slider.js"></script>
    <!-- meanmenu JS
		============================================ -->
    <script src="js/jquery.meanmenu.js"></script>
    <!-- owl.carousel JS
		============================================ -->
    <script src="js/owl.carousel.min.js"></script>
    <!-- sticky JS
		============================================ -->
    <script src="js/jquery.sticky.js"></script>
    <!-- scrollUp JS
		============================================ -->
    <script src="js/jquery.scrollUp.min.js"></script>
    <!-- mCustomScrollbar JS
		============================================ -->
    <script src="js/scrollbar/jquery.mCustomScrollbar.concat.min.js"></script>
    <script src="js/scrollbar/mCustomScrollbar-active.js"></script>
    <!-- metisMenu JS
		============================================ -->
    <script src="js/metisMenu/metisMenu.min.js"></script>
    <script src="js/metisMenu/metisMenu-active.js"></script>
    <!-- tab JS
		============================================ -->
    <script src="js/tab.js"></script>
    <!-- icheck JS
		============================================ -->
    <script src="js/icheck/icheck.min.js"></script>
    <script src="js/icheck/icheck-active.js"></script>
    <!-- plugins JS
		============================================ -->
    <script src="js/plugins.js"></script>
    <!-- main JS
		============================================ -->
    <script src="js/main.js"></script>
</html>
