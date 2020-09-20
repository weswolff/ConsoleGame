using System;
using System.Collections.Generic;
using System.Text;

namespace PairConsoleApp
{
    public class NoBurgerRestaurants
    {
        public string ColdCut { get; set; }
        public string Mexican { get; set; }
        public string BuildYourOwn { get; set; }
        public string FreeQueso { get; set; }
        public string ChickenSandwich { get; set; }
        public string ClosedSunday { get; set; }
        public string ServesCoffee { get; set; }
        public string FortuneCookie { get; set; }

        public NoBurgerRestaurants()
        {
          
        }
        public NoBurgerRestaurants(string coldCut, string mexican, string buildYourOwn, string freeQueso,
            string chickenSandwich, string closedSunday, string servesCoffee, string fortuneCookie)
        {
            ColdCut = coldCut;
            Mexican = mexican;
            BuildYourOwn = buildYourOwn;
            FreeQueso = freeQueso;
            ChickenSandwich = chickenSandwich;
            ClosedSunday = closedSunday;
            ServesCoffee = servesCoffee;
            FortuneCookie = fortuneCookie;
        }
    }
}
