using System;
using System.Collections.Generic;
using System.Text;

namespace PairConsoleApp
{
    public class RestaurantRepository
    {
        private List<BurgerRestaurants> _burgerRestaurants = new List<BurgerRestaurants>();
        private List<BurgerRestaurants> _iceCreamRestaurants = new List<BurgerRestaurants>();
        private List<NoBurgerRestaurants> _noBurgerRestaurants = new List<NoBurgerRestaurants>();
        

        public List<BurgerRestaurants> GetBurgerRestaurantsLists()
        {
            return _burgerRestaurants;
        }
        public List<NoBurgerRestaurants> GetNoBurgerRestaurantsList()
        {
            return _noBurgerRestaurants;
        }
        public void SeedRestaurants()
        {                                        
            BurgerRestaurants mcDonalds = new BurgerRestaurants  ("yes", "yes", "yes", "yes", "no", "yes", "yes", "no", "no", "no");
            BurgerRestaurants dairyQueen = new BurgerRestaurants ("yes", "yes", "no", "no", "no", "yes", "no", "no", "yes", "no");
            BurgerRestaurants wendys = new BurgerRestaurants     ("yes", "yes", "yes", "no", "no", "yes", "yes", "no", "no", "no");
            BurgerRestaurants burgerKing = new BurgerRestaurants ("yes", "no", "yes", "no", "no", "yes", "yes", "no", "no", "yes"); 
            BurgerRestaurants sonic = new BurgerRestaurants      ("yes", "yes", "no", "no", "yes", "no", "no", "no", "no", "no");
            BurgerRestaurants fiveGuys = new BurgerRestaurants   ("yes", "no", "no", "no", "no", "yes", "no", "no", "no", "no"); 
            BurgerRestaurants whiteCastle = new BurgerRestaurants("yes", "no", "no", "no", "no", "yes", "yes", "yes", "no", "no"); 
            BurgerRestaurants hardees = new BurgerRestaurants    ("yes", "no", "no", "no", "no", "yes", "yes", "no", "no", "no");
            BurgerRestaurants culvers = new BurgerRestaurants    ("yes", "yes", "no", "no", "no", "yes", "no", "no", "no", "no");

            

            //No burgers
            NoBurgerRestaurants subWay = new NoBurgerRestaurants        ("yes", "no", "yes", "no", "no", "no", "no", "no");
            NoBurgerRestaurants kfc = new NoBurgerRestaurants           ("no", "no", "no", "no", "yes", "no", "no", "no");
            NoBurgerRestaurants tacoBell = new NoBurgerRestaurants      ("no", "yes", "no", "no", "no", "no", "yes", "no");
            NoBurgerRestaurants arbys = new NoBurgerRestaurants         ("no", "no", "no", "no", "no", "no", "no", "no");
            NoBurgerRestaurants chickFilA = new NoBurgerRestaurants     ("no", "no", "no", "no", "yes", "yes", "yes", "no");
            NoBurgerRestaurants starbucks = new NoBurgerRestaurants     ("no", "no", "no", "no", "no", "no", "yes", "no");
            NoBurgerRestaurants pandaExpress = new NoBurgerRestaurants  ("no", "no", "yes", "no", "no", "no", "no", "yes");
            NoBurgerRestaurants chipotle = new NoBurgerRestaurants      ("no", "yes", "yes", "no", "no", "no", "no", "no"); 
            NoBurgerRestaurants jimmyJohns = new NoBurgerRestaurants    ("yes", "no", "no", "no", "no", "no", "no", "no");
            NoBurgerRestaurants qdoba = new NoBurgerRestaurants         ("no", "yes", "yes", "yes", "no", "no", "no", "no");


            _burgerRestaurants.Add(mcDonalds);
            _burgerRestaurants.Add(dairyQueen);
            _burgerRestaurants.Add(wendys);
            _burgerRestaurants.Add(burgerKing);
            _burgerRestaurants.Add(sonic);
            _burgerRestaurants.Add(fiveGuys);
            _burgerRestaurants.Add(whiteCastle);
            _burgerRestaurants.Add(hardees);
            _burgerRestaurants.Add(culvers);

            //No burgers
            _noBurgerRestaurants.Add(subWay);
            _noBurgerRestaurants.Add(kfc);
            _noBurgerRestaurants.Add(tacoBell);
            _noBurgerRestaurants.Add(arbys);
            _noBurgerRestaurants.Add(chickFilA);
            _noBurgerRestaurants.Add(starbucks);
            _noBurgerRestaurants.Add(pandaExpress);
            _noBurgerRestaurants.Add(chipotle);
            _noBurgerRestaurants.Add(jimmyJohns);
            _noBurgerRestaurants.Add(qdoba);
        }

