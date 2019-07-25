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
    public partial class admin2 : System.Web.UI.Page
    {

        Baglan baganti = new Baglan();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }

            SqlCommand cmdhg = new SqlCommand("select top 10 * from isler order by isId desc     ", baganti.baglan());
            //select top 10 * from Portfolio order by Id desc
            SqlDataReader readerh = cmdhg.ExecuteReader();
            rpt_1.DataSource = readerh;
            rpt_1.DataBind();

            SqlCommand cmdb = new SqlCommand("select  top 10* from blog  order by blogId desc   ", baganti.baglan());
            SqlDataReader readb = cmdb.ExecuteReader();
             Repeater1.DataSource = readb;
            Repeater1.DataBind();
        }
    }
}