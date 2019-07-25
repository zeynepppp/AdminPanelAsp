<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="Aksan2.jeweler_master.blog2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="blog-area mg-tb-15">
            <div class="container-fluid">
                <div class="row">
            
                <div class="row">
           
                    <asp:Repeater ID="rpt_blog" runat="server">

                        <ItemTemplate>

<div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                        <div class="hpanel blog-box mg-t-30">
                         
                            <div class="panel-body blog-pra">
                                <div class="blog-img">
                                    <img src="<%# Eval("BlogResim") %>" alt="" />
                                    <a href='blogduzenle.aspx?BlogId=<%#Eval("BlogId")%>'>
                                        <h4><%# Eval("BlogBaslik") %></h4>
                                    </a>
                                </div>
                                <p> <%# Eval("BlogOzet") %></p>
                            </div>
                            <div class="panel-footer">
                                <span class="pull-right"><i class="fa fa-comments-o"> </i> 22 comments</span>
                                <i class="fa fa-eye"> </i> 142 views
                            </div>
                        </div>
                    </div>

                        </ItemTemplate>

                    </asp:Repeater>
                    

                </div>
            </div>
        </div>
        </div>


</asp:Content>
