using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Entity
{
    public class EntityTopic
    {
        public int id { get; set; }
        public string nmTopic { get; set; }
        public int idUserCreator { get; set; }
        public DateTime DtCreator { get; set; }
        public int Status { get; set; }

        public EntityTopic()
        {
            id = int.MinValue;
            nmTopic = string.Empty;
            idUserCreator = int.MinValue;
            DtCreator = DateTime.MinValue;
            Status = int.MinValue;
        
        
        }



    }
}