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
    public partial class portfolio1 : System.Web.UI.Page
    {

        Baglan baglan = new Baglan();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }
            if (Page.IsPostBack == false)
            {
                SqlCommand cmdpf = new SqlCommand("select * from isler ", baglan.baglan());
                SqlDataReader readepf = cmdpf.ExecuteReader();
                rpt_isler.DataSource = readepf;
                rpt_isler.DataBind();


            }



        }
    }
}