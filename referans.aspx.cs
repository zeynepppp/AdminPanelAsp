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
    public partial class referans : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();
        String ReferansId = "";
        String islem;

        protected void Page_Load(object sender, EventArgs e)
        {
            ReferansId = Request.QueryString["ReferansId"];
            islem = Request.QueryString["islem"];

            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }


            if (Page.IsPostBack == false)
            {
                SqlCommand cmdhg = new SqlCommand("select * from Referanslar ", baglanti.baglan());
                SqlDataReader readerh = cmdhg.ExecuteReader();

                rpt_ref.DataSource = readerh;
                rpt_ref.DataBind();

                if (islem == "sil")
                {
                    SqlCommand cmdhs = new SqlCommand("delete from Referanslar where  ReferansId = '" + ReferansId + "'", baglanti.baglan());
                    cmdhs.ExecuteNonQuery();

                    Response.Redirect("referans.aspx");

                }


                //if (readerh.Read())
                //{
                //    ltr_ref_baslik.Text = readerh["ReferansBaslik"].ToString();
                //    ltr_tel_metin.Text = readerh["ReferansMetin"].ToString();

                //    btn_kaydet.Visible = false;

                //}
                //else
                //{


                //    ltr_ref_baslik.Text = "Metin eklenmedi";
                //    ltr_tel_metin.Text = "Metin eklenmedi";

                //}
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
             
                SqlCommand cmdEkle = new SqlCommand("insert into Referanslar (ReferansBaslik,ReferansMetin) values ('" + txt_baslik.Text + "','" + txt_ozet.Text + "')", baglanti.baglan());
                cmdEkle.ExecuteNonQuery();

                Response.Redirect("referans.aspx");
            
           

        }
    }
}