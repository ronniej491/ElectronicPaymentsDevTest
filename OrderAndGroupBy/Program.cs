using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderAndGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {

            //Get the list of paymemts from class payment.cs static method GetPayments() selecting into new group object
            var payments = from paymemt in Payment.GetPayments()
                           orderby paymemt.OrderID ascending
                           group paymemt by paymemt.OrderID into g
                           select new
                           {
                               OrderID = g.Key,
                               Cash = g.Where(c => c.Type == "Cash" ).Sum( s => s.Value),
                               Credit = g.Where(c => c.Type == "Credit").Sum(s => s.Value),
                               Debit = g.Where(c => c.Type == "Debit").Sum(s => s.Value)
                           };


            //String to show outline line in console
            Console.WriteLine("Output");

            //Placeholders to payment colum in console
            Console.WriteLine(
                String.Format("{0,9} {1,9} {2,18} {3,18}", "", "Cash", "Credit", "Debit"));


            //Loop through each payment colum in and display in coulum in console
            foreach (var item in payments)
            {
                Console
                    .WriteLine(
                    String.Format("{0,9} {1,15:0.00} {2,15:0.00} {3,15:0.00}", 
                    item.OrderID, 
                    Convert.ToDecimal(item.Cash), Convert.ToDecimal(item.Credit), Convert.ToDecimal(item.Debit)));

          

          
            }

          
            
            
            
       
        }

      
    }
}
