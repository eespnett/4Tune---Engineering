using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Entity
{
    public class EntityUser
    {
        public int id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime DtNascimento { get; set; }

        public string User { get; set; }


        public string Senha { get; set; }

        public int Status { get; set; }


        public EntityUser()
        {
            id = int.MinValue;
            Nome = string.Empty;
            Email = string.Empty;
            DtNascimento = DateTime.MinValue;
            User = string.Empty;
            Senha = string.Empty;
            Status = int.MinValue;




        }
    }
}