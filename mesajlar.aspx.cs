using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace Aksan2.jeweler_master
{
    public partial class mesajlar1 : System.Web.UI.Page
    {

        Baglan baganti = new Baglan();
        String MesajId = "";
        String islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }

            MesajId = Request.QueryString["MesajId"];
            islem = Request.QueryString["islem"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmdhg = new SqlCommand("select   * from Mesajlar  ", baganti.baglan());

                SqlDataReader readerh = cmdhg.ExecuteReader();
                rpt_mesaj.DataSource = readerh;
                rpt_mesaj.DataBind();
            }
            if (islem == "sil")
            {
                SqlCommand cmdhs = new SqlCommand("delete from Mesajlar where  MesajId = '" + MesajId + "'", baganti.baglan());
                cmdhs.ExecuteNonQuery();

                Response.Redirect("mesajlar.aspx");

            }

        }
    }
}