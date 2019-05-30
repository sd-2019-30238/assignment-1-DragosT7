using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class FurnitureController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Furniture
        public IQueryable<Furniture> GetFurnitures()
        {
            return db.Furnitures;
        }

        // GET: api/Furniture/5
        [ResponseType(typeof(Furniture))]
        public IHttpActionResult GetFurniture(int id)
        {
            Furniture furniture = db.Furnitures.Find(id);
            if (furniture == null)
            {
                return NotFound();
            }

            return Ok(furniture);
        }

        // PUT: api/Furniture/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFurniture(int id, Furniture furniture)
        {

            if (id != furniture.id)
            {
                return BadRequest();
            }

            db.Entry(furniture).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FurnitureExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Furniture
        [ResponseType(typeof(Furniture))]
        public IHttpActionResult PostFurniture(Furniture furniture)
        {

            db.Furnitures.Add(furniture);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = furniture.id }, furniture);
        }

        // DELETE: api/Furniture/5
        [ResponseType(typeof(Furniture))]
        public IHttpActionResult DeleteFurniture(int id)
        {
            Furniture furniture = db.Furnitures.Find(id);
            if (furniture == null)
            {
                return NotFound();
            }

            db.Furnitures.Remove(furniture);
            db.SaveChanges();

            return Ok(furniture);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FurnitureExists(int id)
        {
            return db.Furnitures.Count(e => e.id == id) > 0;
        }
    }
}