using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using WEBJOBS.Model;


namespace WEBJOBS.DAL
{
    public class UserGateway
    {
        string connectionConfig = ConfigurationManager.ConnectionStrings["WebJobsDB"].ConnectionString;
        public int InsertUserInfo(UserInfoModel userinfo)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);
            string query = "INSERT INTO TBL_USERINFO VALUES ('" + userinfo.Name + "','" + userinfo.Passwod + "','" + userinfo.Email + "')";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            int affectedRow = aCommand.ExecuteNonQuery();
            connection.Close();

            return affectedRow;
        }




        public UserInfoModel FindEmail(string p)
         {
             SqlConnection connection = new SqlConnection(connectionConfig);
             string query = "SELECT * FROM TBL_USERINFO WHERE USER_EMAIL='"+p+"'";
             SqlCommand aCommand = new SqlCommand(query, connection);
             connection.Open();
             SqlDataReader aReader = aCommand.ExecuteReader();
             UserInfoModel UserInfo = null;
             while (aReader.Read())
             {
                 if (UserInfo == null)
                 {
                     UserInfo = new UserInfoModel();
                 }
                 UserInfo.Id = int.Parse(aReader["USER_ID"].ToString());
                 UserInfo.Name = aReader["USER_NAME"].ToString();
                 UserInfo.Passwod = aReader["USER_PASSWORD"].ToString();
                 UserInfo.Email = aReader["USER_EMAIL"].ToString();

             }

             aReader.Close();
             connection.Close();
             return UserInfo;

         }




        public UserInfoModel login(string email)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);
            string query = "SELECT * FROM TBL_USERINFO WHERE USER_EMAIL='" +email + "'";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
             UserInfoModel UserInfo=null;
            while (aReader.Read())
            {
                if (UserInfo == null)
                {
                   UserInfo= new UserInfoModel();
                }
                UserInfo.Id = int.Parse(aReader["USER_ID"].ToString());
                UserInfo.Name = aReader["USER_NAME"].ToString();
                UserInfo.Passwod = aReader["USER_PASSWORD"].ToString();
                UserInfo.Email = aReader["USER_EMAIL"].ToString();
                
            }

            aReader.Close();
            connection.Close();
            return UserInfo;
        }
    }
    }