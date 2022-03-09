using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


using System.Web.Mvc;

namespace WebBlob.Models
{
    public class TopicModel
    {
      
        public int id { get; set; }

        [Required]
        [MaxLength(150)]
        public string nmTopic { get; set; }



        [Required]
        public int idUser { get; set; }



       
  
        public DateTime dtCreator { get; set; }

        
        public int Status { get; set; }

       


    }
}