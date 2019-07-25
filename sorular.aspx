<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="sorular.aspx.cs" Inherits="Aksan2.jeweler_master.sorular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="product-status mg-tb-15">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="product-status-wrap">
                        <h4>Sık Sorulan Sorular</h4>

                        <table>

                            <asp:Repeater ID="rpt_soru" runat="server">

                                <ItemTemplate>
                                    <tr>

                                        <td><a href="sorular.aspx?SoruId=<%#Eval("SoruId") %>&islem=sil">Sil</a></td>
                                        <td><%#Eval("SoruId") %></td>
                                        <td><%#Eval("Soru") %></td>
                                        <td><%#Eval("Cevap") %></td>
                                 


                                    </tr>
                                </ItemTemplate>
                            </asp:Repeater>

                        </table>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="single-product-tab-area mg-tb-15">
        <!-- Single pro tab review Start-->
        <div class="single-pro-review-area">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="review-tab-pro-inner">
                            <ul id="myTab3" class="tab-review-design">
                                <li class="active"><a href="#description"><i class="fa fa-pencil" aria-hidden="true"></i>İletişim Bilgileri </a></li>

                            </ul>
                            <div id="myTabContent" class="tab-content custom-product-edit">
                                <div class="product-tab-list tab-pane fade active in" id="description">
                                    <div class="row">
                                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                                            <div class="review-content-section">
                                                <div class="input-group mg-b-pro-edt">
                                                    <span class="input-group-addon"><i class="fa fa-pencil" aria-hidden="true"></i></span>
                                                    <%--  <input type="text" class="form-control" placeholder="First Name">--%>
                                                    <asp:TextBox ID="txt_soru" class="form-control" placeholder="Soru" runat="server"></asp:TextBox>
                                                </div>
                                                <div class="input-group mg-b-pro-edt">
                                                    <span class="input-group-addon"><i class="fa fa-pencil" aria-hidden="true"></i></span>
                                                    <asp:TextBox ID="txt_cevap" class="form-control" placeholder="cevap" runat="server"></asp:TextBox>

                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <div class="row">
                                        <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                            <div class="text-center mg-b-pro-edt custom-pro-edt-ds">
                                                <%--  <button type="button" class="btn btn-primary waves-effect waves-light m-r-10">Save
														</button>--%>
                                                <asp:Button ID="btn_kaydet" class="btn btn-primary waves-effect waves-light m-r-10" runat="server" Text="Kaydet" OnClick="btn_kaydet_Click" />
                                                <%-- <button type="btn_guncelle" class="btn btn-warning waves-effect waves-light">Discard
														</button>--%>
                                                <%--    <asp:Button ID="btn_guncelle"  class="btn btn-warning waves-effect waves-light" runat="server" Text="Güncelle" OnClick="btn_guncelle_Click"   />--%>
                                            </div>
                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
