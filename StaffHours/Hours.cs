using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaffHours
{
    //class sets property and generic list for hours worked
    public class Hours
    {
        public int StaffID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        //method returns hours worked
        public static List<Hours> GetHours(GetStaffHours staff)
        {
            List<Hours> staffHours = new List<Hours>()
                {
                  new Hours() {StaffID = 2,   StartDate = "8/8/18 7:00 AM",   EndDate = "8/8/18 1:00 PM"},
                  new Hours() {StaffID = 2,   StartDate = "8/9/18 10:00 AM",  EndDate = "8/9/18 6:00 PM "},
                  new Hours() {StaffID = 2,   StartDate = "8/10/18 8:00 AM",  EndDate = "8/10/18 2:00 PM" },

                };

            

            return staffHours;
        }
    }

    //class sets property and generic list for hours Staff
    public class GetStaffHours
    {
        public int StaffID { get; set; }
        public string StaffName { get; set; }

        //method returns Staff and hours
        public static List<Hours> GetStaff()
        {
            List<GetStaffHours> staffList = new List<GetStaffHours>()
                {
                  new GetStaffHours() {StaffID = 1,   StaffName = "Admin"},
                  new GetStaffHours() {StaffID = 2,   StaffName = "Peter"},

                };

            var selectedStaff = staffList.Where(s => s.StaffID == 2).FirstOrDefault();

         


            return Hours.GetHours(selectedStaff);
        }
    }

}

