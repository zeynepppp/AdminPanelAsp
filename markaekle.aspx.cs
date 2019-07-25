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
    public partial class markalar : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();


        String MarkaId = "";
        String islem;
        protected void Page_Load(object sender, EventArgs e)
        {

            MarkaId = Request.QueryString["MarkaId"];
            islem = Request.QueryString["islem"];
             
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }


            if (Page.IsPostBack == false)
            {

                if (Session["AdminKullaniciAdi"] == null)
                {

                    Response.Redirect("giris.aspx");
                }

                SqlCommand cmdhg = new SqlCommand("select * from Markalar ", baglanti.baglan());
                SqlDataReader readerh = cmdhg.ExecuteReader();

                rpt_mrk.DataSource = readerh;
                rpt_mrk.DataBind();


                if (islem == "sil")
                {
                    SqlCommand cmdhs = new SqlCommand("delete from Markalar where  MarkaId = '" + MarkaId + "'", baglanti.baglan());
                    cmdhs.ExecuteNonQuery();

                    Response.Redirect("markaekle.aspx");

                }
            }

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (fu_resim.HasFile)
            {

                //fu_is_resim1.SaveAs(Server.MapPath("/images/" + fu_is_resim1.FileName));
                fu_resim.SaveAs(Server.MapPath("/resimler/" + fu_resim.FileName));

                // SqlCommand cmdEkle = new SqlCommand("insert into Portfolio (Title,Description,Image,Image2,Image3,Image4,Url,Company,Date) values ('" + txt_hakkimda_baslik.Text + "','" + ck_hakkimda_aciklama.Text + "','../images/" + fu_is_resim1.FileName + "','../images/" + FileUpload1.FileName + "','../images/" + FileUpload2.FileName + "','../images/" + FileUpload3.FileName + "','" + urltxt.Text + "','" + firmatxt.Text + "','" + DateTime.Now + "')", connect.baglan());
                SqlCommand cmdEkle = new SqlCommand("insert into Markalar (MarkaAd,MarkaResim ) values ('" + txt_baslik.Text + "' ,'/resimler/" + fu_resim.FileName + "' )", baglanti.baglan());
                cmdEkle.ExecuteNonQuery();

                Response.Redirect("markaekle.aspx");
            }
            else
                ltr_resim.Text = "Resim ekleyiniz";
        }

    }
    
}