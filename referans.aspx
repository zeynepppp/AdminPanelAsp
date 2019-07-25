<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="referans.aspx.cs" Inherits="Aksan2.jeweler_master.referans" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="product-status mg-tb-15">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="product-status-wrap">
                            <h4>Referanslar</h4>
                            
                            <table>
                                   <asp:Repeater ID="rpt_ref" runat="server"><ItemTemplate>
                                <tr> 
                                 <%--   <td> <asp:Literal ID="ltr_ref_baslik" runat="server"></asp:Literal></td>
                                    <td> <asp:Literal ID="ltr_tel_metin" runat="server"></asp:Literal></td>--%>
                                 

                                                                                
                                    <td><%#Eval("ReferansBaslik") %></td>
                                    <td><%#Eval("ReferansMetin") %></td>
                                    <td><a href="referans.aspx?ReferansId=<%#Eval("ReferansId")%>&islem=sil">sil</a></td>

                           
                                </tr>    </ItemTemplate></asp:Repeater>
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
                                    <li class="active"><a href="#description"><i class="fa fa-pencil" aria-hidden="true"></i> Blog Ekle</a></li>
                                 
                                </ul>
                                <div id="myTabContent" class="tab-content custom-product-edit">
                                    <div class="product-tab-list tab-pane fade active in" id="description">
                                        <div class="row">
                                           <%-- <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">--%>
                                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                                <div class="review-content-section">
                                                    <div class="input-group mg-b-pro-edt">
                                                        <span class="input-group-addon"><i class="fa fa-pencil" aria-hidden="true"></i></span>

                                                        <%--<input type="text" class="form-control" placeholder="First Name">--%>
                                                        <asp:TextBox ID="txt_baslik"  class="form-control" placeholder="Başlık" runat="server"></asp:TextBox>

                                                    </div>
                                                     
                                                    <div class="input-group mg-b-pro-edt">
                                                        <span class="input-group-addon"><i class="fa fa-pencil" aria-hidden="true"></i></span>
                                                        <%--<input type="text" class="form-control" placeholder="Product Title">--%>
                                                         <CKEditor:CKEditorControl ID="txt_ozet" runat="server">Metin</CKEditor:CKEditorControl>  
                                                    </div>
                                                    
 
                                                </div>
                                            </div>
                                            
                                        </div>
                                        <div class="row">
                                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                                <div class="text-center mg-b-pro-edt custom-pro-edt-ds">
                                               <%--     <button type="button" class="btn btn-primary waves-effect waves-light m-r-10">Kaydet
														</button>--%>
                                                    <asp:Button ID="btn_kaydet" class="btn btn-primary waves-effect waves-light m-r-10" runat="server" Text="Kaydet" OnClick="btn_kaydet_Click" />
                                                   <%-- <button type="button" class="btn btn-warning waves-effect waves-light">Güncelle
														</button>--%>
                                                   <%-- <asp:Button ID="btn_guncelle" class="btn btn-warning waves-effect waves-light" runat="server" Text="Güncelle" />--%>
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
