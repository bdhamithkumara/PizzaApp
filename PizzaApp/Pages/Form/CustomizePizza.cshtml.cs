using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaApp.Models;

namespace PizzaApp.Pages.Form
{
    public class CustomizePizzaModel : PageModel
    {
        [BindProperty]
        public pizzamodel Pizza { get; set; }

        public float PizzaPrice { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSaurce) PizzaPrice += 2;

            if (Pizza.Cheese) PizzaPrice += 2;

            if (Pizza.Peperoni) PizzaPrice += 2;

            if (Pizza.Mushroom) PizzaPrice += 2;

            if (Pizza.Tuna) PizzaPrice += 2;

            if (Pizza.Pineapple) PizzaPrice += 2;

            if (Pizza.Ham) PizzaPrice += 2;

            if (Pizza.Beef) PizzaPrice += 2;

            return RedirectToPage("/Checkout/Thankyou", new { Pizza.pizaaname, PizzaPrice });
        }
    }
}
