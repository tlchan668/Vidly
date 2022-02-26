﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            //passing data by viewData Dictionary !!!Don't Do!!!
            //ViewData["Movie"] = movie;
            //ViewBag["Movie"] 
            return View(movie);
            
            //return new ViewResult();
            //return Content("Hello World!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12) }")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit (int id) {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy) {
            if(!pageIndex.HasValue)
                pageIndex = 1;

            if(String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortyBy={1}", pageIndex, sortBy));
        }
    }
}