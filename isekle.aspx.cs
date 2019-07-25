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
    public partial class isekle : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {


            //if (fu_resim.HasFile) //Burada resim yüklenip yüklenmediğini kontrol ediyoruz.
            //{
            //    for (int i = 0; i < fu_resim.PostedFiles.Count; i++) //Burada yüklenen resim sayısını alıp döngüyle tek tek yükletiyoruz.
            //    {
            //        if (fu_resim.PostedFile.ContentType == "image/jpeg" || fu_resim.PostedFile.ContentType == "image/jpg" || fu_resim.PostedFile.ContentType == "image/png") //Burada yüklenen dosyaların resim türünde olup olmadığını kontrol ediyoruz.
            //        {
            //            if (fu_resim.PostedFile.ContentLength < 5048000) //Burada yüklenen resimlerin boyutlarını kontrol ediyoruz. 5MB'dan düşük boyutları kabul ediyoruz.
            //            {
            //               fu_resim.PostedFiles[i].SaveAs(Server.MapPath("~/resimler/")+DateTime.+fu_resim.PostedFiles[i].FileName); //Yüklenmek istediğimiz resimleri nereye yüklediğimizi belirtiyoruz.

            //                //Eğer isterseniz buranın altına veritabanı ekleme sorgusunu ekleyerek resimleri veritabanına yükleyebilirsiniz.
            //                SqlCommand cmdEkle = new SqlCommand("insert into isresim (isResim) values ('/resimler/" + fu_resim.PostedFiles[i].FileName + "')", baglanti.baglan());


            //            }
            //            else
            //            {
            //                ltr_resim.Text = "Yüklediğiniz resimlerin boyutu 5MB'dan fazla olmamalı!";
            //            }
            //        }
            //        else
            //        {
            //            ltr_resim.Text = "Sadece resim dosyaları yükleyebilirsiniz!";
            //        }
            //    }
            //}
            //else
            //{
            //    ltr_resim.Text = "Lütfen ilanınıza resim ekleyiniz!";
            //    //burada resim seçmediğinde hata verecek.
            //}





            if (fu_resim.HasFile)
            {

                //fu_is_resim1.SaveAs(Server.MapPath("/images/" + fu_is_resim1.FileName));
                fu_resim.SaveAs(Server.MapPath("/resimler/" + fu_resim.FileName));


                SqlCommand cmdEkle = new SqlCommand("insert into isler (isBaslik,isOzet,isMetin,isResim,isTarih) values ('" + txt_baslik.Text + "','" + txt_ozet.Text + "','" + txt_icerik.Text + "','/resimler/" + fu_resim.FileName + "','" + DateTime.Now + "')", baglanti.baglan());
                cmdEkle.ExecuteNonQuery();

                Response.Redirect("isler.aspx");
            }
            else
                ltr_resim.Text = "Resim ekleyiniz";


        }
    }
}