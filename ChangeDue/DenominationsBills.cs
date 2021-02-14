using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeDue
{

    public class Denominations
    {
        public int Denomination { get; set; }
    }
    public class DenominationsBills
    {

        //Generic list for bill Denominations
        public static List<Denominations> GetDenominations() { 
        List<Denominations> denominations = new List<Denominations>()
                {
                  new Denominations() {Denomination = 1},
                  new Denominations() {Denomination = 2},
                  new Denominations() {Denomination = 5},
                  new Denominations() {Denomination = 10},
                  new Denominations() {Denomination = 20},
                  new Denominations() {Denomination = 50},
                  new Denominations() {Denomination = 100},

                };

            return denominations;
        }
    }
}
