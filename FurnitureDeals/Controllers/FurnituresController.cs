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

        public Furniture Get(int id)
        {
            using (FurnitureEntities entities = new FurnitureEntities())
            {
                return entities.Furnitures.FirstOrDefault(f => f.id == id);
            }
        }
    }
}
