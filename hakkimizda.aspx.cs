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
    public partial class hakkimizda2 : System.Web.UI.Page
    {

        Baglan baganti = new Baglan();
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }

            if (Page.IsPostBack == false) { SqlCommand cmdhg = new SqlCommand("select * from Hakkimizda ", baganti.baglan());
            SqlDataReader readerh = cmdhg.ExecuteReader();
            if (readerh.Read())
            {
                ltr_hakkimizda.Text = readerh["HakkimizdaMetin"].ToString();
                ck_hakimda.Text= readerh["HakkimizdaMetin"].ToString();
            
               
            }
            else {
                btn_guncelle.Visible = false;
          
                ltr_hakkimizda.Text = "Metin eklenmedi";

            }}

            
            
        }
 

       

        protected void btn_guncelle_Click1(object sender, EventArgs e)
        {
            SqlCommand cmdhu = new SqlCommand("Update Hakkimizda set HakkimizdaMetin =@p1",baganti.baglan());
            cmdhu.Parameters.AddWithValue("@p1",ck_hakimda.Text);
            cmdhu.ExecuteNonQuery();
            Response.Redirect("hakkimizda.aspx");

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("insert into Hakkimizda ( HakkimizdaMetin ) values ( '" + ck_hakimda.Text + "')", baganti.baglan());
            cmdEkle.ExecuteNonQuery();

            Response.Redirect("hakkimizda.aspx");
        }
    }
}