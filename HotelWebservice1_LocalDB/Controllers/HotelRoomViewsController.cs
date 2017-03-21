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
    public class HotelRoomViewsController : ApiController
    {
        private HotelViewContext db = new HotelViewContext();

        // GET: api/HotelRoomViews
        public IQueryable<HotelRoomView> GetHotelRoomView()
        {
            return db.HotelRoomView;
        }

        // GET: api/HotelRoomViews/5
        [ResponseType(typeof(HotelRoomView))]
        public IHttpActionResult GetHotelRoomView(int id)
        {
            HotelRoomView hotelRoomView = db.HotelRoomView.Find(id);
            if (hotelRoomView == null)
            {
                return NotFound();
            }

            return Ok(hotelRoomView);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelRoomViewExists(int id)
        {
            return db.HotelRoomView.Count(e => e.Hotel_No == id) > 0;
        }
    }
}