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
using HotelWebservice1_LocalDB;

namespace HotelWebservice1_LocalDB.Controllers
{
    public class GuestBookRsController : ApiController
    {
        private GuestBookRoomViewContext db = new GuestBookRoomViewContext();

        // GET: api/GuestBookRs
        public IQueryable<GuestBookR> GetGuestBookR()
        {
            return db.GuestBookR;
        }

        // GET: api/GuestBookRs/5
        [ResponseType(typeof(GuestBookR))]
        public IHttpActionResult GetGuestBookR(int id)
        {
            GuestBookR guestBookR = db.GuestBookR.Find(id);
            if (guestBookR == null)
            {
                return NotFound();
            }

            return Ok(guestBookR);
        }

        //// PUT: api/GuestBookRs/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutGuestBookR(int id, GuestBookR guestBookR)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != guestBookR.Guest_No)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(guestBookR).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!GuestBookRExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/GuestBookRs
        //[ResponseType(typeof(GuestBookR))]
        //public IHttpActionResult PostGuestBookR(GuestBookR guestBookR)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.GuestBookR.Add(guestBookR);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (GuestBookRExists(guestBookR.Guest_No))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = guestBookR.Guest_No }, guestBookR);
        //}

        //// DELETE: api/GuestBookRs/5
        //[ResponseType(typeof(GuestBookR))]
        //public IHttpActionResult DeleteGuestBookR(int id)
        //{
        //    GuestBookR guestBookR = db.GuestBookR.Find(id);
        //    if (guestBookR == null)
        //    {
        //        return NotFound();
        //    }

        //    db.GuestBookR.Remove(guestBookR);
        //    db.SaveChanges();

        //    return Ok(guestBookR);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GuestBookRExists(int id)
        {
            return db.GuestBookR.Count(e => e.Guest_No == id) > 0;
        }
    }
}