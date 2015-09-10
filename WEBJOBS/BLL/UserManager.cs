using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEBJOBS.Model;
using WEBJOBS.DAL;

namespace WEBJOBS.BLL
{
    public class UserManager
    {
        UserGateway aUserGateway = new UserGateway();
        public UserInfoModel login(string  email)
        {
            
               return aUserGateway.login(email);
                
        }
        public string InsertUserInfo(UserInfoModel userinfo)
        {
            int message = aUserGateway.InsertUserInfo(userinfo);

            if (message > 0)
            {
                return "Successfully Registered";
            }
            else
            {
                return "Register Error !! Try again ";
            }


        }


    }
}