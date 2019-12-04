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
    public partial class ShowNewsPage : System.Web.UI.Page
    {
        int NumberPage = AdminPage.NumberOfNews;
        protected void Page_Load(object sender, EventArgs e)
        {

            int newsID = Convert.ToInt32(Request.QueryString["NEWSID"]);
            var Content = new ShowPage();
            PageView.InnerHtml = Content.ShowSpecificPage(newsID);

           

        }

        //protected void ShowPage(PageDB db)
        //{
        //    string newsID = Request.QueryString["NEWSID"];
        //    var Content = new ShowPage();
        //    string query = "select * from news WHERE NEWSID=" + newsID;
        //    List<Dictionary<String, String>> rs = db.List_Query(query);
        //    foreach (Dictionary<String, String> row in rs)
        //    {
                
        //        string newsTitle = row["NEWSTITLE"];
        //        string newsDate = row["NEWSDATE"];
        //        string newsContent = row["NEWSCONTENT"];
        //        Content.PageTitle = 

        //        PageView.InnerHtml += "<div class=\"showNews\">";
        //        PageView.InnerHtml += "<h1>" + newsTitle + "</h1>";
        //        PageView.InnerHtml += "<div>" + newsDate + "</div>";
        //        PageView.InnerHtml += "<div>" + newsContent + " </ div > ";
        //        PageView.InnerHtml += "</div>";

        //        Debug.WriteLine(newsID + " This is newsID");

        //    }

        //}
        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            PageDB db = new PageDB();
            string newsID = Request.QueryString["NEWSID"];
            string query = "DELETE from news WHERE NEWSID=" + newsID;
            db.List_Query(query);
            Response.Redirect("AdminPage.aspx");
        }
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
           
            string newsID = Request.QueryString["NEWSID"];   
            Response.Redirect("UpdateNewsPage.aspx?NEWSID="+newsID);
        }
        protected void BtnPrev_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(Request.QueryString["NEWSID"]);
            int PrevID = currentID - 1;

            if (PrevID < 1)
            {
                Response.Redirect("ShowNewsPage.aspx?NEWSID=" + currentID);
            }
            else
            {
                Response.Redirect("ShowNewsPage.aspx?NEWSID=" + PrevID);
            }
            
        }
        
        protected void BtnNext_Click(object sender, EventArgs e)
        {
            int currentID = Convert.ToInt32(Request.QueryString["NEWSID"]);
            int NextID = currentID + 1;

            if (NextID > NumberPage)
            {
                Response.Redirect("ShowNewsPage.aspx?NEWSID=" + currentID);
            }
            else
            {
                Response.Redirect("ShowNewsPage.aspx?NEWSID=" + NextID);
            }
            

           
           
            //int NewstID = Convert.ToInt32(NextID) + 1;
            //var Content = new ShowPage();
            //PageView.InnerHtml = Content.ShowSpecificPage(NewstID);
            //Response.Redirect("AdminPage.aspx");  
            //PageDB db = new PageDB();
            //ShowPage(db);
           
        }
        protected void BtnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }


    }
}