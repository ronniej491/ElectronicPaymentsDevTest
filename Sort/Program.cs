using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {





            //Get the sizes of the pizza from pizza class and show in console
            Console.WriteLine(Pizza.GetNewOrder().Size);

            //Sort and group pizza by sides and show in console
            foreach (var g in Pizza.GetNewOrder().Sides.GroupBy(x => x.Side))
            {
                Console.WriteLine($"{g.Key}");
                foreach (var s in g)
                {
                    Console.WriteLine(s.Topping);
                }
               
               
                
            }

           

        }
}

   
}
