using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Aksan2.jeweler_master
{
    public partial class isduzenle : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();

        String isId = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }

            isId = Request.QueryString["isId"];

            if (Page.IsPostBack == false)
            {


                SqlCommand cmdhr = new SqlCommand("select * from isler  where isId='" + isId + "'", baglanti.baglan());
                SqlDataReader rcmdhr = cmdhr.ExecuteReader();


                DataTable dt = new DataTable("tablo");
                dt.Load(rcmdhr);
                DataRow dataRow = dt.Rows[0];
                txt_baslik.Text = dataRow["isBaslik"].ToString();
                ck_ozet.Text = dataRow["isOzet"].ToString();
                ck_icerik.Text = dataRow["isMetin"].ToString();

            }




        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {


            //SqlCommand cmdiu = new SqlCommand("Update Blog set BlogBaslik=@p1, BlogOzet=@p2, BlogMetin=ck_icerik.Text,BlogResim='/resimler/" + fu_resim.FileName + "',BlogTarih='" + DateTime.Now + "' where BlogId='" + BlogId + "'", baglanti.baglan());
            SqlCommand cmdiu = new SqlCommand("Update isler set isBaslik='" + txt_baslik.Text + "', isOzet='" + ck_ozet.Text + "', isMetin='" + ck_icerik.Text + "',isResim='/resimler/" + fu_resim.FileName + "',isTarih='" + DateTime.Now + "' where isId='" + isId + "'", baglanti.baglan());
            //cmdiu.Parameters.AddWithValue("p1", txt_baslik.Text);
            //cmdiu.Parameters.AddWithValue("p2", ck_ozet.Text);
            //cmdiu.Parameters.AddWithValue("p3", ck_icerik.Text);
            cmdiu.ExecuteNonQuery();

            //Response.Redirect("blogduzenle.aspx?BlogId='" + BlogId + "'");
            Response.Redirect("isler.aspx");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdhs = new SqlCommand("delete from isler where  isId = '" + isId + "'", baglanti.baglan());
            cmdhs.ExecuteNonQuery();
            Response.Redirect("isler.aspx");

        }

        protected void btn_iptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("isler.aspx");
        }
    }
}