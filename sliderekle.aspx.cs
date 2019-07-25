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
    public partial class sliderekle : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();


        String SliderId = "";
        String islem;

        protected void Page_Load(object sender, EventArgs e)
        {
            SliderId = Request.QueryString["SliderId"];
            islem = Request.QueryString["islem"];

            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }


            if (Page.IsPostBack == false)
            {
                SqlCommand cmdhg = new SqlCommand("select * from Slider ", baglanti.baglan());
                SqlDataReader readerh = cmdhg.ExecuteReader();

                rpt_mrk.DataSource = readerh;
                rpt_mrk.DataBind();


                if (islem == "sil")
                {
                    SqlCommand cmdhs = new SqlCommand("delete from Slider  where  SliderId = '" + SliderId + "'", baglanti.baglan());
                    cmdhs.ExecuteNonQuery();

                    Response.Redirect("sliderekle.aspx");

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
                SqlCommand cmdEkle = new SqlCommand("insert into Slider (SliderBaslik,SliderResim ) values ('" + txt_baslik.Text + "' ,'/resimler/" + fu_resim.FileName + "' )", baglanti.baglan());
                cmdEkle.ExecuteNonQuery();

                Response.Redirect("sliderekle.aspx");
            }
            else
                ltr_resim.Text = "Resim ekleyiniz";
        }
    }
}