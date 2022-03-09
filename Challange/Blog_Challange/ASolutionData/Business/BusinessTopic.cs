using Blog_Challange.ASolutionData.Data;
using Blog_Challange.ASolutionData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Business
{
    public class BusinessTopic : DataTopic
    {
        internal List<EntityTopic> ListTopics()
        {
            List<EntityTopic> returnListEntityTopic = new List<EntityTopic>();

            returnListEntityTopic = base.ListTopics();

            return returnListEntityTopic;
        }

        internal EntityTopic SelecionarTopic(int v)
        {
            EntityTopic returnSelecionarTopic = new EntityTopic();

            returnSelecionarTopic = base.SelecionarTopic(v);

            return returnSelecionarTopic;
        }

        internal int UpdateTopic(EntityTopic oEntityTopic)
        {
            int returnOperation = int.MinValue;

            returnOperation = base.UpdateTopic(oEntityTopic);

            return returnOperation;
        }

        internal int InsertTopic(EntityTopic oEntityTopic)
        {
            int returnOperation = int.MinValue;

            returnOperation = base.InsertTopic(oEntityTopic);

            return returnOperation;
        }
    }
}