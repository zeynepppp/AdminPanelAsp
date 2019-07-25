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
    public partial class adminekle : System.Web.UI.Page
    {


        Baglan baglanti = new Baglan();
        String AdminId = "";
        String islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }

            AdminId = Request.QueryString["AdminId"];
            islem = Request.QueryString["islem"];



            if (Page.IsPostBack == false)
            {
                SqlCommand cmdhg = new SqlCommand("select * from Admin ", baglanti.baglan());
                SqlDataReader readerh = cmdhg.ExecuteReader();

                rpt_soru.DataSource = readerh;
                rpt_soru.DataBind();

            }
            if (islem == "sil")
            {
                SqlCommand cmdhs = new SqlCommand("delete from Admin where  AdminId = '" + AdminId + "'", baglanti.baglan());
                cmdhs.ExecuteNonQuery();

                Response.Redirect("adminekle.aspx");

            }


        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("insert into Admin( AdminKullaniciAdi,AdminSifre) values (  '" + txt_soru.Text + "','" + txt_cevap.Text + "')", baglanti.baglan());
            cmdEkle.ExecuteNonQuery();

            Response.Redirect("adminekle.aspx");
        }
    }
}