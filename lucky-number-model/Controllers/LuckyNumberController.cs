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
        static int _starting_balance = 5; // Initial bank balance

        [HttpGet]
        public ActionResult Spin() // runs the first time the form is loaded
        {
            //Build a default Model with some initial values 
            LuckyNumber myLuck = new LuckyNumber
            {
                Number = 6,
                Balance = _starting_balance,
                GameMessage = ""
        };
            // TODONE: Initialize the spinner fields for the ViewBag to zero
            ViewBag.A = 0;
            ViewBag.B = 0;
            ViewBag.C = 0;
            
            // Pass the Model to the View
            return View(myLuck);
        }

        [HttpPost]
        public ActionResult Spin(LuckyNumber lucky) //The Model is passed in with values from the form submission
        {
            // GAME PLAY : If a spin would cause a negative balance, send the view a "Game Over" message and reset Balance
            if (lucky.Balance <= 0)
            {
                lucky.GameMessage = "GAME OVER: Spin to try again";
                lucky.Balance = _starting_balance;

                // Pass the Model to the View (this ends the method)
                return View(lucky);
            }

            // TODONE: Charge the cost of a spin (subtract 1 from the Balance)
            lucky.Balance -= 1;


            // TODONE: Assign a random value between 1 and 9 to three local variables, a, b, and c
            int a=0, b=0, c=0;
            var randomNumber = new System.Random();
            a = randomNumber.Next(0, 10);
            b = randomNumber.Next(0, 10);
            c = randomNumber.Next(0, 10);


            // TODONE: Assign the ViewBag variables these local variable values
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;

            //Check for a winner, update Balance and the isWinner flag
            if (a== lucky.Number || b == lucky.Number || c == lucky.Number)
            {
                lucky.isWinner = true;
            }

            // Pass the Model to the View
            return View(lucky);
        }

    }
}