using Blog_Challange.ASolutionData.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


using System.Web.Mvc;

namespace WebBlob.Models
{
    public class BlogModel
    {
       
        public EntityUser oUser { get; set; }

     
            public List<EntityTopic> ListEntityTopic { get; set; }


        public List<EntityComment> ListEntityComments { get; set; }


    }
}