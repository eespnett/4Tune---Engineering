using Blog_Challange.ASolutionData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Data
{
    public class DataUser
    {
        internal int InsertUser(EntityUser oEntityUser)
        {
            int returnInsertUser = int.MinValue;

            using (db4TuneEntities context = new db4TuneEntities())
            {
                TbUser myUser = new TbUser();
                myUser.DtNascimento = oEntityUser.DtNascimento;
                myUser.Email = oEntityUser.Email;
                myUser.Nome = oEntityUser.Nome;
                myUser.senha = oEntityUser.Senha;
                myUser.Status = oEntityUser.Status;
                myUser.user = oEntityUser.User;

                context.TbUsers.Add(myUser);

               
                context.SaveChanges();
                 returnInsertUser = myUser.Id;

            }

            return returnInsertUser;
        }

        internal EntityUser AuthenticateUser(EntityUser oEntityUser)
        {
            EntityUser returnAuthenticateUser = new EntityUser();


            using (db4TuneEntities context = new db4TuneEntities())
            {
                TbUser myUser = new TbUser();

                myUser = context.TbUsers.Where(x => x.user == oEntityUser.User && x.senha == oEntityUser.Senha && x.Status == 1).FirstOrDefault();

                returnAuthenticateUser.id = myUser.Id;
                returnAuthenticateUser.DtNascimento =  (myUser.DtNascimento==null?DateTime.MinValue: (DateTime)myUser.DtNascimento);
                returnAuthenticateUser.Email = myUser.Email;
                returnAuthenticateUser.Nome = myUser.Nome;
                returnAuthenticateUser.Senha = myUser.senha;
                returnAuthenticateUser.Status = int.Parse(myUser.Status.ToString()==""?"0":"1");
                returnAuthenticateUser.User = myUser.user;             

             
                
            }


            return returnAuthenticateUser;
        }
    }
}