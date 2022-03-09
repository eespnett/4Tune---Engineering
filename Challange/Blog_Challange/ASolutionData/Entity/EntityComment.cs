using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Entity
{
    public class EntityComment
    {
        public int id { get; set; }
        public string nmComment { get; set; }
        public DateTime DtComment { get; set; }
        public int Status { get; set; }



        public EntityComment()
        {
            id = int.MinValue;
            nmComment = string.Empty;
            DtComment = DateTime.MinValue;

            Status = int.MinValue;
        
        }
    }
}