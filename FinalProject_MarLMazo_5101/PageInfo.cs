using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_MarLMazo_5101
{
    public class PageInfo
    {

 
        private string PageTitle;
        private string PageContent;
        private DateTime PublishDate;

        //Christine Bittle In-class Exammple November 29,2019 Web Application
        //GET VALUES
        public string GetPageTitle()
        {
            return PageTitle;
        }
        public string GetPageContent()
        {
            return PageContent;
        }
        public DateTime GetPublishDate() 
        {
            return PublishDate;
        }

        // SET VALUES
        public void SetPageTitle(string value)
        {
            PageTitle = value;
        }
        public void SetPageContent(string value)
        {
            PageContent = value;
        }
        public void SetPublishDate(DateTime value)
        {

            PublishDate = value;
        }


        public string ShowSpecificPage(int newsID)
        {
            string content = "";
            var db = new PageDB();
            string query = "select * from news WHERE NEWSID=" + newsID;
            //PageDB db = new PageDB();
            //ShowPage(db);
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                //string newsTitle = row["NEWSTITLE"];
                //string newsDate = row["NEWSDATE"];
                //string newsContent = row["NEWSCONTENT"];
                string PageTitle = row["NEWSTITLE"];
                string PageContent = row["NEWSCONTENT"];
                string PublishDate = row["NEWSDATE"];


                content += "<div class=\"showNews\">";
                content += "<h1>" + PageTitle + "</h1>";
                content += "<div>" + PageContent + "</div>";
                content += "<div>" + PublishDate + " </ div > ";
                content += "</div>";



            }

            return content;


        }

        public string ShowAllPage()
        {
            string content = "";

            var db = new PageDB();
            string query = "select * from news";
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
 
                string PageTitle = row["NEWSTITLE"];
                string PageContent = row["NEWSCONTENT"];
                string PublishDate = row["NEWSDATE"];


                content += "<div class=\"showNews\">";
                content += "<h1>" + PageTitle + "</h1>";
                content += "<div>" + PageContent + "</div>";
                content += "<div>" + PublishDate + " </ div > ";
                content += "</div>";
             
            }

            return content;
        }


    }
}