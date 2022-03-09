using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


using System.Web.Mvc;

namespace WebBlob.Models
{
    public class IndexModel
    {
        [Required]
        [MaxLength(150)]
        public string strUser { get; set; }

        [Required]
        [MaxLength(150)]
            public string strSenha { get; set; }

 
    }
}