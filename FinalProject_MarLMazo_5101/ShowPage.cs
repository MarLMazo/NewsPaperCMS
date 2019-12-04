using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_MarLMazo_5101
{
    public class ShowPage
    {
        //public string PageID { get; set; }
        //public string PageTitle { get; set; }
        //public string PageContent { get; set; }
        //public string PublishDate { get; set; }


        
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