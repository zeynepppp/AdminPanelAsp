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
    public partial class slider : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();


        String SliderId = "";
        String islem;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }


            SliderId = Request.QueryString["SliderId"];
            islem = Request.QueryString["islem"];


            SqlCommand cmdpf = new SqlCommand("select * from Slider  ", baglanti.baglan());
            SqlDataReader readepf = cmdpf.ExecuteReader();
            rptr_resim.DataSource = readepf;
            rptr_resim.DataBind();

            if (islem == "sil")
            {
                SqlCommand cmdhs = new SqlCommand("delete from Slider where  SliderId = '" + SliderId + "'", baglanti.baglan());
                cmdhs.ExecuteNonQuery();

                Response.Redirect("slider.aspx");

            }


        }
    }
}