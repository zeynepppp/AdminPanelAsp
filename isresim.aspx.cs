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
    public partial class isresim : System.Web.UI.Page
    {

        Baglan baglan  = new Baglan();
        String isId = "";
        String islem = "";
        String ResimId = "";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["AdminKullaniciAdi"] == null)
            {

                Response.Redirect("giris.aspx");
            }
            isId = Request.QueryString["isId"];
            islem = Request.QueryString["islem"];
            ResimId = Request.QueryString["ResimId"];

            if (Page.IsPostBack == false)
            {//"SELECT *FROM [dbo].[Blog]  b INNER JOIN [dbo].[Comment] c ON b.Id = c.BlogId where b.Id='"+Id+"' and Active=1",
                SqlCommand cmdpf = new SqlCommand("select * from isresim where isId='"+isId+"'  ", baglan.baglan());
                SqlDataReader readepf = cmdpf.ExecuteReader();
                 rptr_resim.DataSource = readepf;
                 rptr_resim.DataBind();
                SqlCommand cmdi = new SqlCommand("select * from isler where isId='" + isId + "'  ", baglan.baglan());
                SqlDataReader readi = cmdi.ExecuteReader();
                if (readi.Read())
                {
                    ltr_is_baslik.Text = readi["isBaslik"].ToString();

                }
                else

                    ltr_is_baslik.Text = "baslik çekilemedi..";
            }

            if (islem == "sil")
            {
                SqlCommand cmdhs = new SqlCommand("delete from isresim where  ResimId = '" + ResimId  + "'", baglan.baglan());
                cmdhs.ExecuteNonQuery();

                Response.Redirect("isler.aspx");

            }


        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {

            if (FUP_RESIM.HasFile)
            {

                //fu_is_resim1.SaveAs(Server.MapPath("/images/" + fu_is_resim1.FileName));
                FUP_RESIM.SaveAs(Server.MapPath("/resimler/" + FUP_RESIM.FileName));


                SqlCommand cmdEkle = new SqlCommand("insert into isresim ( ResimUrl,isId ) values ( '/resimler/" + FUP_RESIM.FileName + "' ,'" +  isId + "')", baglan.baglan());
                cmdEkle.ExecuteNonQuery();

                Response.Redirect("isler.aspx");
            }
            else
                ltr_baslik.Text = "Resim ekleyiniz";


        }

        protected void btn_iptal_Click(object sender, EventArgs e)
        {
            Response.Redirect("isler.aspx");
        }
    }
}