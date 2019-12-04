using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace FinalProject_MarLMazo_5101
{
    public partial class AdminPage : System.Web.UI.Page
    {
        public static int NumberOfNews = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            // call for the database
            var db = new PageDB();
            //set the string to be use for database
            string query = "select * from news";
            //call the database and put it in a list
            List<Dictionary<String, String>> rs = db.List_Query(query);
            //get the count in the database, this will be used for previous and next button in the ShowPage.cs
            NumberOfNews = rs.Count;
            //Call the Print List function 
            NewsList(rs);
            Debug.WriteLine(NumberOfNews);
            
        }

        public void NewsList(List<Dictionary<String, String>> rs)
        {

            //string newsID = Request.QueryString["NEWSID"];
            //Debug.WriteLine(newsID + " This is newsID");
            //var db = new PageDB();
            //string query = "select * from news";
            //List<Dictionary<String, String>> rs = db.List_Query(query);
            //NumberOfNews = rs.Count;
            //Debug.WriteLine(rs.Count);

            foreach (Dictionary<String, String> row in rs)
            {
                string newsID = row["NEWSID"];
                string newsTitle = row["NEWSTITLE"];
                string newsDate = row["NEWSDATE"];
              
                //Creating the navigation LI for the page. this will be dynamic output that will change depending on the number of List in database
                nav.InnerHtml += "<li>";
                nav.InnerHtml += "<a href=\"ShowNewsPage.aspx?NEWSID=" + newsID + "\"> Page " + newsID + "</a>";
                nav.InnerHtml += "</li>";

                // Creating a DIV by g_mani on September 13,2013 https://forums.asp.net/t/1935334.aspx?creating+div+html+control+dynamically
                //Creating a DIV element using a control, cannot mix adding elements in of HTML and Asp.net, this will give context cannot be read, 
                //You cannot create a control and then creating an HTML, or vice versa. BUt you can create an HTML inside a control.
                
                System.Web.UI.HtmlControls.HtmlGenericControl createDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                System.Web.UI.HtmlControls.HtmlGenericControl actionDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");
                createDiv.Attributes["class"] = "pageList";
                actionDiv.Attributes["class"] = "actionList";

                actionDiv.InnerHtml += "<a href=\"UpdateNewsPage.aspx?NEWSID=" + newsID + "\"><img src=\"../Images/edit.png\" alt=\"Update Image Button\"/></a>";

                //Button BtnDel = new Button()
                //{

                //    ID = newsID,
                //    Text = "Delete",
                //    OnClientClick = "return confirm('Are you sure you want to Delete?')"
                //};

                //Need to create a button dynamically, but cannot create using HTML style (using innerHtml) cannot reference any function on a button created by HTML style.
                ImageButton BtnDel = new ImageButton()
                {
                    ID = newsID,
                    ImageUrl = "~/Images/delete.png",
                    AlternateText = "Image for Delete Button",
                    OnClientClick = "return confirm('Are you sure you want to Delete?')",                 
                    Height = 30,
                    Width = 30,                               
                };

                // This will add the anchor-tag UPDATE and a button for DELETE in a control. 
                actionDiv.Controls.Add(BtnDel);
                
                //createDiv.InnerHtml += "<div class=\"pageList\">";
                createDiv.InnerHtml += "<div><input type=\"checkbox\"/></div>";
                createDiv.InnerHtml += "<div><a href=\"ShowNewsPage.aspx?NEWSID=" + newsID + "\">" + newsTitle + "</a></div>";
                createDiv.InnerHtml += "<div>" + newsDate + "</div>";
                createDiv.Controls.Add(actionDiv);

                //actionDiv.InnerHtml += "<button ID=\"BtnDel\" onClick=\"BtnDel_Click\" >Delete</button>";
                //newsList.InnerHtml += "</div>";
                //Debug.WriteLine(newsID + " This is newsID");

                newsList.Controls.Add(createDiv);
                //Adding Event listener to the BTN we created, since we have lots of button, need to specify the specific work the buttons need to do
                BtnDel.Click += new ImageClickEventHandler(BtnDel_Click);
                
            }


        }
        protected void ShowAddPage_Click(object sender, EventArgs e)
        {
            //string query = "select * from students WHERE STUDENTID ="
            //Button button1 = (Button)sender;

            //Get the Data to be updated and Post it on another aspx.file
            Response.Redirect("AddNewsPage.aspx");
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(" This is DeleteStart");
            ImageButton b = (ImageButton)sender;
            int DeleteID = Convert.ToInt32(b.ID);
            //Debug.WriteLine(DeleteID);
            var db = new PageDB();
            string query = "DELETE FROM news WHERE NEWSID =" + DeleteID;
            //Debug.WriteLine(query);
            db.List_Query(query);
            //Reset the Table header and nav-menu since it was hard coded in the page.
            newsList.InnerHtml = "<div class=\"pageList\"><div>Publish</div><div>News Title</div><div>News Publish Date</div><div>Action</div></div> ";
            nav.InnerHtml = "";
            //This will Load The Page_load of the Page once Delete Button is confirm
            Page_Load(this, null);
            //Debug.WriteLine(" This is firstpage");
            //Button button1 = (Button)sender;
            //Response.Redirect("AddNewsPage.aspx");
            //But I want a pop up screen that asking for confirmation of Delete
            //string query = "DELETE FROM news WHERE NEWSID = Id";
            //Debug.WriteLine(" This is lastpage");

        }
        protected void Search_Click(object sender, EventArgs e)
        {
            newsList.InnerHtml = "<div class=\"pageList\"><div>Publish</div><div>News Title</div><div>Publish Date</div><div>Action</div></div> ";
            nav.InnerHtml = "";
            string searchkey = "";
            if (Page.IsPostBack)
            {
                //WARNING: This technique is vulnerable to SQL injections
                //read more about SQL injections
                //https://www.csoonline.com/article/3257429/what-is-sql-injection-how-sqli-attacks-work-and-how-to-prevent-them.html
                //we will learn to defend against these attacks next semester
                searchkey = newsSearch.Text;
            }

            string query = "select * from news";

            if (searchkey != "")
            {               
                query += " WHERE NEWSTITLE like '%" + searchkey + "%' ";
                query += " or NEWSDATE LIKE '%" + searchkey + "%'";
            }

       
            var db = new PageDB();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            NewsList(rs);

        }
    }
}