﻿using System;
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

        //Christine In-class example of Web Application 2019
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
                     
            string query = "DELETE FROM news WHERE NEWSID = {0} " ;
            query = String.Format(query, newsID);
            
            MySqlConnection Connect = new MySqlConnection(ConnectionString);         
            MySqlCommand cmd_removePage = new MySqlCommand(query, Connect);
            try
            {
               
                Connect.Open();               
                cmd_removePage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removePage);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the delete Student Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void Update_News(PageInfo newPage, int newsID)
        {

            string query = "UPDATE news SET NEWSTITLE=\"{0}\", NEWSCONTENT=\"{1}\" WHERE NEWSID = {2}";
            query = String.Format(query, newPage.GetPageTitle(), newPage.GetPageContent(), newsID);
            Debug.WriteLine(query);
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

            string query = "INSERT INTO news (NEWSTITLE,NEWSCONTENT,NEWSDATE) VALUES (\"{0}\",\"{1}\",\"{2}\")";
            query = String.Format(query, newPage.GetPageTitle(), newPage.GetPageContent(), newPage.GetPublishDate().ToString("yyyy-MM-dd"));


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