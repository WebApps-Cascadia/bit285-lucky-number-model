using lucky_number_model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lucky_number_model.Controllers
{
    public class LuckyNumberController : Controller
    {
        [HttpGet]
        public ActionResult Spin() // runs the first time the form is loaded
        {
            //Build a default Model with some initial values 
            LuckyNumber myLuck = new LuckyNumber
            {
                Number = 6,
                Balance = 4
            };

            // TODO: Initialize the spinner fields for the ViewBag to zero
            myLuck.Spinner[0] = 0;
            myLuck.Spinner[1] = 0;
            myLuck.Spinner[2] = 0;

            // Pass the Model to the View
            return View(myLuck);
        }

        [HttpPost]
        public ActionResult Spin(LuckyNumber lucky) //The Model is passed in with values from the form submission
        {
                return View(lucky);
        }

    }
}