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
    public partial class marka : System.Web.UI.Page
    {

        Baglan baglanti = new Baglan();


        String MarkaId = "";
        String islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }

            MarkaId = Request.QueryString["MarkaId"];
            islem = Request.QueryString["islem"];


            SqlCommand cmdpf = new SqlCommand("select * from Markalar  ", baglanti.baglan());
            SqlDataReader readepf = cmdpf.ExecuteReader();
            rptr_resim.DataSource = readepf;
            rptr_resim.DataBind();

            if (islem == "sil")
            {
                SqlCommand cmdhs = new SqlCommand("delete from Markalar where  MarkaId = '" + MarkaId + "'", baglanti.baglan());
                cmdhs.ExecuteNonQuery();

                Response.Redirect("marka.aspx");

            }

        }
    }
}