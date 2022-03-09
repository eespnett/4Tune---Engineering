using Blog_Challange.ASolutionData.Data;
using Blog_Challange.ASolutionData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Business
{
    public class BusinessUser : DataUser
    {
        internal int InsertUser(EntityUser oEntityUser)
        {
            int returnInsertUser = int.MinValue;

            returnInsertUser=  base.InsertUser(oEntityUser);

            return returnInsertUser;
        }

        internal EntityUser AuthenticateUser(EntityUser oEntityUser)
        {
            EntityUser returnAuthenticateUser = new EntityUser();


            returnAuthenticateUser = base.AuthenticateUser(oEntityUser);

            return returnAuthenticateUser;

         
        }
    }
}