        public BurgerRestaurants GetBurgerRestaurants(string burgers, string iceCream, string nuggets,
            string specialSauce, string corndogs, string indoorSeating, string breakfast,
            string sliders, string mascot)
        {
            foreach (BurgerRestaurants chain in _burgerRestaurants)
            {

                if (chain.Burgers == "yes")
                {
                    if (chain.IceCream == "yes")
                    {
                        if (chain.Nuggets == "yes")
                        {
                            if (chain.SpecialSauce == "yes")
                            {
                                return chain; //Mcdonalds
                            }
                            else
                            {
                              return chain; //Wendy's
                            }
                        }
                        else
                        {
                            if (chain.IndoorSeating == "yes")
                            {
                                if (chain.Cakes == "yes")
                                {
                                    return chain; //DQ
                                }
                                else
                                {
                                    return chain; //Culvers
                                }
                            }
                            else
                            {
                                return chain; //Spnic
                            }
                        }
                    }
                    else
                    {
                        if (chain.Breakfast == "yes")
                        {
                            if (chain.Sliders == "yes")
                            {
                                return chain; //White castle
                            }
                            else
                            {
                                if (chain.Mascot == "yes") //wears crown
                                {
                                    return chain;
                                }
                                else
                                {
                                    return chain; //Hardees
                                }
                            }
                        }
                        else
                        {
                            return chain; // Five guys
                        }
                    }
                }
                else //burgers == no
                {
                    return null;
                }
                
            }
            return null;
        }

        public BurgerRestaurants GetIceCreamRestaurants (string iceCream)
        {
            foreach (BurgerRestaurants chain in _burgerRestaurants)
            {
                if (chain.IceCream == "yes")
                {
                    return chain;
                }
            }
            return null;
        }
        public void AddIceCreamToList(BurgerRestaurants chain)
        {
            _iceCreamRestaurants.Add(chain);

        }
        public NoBurgerRestaurants GetNoBurgerRestaurants(string coldCut, string mexican, string buildYourOwn, string freeQueso, 
            string chickenSandwich, string closedSunday, string servesCoffee, string fortuneCookie)
        {
            foreach (NoBurgerRestaurants chain in _noBurgerRestaurants)
            {
                if (chain.ColdCut == "yes")
                {
                    if (chain.BuildYourOwn == "yes")
                    {
                        return chain; //subway
                    }
                    else
                    {
                        return chain; //jimmy johns
                    }
                }
                else
                {
                    if (chain.Mexican == "yes")
                    {
                        if (chain.BuildYourOwn == "yes")
                        {
                            if (chain.FreeQueso == "yes")
                            {
                                return chain; //qdoba
                            }
                            else
                            {
                                return chain; //chipotle
                            }
                        }
                        else
                        {
                            return chain; //Taco bell
                        }
                    }
                    else
                    {
                        if (chain.ChickenSandwich == "yes")
                        {
                            if (chain.ClosedSunday == "yes")
                            {
                                return chain; //Chick fil a
                            }
                            else
                            {
                                return chain; //KFC
                            }
                        }
                        else
                        {
                            if (chain.ServesCoffee == "yes")
                            {
                                return chain; //starbucks
                            }
                            else
                            {
                                if (chain.FortuneCookie == "yes")
                                {
                                    return chain; //panda
                                }
                                else
                                {
                                    return chain; //arbys
                                }
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
