using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAndGroupBy
{
    //class sets property for OrderID
    public class Orders
    {
        public int OrderID { get; set; }
    }

    //class sets property and generic list for Payment
    public class Payment
    {
        public int OrderID { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }


        //method returns Payments
        public static List<Payment> GetPayments()
        {

            List<Payment> sides = new List<Payment>()
                {
                  new Payment() {OrderID = 1,   Type = "Cash",    Value = 10.00m},
                  new Payment() {OrderID = 1,   Type = "Credit",  Value = 25.00m},
                  new Payment() {OrderID = 1,   Type = "Debit",  Value = 8.50m},
                  new Payment() {OrderID = 2,   Type = "Credit",  Value = 6.75m},
                  new Payment() {OrderID = 2,   Type = "Debit",  Value = 4.25m},
                  new Payment() {OrderID = 3,   Type = "Cash",  Value = 7.80m},
                  new Payment() {OrderID = 4,   Type = "Credit",  Value = 15.20m},
                  new Payment() {OrderID = 4,   Type = "Credit",  Value = 10.80m},
                  new Payment() {OrderID = 5,   Type = "Cash",  Value = 4.21m},
                  new Payment() {OrderID = 6,   Type = "Cash",  Value = 5.00m},
                  new Payment() {OrderID = 6,   Type = "Cash",  Value = 10.00m},
                  new Payment() {OrderID = 6,   Type = "Credit",  Value = 15.00m }
            };




            return sides;

        }

    }

}
