using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    //class porperty for get; set;  Sides  for pizza
    public class Sides
    {
        public string Side { get; set; }
        public string Topping { get; set; }
    }

    //Class for setting input value for pizza
    public class Pizza
    {
        public string Size { get; set; }
        public List<Sides> Sides { get; set; }


        public static Pizza GetNewOrder()
        {
            var pizza = new Pizza();
            pizza.Size = "16 Inch Pizza";
            pizza.Sides = GetAll();

            return pizza;

        }

        //Generic list  for pizza sides
        public static List<Sides> GetAll()
        {
            
            List<Sides> sides = new List<Sides>()
            {
            new Sides() { Side = "LeftSide", Topping = "Cheese" },
            new Sides() { Side = "LeftSide", Topping = "Onion" },
            new Sides() { Side = "RightSide", Topping = "Pepperoni" },
            new Sides() { Side = "RightSide", Topping = "Green Pepper" },
            new Sides() { Side = "LeftSide", Topping = "Anchovies" },
            new Sides() { Side = "RightSide", Topping = "Salami" },
            };

            return sides;

        }
    }


   

}
