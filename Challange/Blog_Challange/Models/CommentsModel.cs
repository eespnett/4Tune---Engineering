using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


using System.Web.Mvc;

namespace WebBlob.Models
{
    public class CommentsModel
    {

        public int id { get; set; }


        [Required]
 
        public string nmComment { get; set; }

        [Required]
 
        public string Comment { get; set; }


        [Required]
  
        public DateTime DtComment { get; set; }
 
        public int Status { get; set; }

 


    }
}