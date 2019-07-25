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
    public partial class iletisim2 : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }


            if (Page.IsPostBack == false)
            {
                SqlCommand cmdhg = new SqlCommand("select * from iletisim ", baglanti.baglan());
                SqlDataReader readerh = cmdhg.ExecuteReader();
                if (readerh.Read())
                {
                    ltr_tel_cep.Text = readerh["iletisimTelCep"].ToString();
                    ltr_tel_is.Text = readerh["iletisimTel"].ToString();
                    ltr_mail.Text = readerh["iletisimMail"].ToString();
                    ltr_face.Text = readerh["iletisimFacebook"].ToString();
                    ltr_insta.Text = readerh["iletisimInstagram"].ToString();
                    ltr_adres.Text = readerh["iletisimAdres"].ToString();
                    txt_Adres.Text = readerh["iletisimAdres"].ToString();
                    txt_instagram.Text = readerh["iletisimInstagram"].ToString();
                    txt_facebook.Text = readerh["iletisimFacebook"].ToString();
                    txt_mail.Text = readerh["iletisimMail"].ToString();
                    txt_tel_is.Text = readerh["iletisimTel"].ToString();
                   txt_tel_cep.Text= readerh["iletisimTelCep"].ToString();
                    btn_kaydet.Visible = false;

                }
                else
                {
                    btn_guncelle.Visible = false;

                   ltr_adres.Text = "Metin eklenmedi";
                    ltr_face.Text = "Metin eklenmedi";
                    ltr_mail.Text = "Metin eklenmedi";
                    ltr_insta.Text = "Metin eklenmedi";
                    ltr_tel_cep.Text = "Metin eklenmedi";
                    ltr_tel_is.Text = "Metin eklenmedi";
                }
            }


        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdEkle = new SqlCommand("insert into iletisim (iletisimTelCep,iletisimTel,iletisimMail,iletisimFacebook,iletisimInstagram,iletisimAdres) values ('" + txt_tel_cep.Text + "','" + txt_tel_is.Text + "','" + txt_mail.Text + "' ,'" +txt_facebook.Text+ "','" + txt_instagram.Text + "','" + txt_Adres.Text + "')", baglanti.baglan());
            cmdEkle.ExecuteNonQuery();

            Response.Redirect("iletisim.aspx");

        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {

            SqlCommand cmdhu = new SqlCommand("Update iletisim set iletisimTelCep =@p1, iletisimTel=@p2,iletisimMail=@p3,iletisimFacebook=@p4,iletisimInstagram=@p5,iletisimAdres=@p6 ", baglanti.baglan());
            cmdhu.Parameters.AddWithValue("@p1", txt_tel_cep.Text);
            cmdhu.Parameters.AddWithValue("@p2", txt_tel_is.Text);
            cmdhu.Parameters.AddWithValue("@p3", txt_mail.Text);
            cmdhu.Parameters.AddWithValue("@p4", txt_facebook.Text);
            cmdhu.Parameters.AddWithValue("@p5", txt_instagram.Text);
            cmdhu.Parameters.AddWithValue("@p6", txt_Adres.Text);
            cmdhu.ExecuteNonQuery();
            Response.Redirect("iletisim.aspx");

        }
    }
}