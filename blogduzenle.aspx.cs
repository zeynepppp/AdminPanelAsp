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
    public partial class blogduzenle : System.Web.UI.Page
    {
        Baglan baglanti = new Baglan();

        String BlogId="";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }
            BlogId = Request.QueryString["BlogId"];

         if (Page.IsPostBack == false) {


                SqlCommand cmdhr = new SqlCommand("select * from Blog  where BlogId='" +BlogId + "'",baglanti.baglan());
                SqlDataReader rcmdhr = cmdhr.ExecuteReader();

           
                DataTable dt = new DataTable("tablo");
                dt.Load(rcmdhr);
                DataRow dataRow = dt.Rows[0];
                txt_baslik.Text = dataRow["BlogBaslik"].ToString();
                ck_ozet.Text = dataRow["BlogOzet"].ToString();
                ck_icerik.Text = dataRow["BlogMetin"].ToString();

            }
                
          
            

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            //SqlCommand cmdiu = new SqlCommand("Update Blog set BlogBaslik=@p1, BlogOzet=@p2, BlogMetin=ck_icerik.Text,BlogResim='/resimler/" + fu_resim.FileName + "',BlogTarih='" + DateTime.Now + "' where BlogId='" + BlogId + "'", baglanti.baglan());
            SqlCommand cmdiu = new SqlCommand("Update Blog set BlogBaslik='" + txt_baslik.Text + "', BlogOzet='" + ck_ozet.Text + "', BlogMetin='" + ck_icerik.Text + "',BlogResim='/resimler/" + fu_resim.FileName + "',BlogTarih='" + DateTime.Now + "' where BlogId='" + BlogId + "'", baglanti.baglan());
            //cmdiu.Parameters.AddWithValue("p1", txt_baslik.Text);
            //cmdiu.Parameters.AddWithValue("p2", ck_ozet.Text);
            //cmdiu.Parameters.AddWithValue("p3", ck_icerik.Text);
            cmdiu.ExecuteNonQuery();
            
            //Response.Redirect("blogduzenle.aspx?BlogId='" + BlogId + "'");
            Response.Redirect("blog.aspx");
        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdhs = new SqlCommand("delete from Blog where  BlogId = '" + BlogId + "'",baglanti.baglan());
            cmdhs.ExecuteNonQuery();
            Response.Redirect("blog.aspx");
        }

        protected void btn_iptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("blog.aspx");
        }
    }
}