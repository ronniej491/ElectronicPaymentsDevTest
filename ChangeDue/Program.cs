using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeDue
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal target = Decimal.Round(0.78m);


            //Get the list of bill denominations from class DenominationsBills.cs static method GetDenominations()
            var getBills = (from c in DenominationsBills.GetDenominations()
                             where c.Denomination > target
                             select c).ToList().Take(3);


            //Display option for $3.00 by rounding decimal to nearest integer
            Console.WriteLine(target.ToString("C2"));

            //Loops through each US curency bill from getBills linq statement by greater value and returns next 3 in sequence
            foreach (var item in getBills)
            {
                Console.WriteLine(item.Denomination.ToString("C2"));
            }
        }
    }
}
