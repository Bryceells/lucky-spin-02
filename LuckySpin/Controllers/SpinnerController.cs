using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
//Gives access to the Model classes in the Controller
using LuckySpin.Models;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        public IActionResult Index(int luck) 
        {
            Random random = new Random();

            //Creates a new spin object from the Model class Spin
            Spin spin = new Spin
            {
                //TODO: assign properties Luck and Numbers, appropriate values in the constructor
                Luck = luck,
                Numbers = new int[]
                {
                    random.Next(1, 10),
                    random.Next(1, 10),
                    random.Next(1, 10)
                },
                ImageDisplay = "none"
            };

            //TODO: Use a conditional to assign spin's ImageShown property a CSS display value of "block" if the lucky number is in the Numbers array
            if (spin.Numbers.Contains(spin.Luck))
            {
                spin.ImageDisplay = "block";
            }

            return View(spin); //Passes the spin object to the View as a parameter
        }
    }
}