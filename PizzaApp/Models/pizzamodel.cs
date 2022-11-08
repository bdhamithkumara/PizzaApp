using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaApp.Models
{
    public class pizzamodel
    {
        public string pizaaname { get; set; }

        public bool TomatoSaurce { get; set; }

        public bool Cheese { get; set; }

        public bool Peperoni { get; set; }

        public bool Mushroom { get; set; }

        public bool Tuna { get; set; }

        public bool Pineapple { get; set; }

        public bool Ham { get; set; }

        public bool Beef { get; set; }

        public float BasePrice { get; set; } = 10;

    }
}
