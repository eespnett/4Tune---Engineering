using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


using System.Web.Mvc;

namespace WebBlob.Models
{
    public class RegisterModel
    {

        public int id { get; set; }


        [Required]
        [MaxLength(150)]
        public string strNome { get; set; }

        [Required]
        [MaxLength(150)]
        public string strEmail { get; set; }


        [Required]
  
        public DateTime dtNasc { get; set; }

        [Required]
        [MaxLength(150)]
        public string strUser { get; set; }

        [Required]
        [MaxLength(150)]
            public string strSenha { get; set; }

        [Required]
        [MaxLength(150)]
        public string strSenhaConfirmacao { get; set; }


    }
}