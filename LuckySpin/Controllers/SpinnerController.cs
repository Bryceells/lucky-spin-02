using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
//TODO: import the LuckySpin.Models namespace into the Controller with a "using" command
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        public IActionResult Index(int luck) 
        {
            Random random = new Random();

            //Create a new spin object from the Model class Spin
            Spin spin = new Spin
            {
                //TODO: assign its properties, Luck and Numbers, appropriate values in the constructor
                Luck = luck,
                Numbers = new int[] { random.Next(1, 9), random.Next(1, 9), random.Next(1, 9) }
            };

            //TODO: Use the if-else to assign spin's ImageShown property a CSS display value (either "block" or "none")
            if (Array.Exists(spin.Numbers, n => n == luck))
                spin.ImageDisplay = "block"; 
            else
                spin.ImageDisplay = "none";

            return View( spin ); //Pass the spin object to the View as a parameter
        }
    }
}