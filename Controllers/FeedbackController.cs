using System;
using System.Collections.Generic;
using System.Web.Mvc;
using pr7.Models;
namespace pr7.Controllers
{
    public class FeedbackController : Controller
    {
        // Store feedback temporarily
        private static List<Feedback> feedbackList = new List<Feedback>();

        // Main Page
        public ActionResult Index()
        {
            return View();
        }

        // Give Feedback Page
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // Submit Feedback
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);

                TempData["Message"] = "Feedback submitted successfully!";

                return RedirectToAction("ViewFeedback");
            }

            return View(feedback);
        }

        // View Feedback Page
        public ActionResult ViewFeedback()
        {
            return View(feedbackList);
        }
    }
}