<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="marka.aspx.cs" Inherits="Aksan2.jeweler_master.marka" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="dual-list-box-area mg-tb-15">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="sparkline10-list shadow-reset">
                        <div class="sparkline10-hd">
                            <div class="main-sparkline10-hd">
                                <h1>markalar</h1>
                                <h1>
                                    <asp:Literal ID="ltr_is_baslik" runat="server"></asp:Literal> </h1>
                                <asp:Repeater ID="rptr_resim" runat="server">

                                    <ItemTemplate> 
                                        <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                        <div class="single-new-trend mg-t-30">
                            <a href="#"> <asp:Image ID="is_resimler" ImageUrl='<%#Eval("MarkaResim")%>' runat="server" /></a>
                            <div class="overlay-content">
                                
                                <a href="#" class="btn-small">markalar</a>
                                <div class="product-action">
                                    <ul>
                                        <li>
                                            <a data-toggle="tooltip" title="sil" href='marka.aspx?MarkaId=<%#Eval("MarkaId") %>&islem=sil'><i class="fa fa-close" aria-hidden="true"></i></a>
                                        </li>
                                         
                                    </ul>
                                </div>
                                
                                 
                            </div>
                        </div>
                    </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                 
                            </div>
                        </div>
       <%--                 <div class="sparkline10-graph">
                            <div class="basic-login-form-ad">
                                <div class="row">
                                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                        <div class="dual-list-box-inner">
                                            <div class="row">
                                                <div class="col-md-6 col-md-6 col-sm-6 col-xs-12">
                                                    <div class="image-crop">
                                                        <img  id="resim" alt="Seçtiğiniz resim burada görünecek " />
                                                    </div>
                                                </div>
                                                <div class="col-md-6 col-md-6 col-sm-6 col-xs-12">
                                                    <div class="preview-img-pro-ad">
                                                        <h4>
                                                            <asp:Literal ID="ltr_baslik" runat="server"></asp:Literal></h4>
                                                        <div></div>

 

                                                        <asp:FileUpload ID="FUP_RESIM" ClientIDMode="Static" onchange="$('#resim')[0].src = window.URL.createObjectURL(this.files[0])" CssClass="form-control" runat="server" Width="100%" Height="35px" />

                                                     
                                                        <asp:Button ID="btn_kaydet" class="btn btn-warning waves-effect waves-light" runat="server" Text="Ekle" OnClick="btn_kaydet_Click" />
                                                        
                                                        <asp:Button ID="btn_iptal"  class="btn btn-warning waves-effect waves-light" runat="server" Text="İptal" OnClick="btn_iptal_Click" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
