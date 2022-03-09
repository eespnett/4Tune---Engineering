using Blog_Challange.ASolutionData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_Challange.ASolutionData.Data
{
    public class DataTopic
    {
        internal List<EntityTopic> ListTopics()
        {
            List<EntityTopic> returnListEntityTopic = new List<EntityTopic>();


            using (db4TuneEntities context = new db4TuneEntities())
            {
                var result = context.tbTopics.ToList();


                foreach (var item in result)
                {
                    returnListEntityTopic.Add(new EntityTopic{
                    DtCreator=(DateTime) item.DtCreator,
                    id=item.Id,
                    idUserCreator=(int)item.idUserCreator,
                    nmTopic= item.nmTopic,
                    Status=(int) item.Status
                    });
                }

            }


            return returnListEntityTopic; 
        }

        internal int UpdateTopic(EntityTopic oEntityTopic)
        {
            int returnInsertTopic = int.MinValue;

            using (db4TuneEntities context = new db4TuneEntities())
            {
                tbTopic myTopic = new tbTopic();
                myTopic = context.tbTopics.Where(x => x.Id == oEntityTopic.id && x.Status == 1).FirstOrDefault();

                if (myTopic!=null)
                {
          
                    myTopic.idUserCreator = oEntityTopic.idUserCreator;
                    myTopic.nmTopic = oEntityTopic.nmTopic;
                   
                }

             
 
                context.SaveChanges();

                returnInsertTopic = myTopic.Id;


            }

            return returnInsertTopic;
        }

        internal EntityTopic SelecionarTopic(int v)
        {
            EntityTopic returnEntityTopic = new EntityTopic();


            using (db4TuneEntities context = new db4TuneEntities())
            {
                var result = context.tbTopics.Where(x => x.Id == v && x.Status == 1).FirstOrDefault();


                if (result!=null)
                {
                    returnEntityTopic.DtCreator =(DateTime) result.DtCreator;
                    returnEntityTopic.id = result.Id;
                    returnEntityTopic.idUserCreator =(int) result.idUserCreator;
                    returnEntityTopic.nmTopic = result.nmTopic;
                    returnEntityTopic.Status = (int) result.Status;
                    



                }

            }


            return returnEntityTopic;
        }

        internal int InsertTopic(EntityTopic oEntityTopic)
        {
            int returnInsertTopic = int.MinValue;

            using (db4TuneEntities context = new db4TuneEntities())
            {
                tbTopic myTopic = new tbTopic();
                myTopic.DtCreator = oEntityTopic.DtCreator;
                myTopic.idUserCreator = oEntityTopic.idUserCreator;
                myTopic.nmTopic = oEntityTopic.nmTopic;
                myTopic.Status = oEntityTopic.Status;

                context.tbTopics.Add(myTopic);
                context.SaveChanges();

                returnInsertTopic = myTopic.Id;


            }

            return returnInsertTopic;
        }
    }
}