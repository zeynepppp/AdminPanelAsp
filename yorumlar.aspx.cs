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
    public partial class yorumlar1 : System.Web.UI.Page
    {

        Baglan baganti = new Baglan();
        String YorumId = "";
        String islem = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            YorumId = Request.QueryString["YorumId"];
            islem = Request.QueryString["islem"];


            if (Page.IsPostBack == false)
            {
                SqlCommand cmdhg = new SqlCommand("select   * from Yorumlar  ", baganti.baglan());

                SqlDataReader readerh = cmdhg.ExecuteReader();
                rpt_mesaj.DataSource = readerh;
                rpt_mesaj.DataBind();
            }

            if (islem == "sil")
            {
                SqlCommand cmdhs = new SqlCommand("delete from Yorumlar where  YorumId = '" + YorumId + "'", baganti.baglan());
                cmdhs.ExecuteNonQuery();

                Response.Redirect("yorumlar.aspx");

            }
            else if (islem == "onayla")
            {


                SqlCommand cmdhs = new SqlCommand("Update  Yorumlar set Durum=1  where  YorumId = '" + YorumId + "'", baganti.baglan());
                cmdhs.ExecuteNonQuery(); 

                Response.Redirect("yorumlar.aspx");
            }
        }
    }
}