using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WEBJOBS.Model;


namespace WEBJOBS.DAL
{
    public class JobGateway
    {
        string connectionConfig = ConfigurationManager.ConnectionStrings["WebJobsDB"].ConnectionString;
        public int InsertJobDescription(JobDescriptionModel description)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);
            string query = "INSERT INTO TBL_JOB_DESCRIPTION VALUES ('" + description.Position + "','" + description.CompanyName + "','" + description.Education + "','" 
                + description.Experience + "','" + description.Salary + "','" + description.Vacancies + "','" + description.Description + "','" + description.Category + "')";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            int affectedRow = aCommand.ExecuteNonQuery();
            connection.Close();

            return affectedRow;
        }

        public int InsertCategory(CategoryModel category)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);
            string query = "INSERT INTO TBL_CATEGORY VALUES ('" + category.Category + "')";
            SqlCommand aCommand = new SqlCommand(query, connection);
            connection.Open();
            int affectedRow = aCommand.ExecuteNonQuery();
            connection.Close();

            return affectedRow;

            
        }

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


        public List<CategoryModel> GetAllCategory()
        {
            SqlConnection connection = new SqlConnection(connectionConfig);
            string query = "SELECT * FROM TBL_CATEGORY";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<CategoryModel> aCategoryList = new List<CategoryModel>();
            while (aReader.Read())
            {
                CategoryModel aCategory = new CategoryModel();
                aCategory.Category = aReader["CATEGORY_NAME"].ToString();
                aCategory.Id = int.Parse(aReader["CATEGORY_ID"].ToString());
                
                aCategoryList.Add(aCategory);
            }

            aReader.Close();
            connection.Close();
            return aCategoryList;
        }


        public List<JobDescriptionModel> GetAllJobDescription()
        {
            SqlConnection connection = new SqlConnection(connectionConfig);

            string query = " SELECT * FROM DESCRIPTION_CATEGORY ";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<JobDescriptionModel> aJobDescriptionList = new List<JobDescriptionModel>();
            while (aReader.Read())
            {
                JobDescriptionModel aJobDescription = new JobDescriptionModel();

                aJobDescription.Id = int.Parse(aReader["JOB_ID"].ToString());
                aJobDescription.Position= aReader["JOB_POSITION"].ToString();
                aJobDescription.CompanyName = aReader["JOB_COMPANY_NAME"].ToString();
                aJobDescription.Education = aReader["JOB_EDUCATION"].ToString();
                aJobDescription.Experience = aReader["JOB_EXPERIENCE"].ToString();
                aJobDescription.Salary = aReader["JOB_SALARY_RANGE"].ToString();
                aJobDescription.Vacancies = aReader["JOB_VACANCIES"].ToString();
                aJobDescription.Description = aReader["JOB_DESCRIPTION_RESPONSIBILITY"].ToString();
                aJobDescription.Category = aReader["CATEGORY_NAME"].ToString();
                aJobDescriptionList.Add(aJobDescription);
            }

            aReader.Close();
            connection.Close();
            return aJobDescriptionList;
        }

        public List<JobDescriptionModel> GetAllJobByCategoryDetails( int id)
        {
            SqlConnection connection = new SqlConnection(connectionConfig);

            string query = " SELECT * FROM DESCRIPTION_BY_CATEGORY WHERE CATEGORY_ID ='"+id+"'  ";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<JobDescriptionModel> aJobDescriptionList = new List<JobDescriptionModel>();
            while (aReader.Read())
            {
                JobDescriptionModel aJobDescription = new JobDescriptionModel();

                aJobDescription.Id = int.Parse(aReader["JOB_ID"].ToString());
                aJobDescription.CategoryId = int.Parse(aReader["CATEGORY_ID"].ToString());
                aJobDescription.Position = aReader["JOB_POSITION"].ToString();
                aJobDescription.CompanyName = aReader["JOB_COMPANY_NAME"].ToString();
                aJobDescription.Education = aReader["JOB_EDUCATION"].ToString();
                aJobDescription.Experience = aReader["JOB_EXPERIENCE"].ToString();
                aJobDescription.Salary = aReader["JOB_SALARY_RANGE"].ToString();
                aJobDescription.Vacancies = aReader["JOB_VACANCIES"].ToString();
                aJobDescription.Description = aReader["JOB_DESCRIPTION_RESPONSIBILITY"].ToString();
                aJobDescription.Category = aReader["CATEGORY_NAME"].ToString();
                aJobDescriptionList.Add(aJobDescription);
            }

            aReader.Close();
            connection.Close();
            return aJobDescriptionList;
        }

        public List<JobDescriptionModel> GetCategory()
        {
            SqlConnection connection = new SqlConnection(connectionConfig);

            string query = " SELECT * FROM DESCRIPTION_BY_CATEGORY";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<JobDescriptionModel> aJobDescriptionList = new List<JobDescriptionModel>();
            while (aReader.Read())
            {
                JobDescriptionModel aJobDescription = new JobDescriptionModel();

                aJobDescription.Id = int.Parse(aReader["JOB_ID"].ToString());
                aJobDescription.Position = aReader["JOB_POSITION"].ToString();
                aJobDescription.CompanyName = aReader["JOB_COMPANY_NAME"].ToString();
                aJobDescription.Education = aReader["JOB_EDUCATION"].ToString();
                aJobDescription.Experience = aReader["JOB_EXPERIENCE"].ToString();
                aJobDescription.Salary = aReader["JOB_SALARY_RANGE"].ToString();
                aJobDescription.Vacancies = aReader["JOB_VACANCIES"].ToString();
                aJobDescription.Description = aReader["JOB_DESCRIPTION_RESPONSIBILITY"].ToString();
                aJobDescription.Category = aReader["CATEGORY_NAME"].ToString();
                aJobDescription.CategoryId = int.Parse(aReader["CATEGORY_ID"].ToString());
                aJobDescriptionList.Add(aJobDescription);
            }

            aReader.Close();
            connection.Close();
            return aJobDescriptionList;
        }

        public List<UserInfoModel> GetAllUserInfo()
        {
            SqlConnection connection = new SqlConnection(connectionConfig);
            string query = "SELECT * FROM TBL_USERINFO";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<UserInfoModel> aUserInfoList = new List<UserInfoModel>();
            while (aReader.Read())
            {
                UserInfoModel aUserInfo = new UserInfoModel();
                aUserInfo.Id = int.Parse(aReader["USER_ID"].ToString());
                aUserInfo.Name = aReader["USER_NAME"].ToString();
                aUserInfo.Passwod = aReader["USER_PASSWORD"].ToString();
                aUserInfo.Email = aReader["USER_EMAIL"].ToString();
                aUserInfoList.Add(aUserInfo);
            }

            aReader.Close();
            connection.Close();
            return aUserInfoList;
        }





        public JobDescriptionModel GetAjobDescription(int id)
        {
             SqlConnection connection = new SqlConnection(connectionConfig);

            string query = " SELECT * FROM DESCRIPTION_CATEGORY WHERE JOB_ID='"+id+"' ";
            connection.Open();
            SqlCommand aCommand = new SqlCommand(query, connection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            JobDescriptionModel aJobDescription =null;
            while (aReader.Read())
            {
                if (aJobDescription == null)
                {
                    aJobDescription= new JobDescriptionModel();
                }

                aJobDescription.Id = int.Parse(aReader["JOB_ID"].ToString());
                aJobDescription.Position= aReader["JOB_POSITION"].ToString();
                aJobDescription.CompanyName = aReader["JOB_COMPANY_NAME"].ToString();
                aJobDescription.Education = aReader["JOB_EDUCATION"].ToString();
                aJobDescription.Experience = aReader["JOB_EXPERIENCE"].ToString();
                aJobDescription.Salary = aReader["JOB_SALARY_RANGE"].ToString();
                aJobDescription.Vacancies = aReader["JOB_VACANCIES"].ToString();
                aJobDescription.Description = aReader["JOB_DESCRIPTION_RESPONSIBILITY"].ToString();
                aJobDescription.Category = aReader["CATEGORY_NAME"].ToString();
               
            }

            aReader.Close();
            connection.Close();
            return aJobDescription;
        
        }
    }
}