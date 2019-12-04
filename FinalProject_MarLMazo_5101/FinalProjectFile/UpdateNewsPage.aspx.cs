using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace FinalProject_MarLMazo_5101
{
    public partial class UpdateNewsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PageDB db = new PageDB();
            ShowNewsPage(db);
            }
            
        }

        protected void ShowNewsPage(PageDB db)
        {
            string newsID = Request.QueryString["NEWSID"];

            string query = "select * from news WHERE NEWSID="+newsID;
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {    
                
                string newsTitle = row["NEWSTITLE"];
                string newsDate = row["NEWSDATE"];
                string newsContent = row["NEWSCONTENT"];

                NewsTitle.Text = newsTitle.ToString();
                 NewsContent.Text = newsContent.ToString();

                datePublish.InnerHtml = newsDate.ToString();

                //PageContent.InnerHtml += "<div class=\"addNews\">";
                //PageContent.InnerHtml += "<label for=\"newsTitle\"> Title: </label><input type=\"text\" ID=\"newsTitle\" value=\""+newsTitle+"\" />";
                //PageContent.InnerHtml += "<label for=\"newsDate\"> Date: </label><input type=\"text\" ID=\"newsDate\" value=\"" + newsDate + "\" />";
                //PageContent.InnerHtml += "<label for=\"newsContent\"> Content: </label><textarea type=\"text\" ID=\"newsContent\">" + newsContent +"</textarea>";
                //PageContent.InnerHtml += "</div>";

                //Debug.WriteLine(newsID + " This is newsID");


            }

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string UpdateNewsTitle = "";
            string UpdateNewsContent="";

            string newsID = Request.QueryString["NEWSID"];
            Debug.WriteLine("Query is up "+ newsID);
            
            UpdateNewsTitle = NewsTitle.Text;          
            UpdateNewsContent = NewsContent.Text;
            

            var query = "UPDATE news SET NEWSTITLE=\""+ UpdateNewsTitle+"\", NEWSCONTENT=\""+ UpdateNewsContent + "\" WHERE NEWSID = " + newsID;
            Debug.WriteLine(query);
            PageDB db = new PageDB();
            db.List_Query(query);
            Debug.WriteLine("Query is done");
            Response.Redirect("AdminPage.aspx");

        }

        protected void BtnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
}