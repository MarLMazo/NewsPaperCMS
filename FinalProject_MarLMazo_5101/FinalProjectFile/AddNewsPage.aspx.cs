using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace FinalProject_MarLMazo_5101.FinalProjectFile
{
    public partial class AddNewsPage : System.Web.UI.Page
    {
    
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                var PageInfo = new PageInfo();
                PageInfo.SetPageTitle(NewsTitle.Text.ToString());
                PageInfo.SetPublishDate(Convert.ToDateTime(NewsDate.Text));
                PageInfo.SetPageContent(NewsContent.Text.ToString());

                //Debug.WriteLine(NEWSDATE);
                
                //string query = "INSERT INTO news (NEWSTITLE,NEWSCONTENT,NEWSDATE) VALUES ('" + NEWSTITLE + "','" + NEWSCONTENT + "','" + NEWSDATE + "')";
                //Debug.WriteLine(query);
                var db = new PageDB();
                db.Add_News(PageInfo);


                Response.Redirect("AdminPage.aspx");
            }
        }
        protected void BtnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}