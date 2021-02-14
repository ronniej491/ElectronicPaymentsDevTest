using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace StaffHours
{
    class Program
    {
        //Method to display colum for week of 5-11 and show in console
        static void DisplayDaysOfWeek(string[] arr) => 
            Console.WriteLine($"{"Staff hours", -1}{arr[0], 10}{arr[1],10}{arr[2],10}{arr[3],10}{arr[4],10}{arr[5],10}{arr[6],10}");

        //Method to display Peter hours work for the week of 5-11 and show in console
        static void DisplayHoursWorked(string[] arr) => 
            Console.WriteLine($"{"Peter     ", -1}{arr[0], 10}{arr[1], 10}{arr[2], 10}{arr[3], 10}{arr[4], 10}{arr[5], 10}{arr[6], 10}");
        static void Main(string[] args)
        {
            //Method to display colum week for August 5 to 11
            Console.WriteLine("August 5 to 11");

            //Gets the date for week August 5 to 11 2018
            DateTime dt2 = new DateTime(2018, 08, 05);


            //Iterate through days for week of August 5 to 11 and convert days to string format short spelling of day and numeric day of week
            var result = Enumerable.Range(0, 7).Select(i => dt2.AddDays(i).ToString("ddd d"));


            //Display colum for week of 5-11 and show in console
            DisplayDaysOfWeek(result.ToArray());

            //Generic list of string to hold values for dates of the week of August 5 to 11 2018 and hous worked
            List<string> daysWorked = new List<string>();

            //Iterate through days for week of August 5 to 11
            foreach (var item in Enumerable.Range(0, 7).Select(i => dt2.AddDays(i).ToString()))
            {
                //Method that gets hours worked for in hours.cs GetStaff() method parse date to get matching date
                var viewHours = GetStaffHours.GetStaff().Where(d => DateTime.Parse(d.StartDate).Date == DateTime.Parse(item).Date).FirstOrDefault();

                //If a date is found add to Generic list of string daysWorked
                if (viewHours != null)
                {
                    //Subtract timespan from EndDate - StartDate to get positive hours worked for that day
                    TimeSpan duration = DateTime.Parse(viewHours.EndDate).Subtract(DateTime.Parse(viewHours.StartDate));
       
                    //Add hours to list
                    daysWorked.Add($"{duration.Hours}");
                    
                }

                else
                {
                    //Else the day was not found to have startdate set - for no hours found
                    daysWorked.Add($"-");
                }
             

            }


            //Display Peter hours work for the week of 5-11 and show in console
            DisplayHoursWorked(daysWorked.ToArray());


        }
    }
}
