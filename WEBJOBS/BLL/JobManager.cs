using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBJOBS.DAL;
using WEBJOBS.Model;

namespace WEBJOBS.BLL
{
    public class JobManager
    {
        JobGateway aJobGateway = new JobGateway();

        public string InsertJobDescription(JobDescriptionModel description)
        {
          
            int message = aJobGateway.InsertJobDescription( description);

            if (message > 0)
            {
                return "Job item saved successfully";
            }
            else
            {
                return "Job item not saved";
            }
        }
        public string InsertCategory(CategoryModel category)
        {

            int message = aJobGateway.InsertCategory(category);

            if (message > 0)
            {
                return "Category item saved successfully";
            }
            else
            {
                return "Category item not saved";
            }
        }

        public string InsertUserInfo(UserInfoModel userinfo)
        {

            int message = aJobGateway.InsertUserInfo(userinfo);

            if (message > 0)
            {
                return "User information saved successfully";
            }
            else
            {
                return "user information  not saved";
            }
        }

        public List<UserInfoModel> GetAllUserInfo()
        {
            return aJobGateway.GetAllUserInfo();
        }





        public List<CategoryModel> GetAllCategory()
        {

            return aJobGateway.GetAllCategory();

        }

        public List<JobDescriptionModel> GetAllJobDescription()
        {
            return aJobGateway.GetAllJobDescription();
        }
        public List<JobDescriptionModel> GetAllJobByCategoryDetails(int id)
        {
            return aJobGateway.GetAllJobByCategoryDetails(id);
        }
        public List<JobDescriptionModel> GetCategory()
        {
            return aJobGateway.GetCategory();
        }

        internal JobDescriptionModel GetAjobDescription(int id)
        {
            return aJobGateway.GetAjobDescription(id);
        }
    }
}