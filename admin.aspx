<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Aksan2.jeweler_master.admin2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="traffic-analysis-area">
        <div class="container-fluid">
            <div class="row">
            </div>
        </div>
    </div>
    <div class="product-new-list-area">
        <div class="container-fluid">
            <div class="row">
                <asp:Repeater ID="rpt_1" runat="server">

                    <ItemTemplate>
                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                            <div class="single-new-trend mg-t-30">
                                <a href="#">
                                    <img src='<%#Eval("isResim") %>' alt=""></a>
                                <div class="overlay-content">
                                    <a href="isduzenle.aspx?isId=<%#Eval("isId") %>"></a>

                                    <a href="isduzenle.aspx?isId=<%#Eval("isId") %>">
                                        <h4><%#Eval("isBaslik") %></h4>
                                    </a>
                                </div>
                            </div>
                        </div>

                    </ItemTemplate>
                </asp:Repeater>
                  
            </div>
        </div>
    </div>
    <div class="product-sales-area mg-tb-30">
        <div class="container-fluid">
            <div class="row">

                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                </div>
            </div>
        </div>
    </div>
    <div class="author-area-pro">
        <div class="container-fluid">
            
                    <div class="row"><asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                        <div class="col-lg-4 col-md-4 col-sm-4 col-xs-12">


                            <div class="personal-info-wrap">
                                <div class="widget-head-info-box">
                                    <div class="persoanl-widget-hd">
                                        <a href="blogduzenle.aspx?blogId=<%#Eval("blogId") %>">
                                            <h2><%#Eval("BlogBaslik") %></h2>
                                        </a>

                                    </div>
                                    <img src="<%#Eval("BlogResim") %>" class="img-circle circle-border m-b-md" alt="profile">
                                </div>
                                <div class="widget-text-box">

                                    <p><%#Eval("BlogOzet") %></p>

                                </div>
                            </div>
                             
                        </div>
                </ItemTemplate>
            </asp:Repeater>
            
            
        </div>
    </div>
    </div>
       
    <div class="calender-area mg-tb-30">
        <div class="container-fluid">
            <div class="row">
            </div>
        </div>
    </div>

</asp:Content>
