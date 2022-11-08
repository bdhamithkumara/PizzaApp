using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaApp.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class ThankyouModel : PageModel
    {
        public string pizaaname { get; set; }

        public float PizzaPrice { get; set; }
        
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(pizaaname))
            {
                pizaaname = "";
            }
        }
    }
}
