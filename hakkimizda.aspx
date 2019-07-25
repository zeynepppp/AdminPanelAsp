<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="hakkimizda.aspx.cs" Inherits="Aksan2.jeweler_master.hakkimizda2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="product-status mg-tb-15">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                        <div class="product-status-wrap">
                            <h4>Hakkımızda metni</h4>
                            
                            <table>
                                
                                <tr> 
                                    <td> <asp:Literal ID="ltr_hakkimizda" runat="server"></asp:Literal></td>
                                  
                                    <td>
                                       <%-- <button data-toggle="tooltip" title="ekle" class="pd-setting-ed"><i class="fa fa-pencil-square-o" aria-hidden="true"></i></button>
                                        <button data-toggle="tooltip" title="düzenle" class="pd-setting-ed"><i class="fa fa-trash-o" aria-hidden="true"></i></button>
                                       --%> 
                            <%--            <asp:Button ID="btn_ekle" class="pd-setting-ed  fa fa-pencil-square-o " aria-hidden="true" runat="server" Text="ekle" />--%>
                                     <%--   <asp:Button ID="btn_duzenle" class="pd-setting-ed fa fa-trash-o " aria-hidden="true" runat="server" Text="düzenle"  />--%>
                                    </td>
                                </tr>
                                 
                              
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
                                    <li class="active"><a href="#description"><i class="fa fa-pencil" aria-hidden="true"></i> Hakkımızda</a></li>
                                 
                                </ul>
                                <div id="myTabContent" class="tab-content custom-product-edit">
                                    <div class="product-tab-list tab-pane fade active in" id="description">
                                        <div class="row">
                                           <%-- <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">--%>
                                            <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                                                <div class="review-content-section">
                                                   
                                                  
                                                    <div class="input-group mg-b-pro-edt">
                                                        <span class="input-group-addon"><i class="fa fa-pencil" aria-hidden="true"></i></span>
                                                        <%--<input type="text" class="form-control" placeholder="Product Title">--%>
                                                         <CKEditor:CKEditorControl ID="ck_hakimda" runat="server">Hakkımızda metini ekleyin..</CKEditor:CKEditorControl>  
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
                                                    <asp:Button ID="btn_guncelle" class="btn btn-warning waves-effect waves-light" runat="server" Text="Güncelle" OnClick="btn_guncelle_Click1" />
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
