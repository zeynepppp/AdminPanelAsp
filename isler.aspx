<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="isler.aspx.cs" Inherits="Aksan2.jeweler_master.portfolio1" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="blog-area mg-tb-15">
        <div class="container-fluid">
            <div class="row">

                <div class="row">

                    <asp:Repeater ID="rpt_isler" runat="server">

                        <ItemTemplate>

                            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                <div class="hpanel blog-box mg-t-30">

                                    <div class="panel-body blog-pra">
                                        <div class="blog-img">
                                            <img src="<%# Eval("isResim") %>" alt="" />
                                            <a href='isduzenle.aspx?isId=<%#Eval("isId")%>'>
                                                <h4><%# Eval("isBaslik") %></h4>
                                            </a>
                                        </div>
                                        <p><%# Eval("isOzet") %></p>
                                     <%--   <asp:Button ID="btn_resim_ekle" class="btn btn-primary waves-effect waves-light m-r-10" runat="server" Text="dah çok resim ekle" />--%>
                                    
                                    <a href='isresim.aspx?isId=<%#Eval("isId")%>' style="color:red">Daha çok resim ekle..</a>
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
