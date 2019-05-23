using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FurnitureDataAccess;

namespace FurnitureDeals.Controllers
{
    public class FurnituresController : ApiController
    {
        public IEnumerable<Furniture> Get()
        {
            using (FurnitureEntities entities = new FurnitureEntities())
            {
                return entities.Furnitures.ToList();
            }
        }

        public HttpResponseMessage Get(int id)
        {
            using (FurnitureEntities entities = new FurnitureEntities())
            {
                var entity = entities.Furnitures.FirstOrDefault(f => f.id == id);

                if (entity != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entity);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Furniture with id = " + id.ToString() + " was not found");
                }
            }
        }

        public HttpResponseMessage Post([FromBody] Furniture furniture)
        {
            try
            {
                using (FurnitureEntities entities = new FurnitureEntities())
                {
                    entities.Furnitures.Add(furniture);
                    entities.SaveChanges();

                    var message = Request.CreateResponse(HttpStatusCode.Created, furniture);
                    message.Headers.Location = new Uri(Request.RequestUri + furniture.id.ToString());
                    return message;
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (FurnitureEntities entities = new FurnitureEntities())
                {
                    var entity = entities.Furnitures.FirstOrDefault(f => f.id == id);
                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Furniture with id = " + id.ToString() + " was not found to be deleted");
                    }
                    else
                    {
                        entities.Furnitures.Remove(entity);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        public HttpResponseMessage Put(int id, [FromBody]Furniture furniture)
        {
            try
            {
                using (FurnitureEntities entities = new FurnitureEntities())
                {
                    var entity = entities.Furnitures.FirstOrDefault(f => f.id == id);

                    if (entity == null)
                    {
                        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Furniture with id = " + id.ToString() + " was not found to be updated");
                    }
                    else
                    {
                        entity.namefurniture = furniture.namefurniture;
                        entity.descriptionfurniture = furniture.descriptionfurniture;
                        entity.typefurniture = furniture.typefurniture;
                        entity.price = furniture.price;
                        entity.seller = furniture.seller;
                        entity.nrofproducts = furniture.nrofproducts;

                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, entity);
                    }

                }
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
