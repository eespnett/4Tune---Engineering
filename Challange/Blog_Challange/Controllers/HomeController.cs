using Blog_Challange.ASolutionData.Business;
using Blog_Challange.ASolutionData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBlob.Models;

namespace Blog_Challange.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult EditTopic(TopicModel myModel)
        {

            EntityTopic oEntityTopic = new EntityTopic();
            EntityTopic myEntityTopic = new EntityTopic();
            int idOpration = int.MinValue;

            oEntityTopic.id = myModel.id;
            oEntityTopic.DtCreator = myModel.dtCreator;
            oEntityTopic.idUserCreator = myModel.idUser;
            oEntityTopic.nmTopic = myModel.nmTopic;
            oEntityTopic.Status = myModel.Status;

            myEntityTopic = new BusinessTopic().SelecionarTopic(oEntityTopic.id);

            if (myEntityTopic.Status==1)// update
            {
                idOpration = new BusinessTopic().UpdateTopic(oEntityTopic);
            }// insert
            else
            {
                idOpration = new BusinessTopic().InsertTopic(oEntityTopic);
            }



            return View(myModel);
        }


        public ActionResult EditTopic(string idTopic)
        {
            EntityTopic oEntityTopic = new EntityTopic();
             TopicModel myModel = new TopicModel();


            if (idTopic!="0")
            {
                oEntityTopic = new BusinessTopic().SelecionarTopic(int.Parse(idTopic));

                if (oEntityTopic.Status == 1)
                {
                    myModel.dtCreator = oEntityTopic.DtCreator;
                    myModel.id = oEntityTopic.id;
                    myModel.idUser = oEntityTopic.idUserCreator;
                    myModel.nmTopic = oEntityTopic.nmTopic;
                    myModel.Status = oEntityTopic.Status;
                }
            }
            
         



            return View(myModel);
        }

        public ActionResult EditTopic()
        {
       
            TopicModel myModel = new TopicModel();


        





            return View(myModel);
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IndexModel myModel)
        {

            EntityUser oEntityUser = new EntityUser();
            List<EntityTopic> myListEntityTopic = new List<EntityTopic>();



            oEntityUser.User = myModel.strUser.ToString();
            oEntityUser.Senha = myModel.strSenha.ToString();

            oEntityUser = new BusinessUser().AuthenticateUser(oEntityUser);

            if (oEntityUser.Status==1)
            {
                BlogModel myBlogModel = new BlogModel();
                myBlogModel.oUser = oEntityUser;

                myListEntityTopic = new BusinessTopic().ListTopics();

                myBlogModel.ListEntityTopic = myListEntityTopic;



                return View("Blog", myBlogModel);
            }
            else
            {
                ViewBag.Message = "Erro on Authenticate. Try again.";
            }
      

            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }

        [HttpPost]
        public ActionResult About(RegisterModel myModel)
        {
            EntityUser oEntityUser = new EntityUser();
            int returnOperation = int.MinValue;

            if (ModelState.IsValid)
            {
                if (myModel.strSenha==myModel.strSenhaConfirmacao)
                {
                    oEntityUser.Senha = myModel.strSenha.ToString();
                }
                else
                {
                  ModelState.AddModelError("senha", "It should be equal to the Confirmation!");
                    return View();
                }

              


                oEntityUser.Status = 1;
      
                oEntityUser.Nome = myModel.strNome.ToString();
                oEntityUser.User = myModel.strUser.ToString();
                oEntityUser.Email = myModel.strEmail.ToString();
                oEntityUser.DtNascimento = myModel.dtNasc;


                returnOperation = new BusinessUser().InsertUser(oEntityUser);


            }

            ModelState.Clear();


            ViewBag.Message = "User Insert Successfully.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}