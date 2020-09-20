using System;
using System.Collections.Generic;
using System.Text;

namespace PairConsoleApp
{
    public class BurgerRestaurants
    {
        public string Burgers { get; set; }
        public string IceCream { get; set; }
        public string Nuggets { get; set; }
        public string SpecialSauce { get; set; }
        public string Corndogs { get; set; }
        public string IndoorSeating { get; set; }
        public string Breakfast { get; set; }
        public string Sliders { get; set; }
        public string Cakes { get; set; }
        public string Mascot { get; set; }
        public BurgerRestaurants() { }
        public BurgerRestaurants(string burgers, string iceCream, string nuggets, 
            string specialSauce, string corndogs, string indoorSeating, string breakfast, 
            string sliders, string cakes, string mascot)
        {
            Burgers = burgers;
            IceCream = iceCream;
            Nuggets = nuggets;
            SpecialSauce = specialSauce;
            Corndogs = corndogs;
            IndoorSeating = indoorSeating;
            Breakfast = breakfast;
            Sliders = sliders;
            Cakes = cakes;
            Mascot = mascot;
        }
    }
}
