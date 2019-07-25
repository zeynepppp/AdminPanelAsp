using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Security;

namespace Aksan2.jeweler_master
{
    public partial class giris : System.Web.UI.Page
    {
        Baglan baglan = new Baglan();
        String islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            ltr_giris.Text = "Giriş yapın";

            if (islem=="cikis") {

                Session.Abandon();

                FormsAuthentication.SignOut();

                Response.Redirect("giris.aspx");

            }


        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmda = new SqlCommand("select * from Admin where AdminKullaniciAdi=@p1 and AdminSifre=@p2 ", baglan.baglan());

            cmda.Parameters.AddWithValue("@p1", txt_kullaniciadi.Text);
            cmda.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader reada = cmda.ExecuteReader();

            if (reada.Read())
            {
                Session["AdminKullaniciAdi"] = reada["AdminKullaniciAdi"];


                Response.Redirect("admin.aspx");
            }
            else
            {
                ltr_giris.Text = "hatalı giriş denemesi"; 
            }
        }
    }
}