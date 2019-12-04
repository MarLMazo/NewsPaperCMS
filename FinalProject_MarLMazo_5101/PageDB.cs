using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace FinalProject_MarLMazo_5101
{
    public class PageDB
    {
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "newspaper"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "8889"; } }

        //ConnectionString is something that we use to connect to a database
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);       
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();
           
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader PageResult = cmd.ExecuteReader();
                Debug.WriteLine(query+"execute already");

                //for every row in the result set
                while (PageResult.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                   // Debug.WriteLine("FieldCount = " +PageResult.FieldCount);
                    for (int i = 0; i < PageResult.FieldCount; i++)
                    {
                        Row.Add(PageResult.GetName(i), PageResult.GetString(i));
                    }

                    ResultSet.Add(Row);
                    Debug.WriteLine(query + "results reading already");
                }//end row
                PageResult.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;
        }

        public void Delete_News(int newsID)
        {
            //deleting a student will require us to modify two tables
            //one table is the studentsxclasses table (deleting where the studentid is specified)
            //one table is the students table (to delete the student)
            //Note: A MySQL trigger can be set up so that the appropriate studentsxclasses records are deleted
            //when the student is deleted. Currently this database isn't set up with a trigger

            //DELETING ON THE FOREIGN KEY OF STUDENTID IN STUDENTSXCLASSES
            string query = "DELETE FROM news WHERE NEWSID = {0} " ;
            query = String.Format(query, newsID);
            //string removeclasses = "delete from STUDENTSXCLASSES where STUDENTID = {0}";
            //removeclasses = String.Format(removeclasses, studentid);

            //DELETING ON THE PRIMARY KEY OF STUDENTS
            //string removestudent = "delete from STUDENTS where STUDENTID = {0}";
            //removestudent = String.Format(removestudent, studentid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //This command removes all the target student's classes from the studentsxclasses table
            //MySqlCommand cmd_removeclasses = new MySqlCommand(removeclasses, Connect);
            //This command removes the particular student from the table
            MySqlCommand cmd_removePage = new MySqlCommand(query, Connect);
            try
            {
                //try to execute both commands!
                Connect.Open();
                //remember to remove the relational element first
                //cmd_removeclasses.ExecuteNonQuery();
                //Debug.WriteLine("Executed query " + cmd_removeclasses);
                //then delete the main record
                cmd_removePage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removePage);
            }
            catch (Exception ex)
            {
                //if this isn't working as intended, you can check debug>windows>output for the error message.
                Debug.WriteLine("Something went wrong in the delete Student Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void Update_News(PageInfo newPage, int newsID)
        {
            //slightly better way of injecting data into strings

            //string query = "insert into students (STUDENTFNAME, STUDENTLNAME, STUDENTNUMBER, ENROLMENTDATE) values ('{0}','{1}','{2}','{3}')";
            string query = "UPDATE news SET NEWSTITLE='{0}', NEWSCONTENT='{1}' WHERE NEWSID = {2}";
            //string query = "INSERT INTO news (NEWSTITLE,NEWSCONTENT,NEWSDATE) VALUES ('{0} ','{1}','{2}')";
            query = String.Format(query, newPage.GetPageTitle(), newPage.GetPageContent(), newsID);


            //This technique is still sensitive to SQL injection
            //
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddStudent Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();

        }
        //Chrstine Bittle In-class Example Web Application Nov 29,2019
        public void Add_News(PageInfo newPage)
        {
            //slightly better way of injecting data into strings

            //string query = "insert into students (STUDENTFNAME, STUDENTLNAME, STUDENTNUMBER, ENROLMENTDATE) values ('{0}','{1}','{2}','{3}')";
            string query = "INSERT INTO news (NEWSTITLE,NEWSCONTENT,NEWSDATE) VALUES ('{0} ','{1}','{2}')";
            query = String.Format(query, newPage.GetPageTitle(), newPage.GetPageContent(), newPage.GetPublishDate().ToString("yyyy-MM-dd"));


            //This technique is still sensitive to SQL injection
            //

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddStudent Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();

        }
    }
}