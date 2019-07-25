<%@ Page Title="" Language="C#" MasterPageFile="~/jeweler-master/Admin.Master" AutoEventWireup="true" CodeBehind="yorumlar.aspx.cs" Inherits="Aksan2.jeweler_master.yorumlar1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="data-table-area mg-tb-15">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12 col-md-12 col-sm-12 col-xs-12">
                    <div class="sparkline13-list">
                        <div class="sparkline13-hd">
                            <div class="main-sparkline13-hd">
                                <h1>Mesajlar</h1>
                            </div>
                        </div>
                        <div class="sparkline13-graph">
                            <div class="datatable-dashv1-list custom-datatable-overright">

                                <table id="table" data-toggle="table" data-pagination="true" data-search="true" data-show-columns="true" data-show-pagination-switch="true" data-show-refresh="true" data-key-events="true" data-show-toggle="true" data-resizable="true" data-cookie="true"
                                    data-cookie-id-table="saveId" data-show-export="true" data-click-to-select="true" data-toolbar="#toolbar">
                                    <thead>
                                      
                                                <tr>

                                                    <th data-field="id">Tarih</th>
                                                    <th data-field="name" data-editable="true">Ad</th>
                                                    <th data-field="company" data-editable="true">Mail</th>
                                                    <th data-field="price" data-editable="true">Metin</th>
                                                    <th>durum</th>
                                                      <th>islem</th>

                                                </tr>

                                      


                                    </thead>
                                    <tbody>
                                          <asp:Repeater ID="rpt_mesaj" runat="server">
                                            <ItemTemplate>
                                        <tr>
                                            <td><%#Eval("Tarih") %></td>
                                            <td><%#Eval("Ad") %></td>
                                            <td><%#Eval("Mail") %></td>
                                            <td><%#Eval("Metin") %></td>
                                                 <td><%#Eval("Durum") %></td>

                                            <td><a href="yorumlar.aspx?YorumId=<%#Eval("YorumId") %>&islem=sil">sil</a></td>

                                              <td><a href="yorumlar.aspx?YorumId=<%#Eval("YorumId") %>&islem=onayla">onayla</a></td>
                                        </tr>
                                              </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
