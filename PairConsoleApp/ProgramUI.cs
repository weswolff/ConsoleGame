using System;
using System.Collections.Generic;
using System.Text;

namespace PairConsoleApp
{
    public class ProgramUI
    {
        private RestaurantRepository _chainRepo = new RestaurantRepository();

        public void Run()
        {
            _chainRepo.SeedRestaurants();
            Console.Clear();
            Console.WriteLine("I'm ready to guess your favorite fast food restaurant.");

            //need to create an exit for loop
            //each answer needs to pull from repository for scalibilty

            
            bool guessing = true;
            while (guessing)
            {
                //BurgerRestaurants chain = _chainRepo.GetBurgerRestaurants(burgers);
                Console.Clear();
                Console.WriteLine("Does this restaurant serve burgers? Enter yes/no: ");
                string initialResponse = Console.ReadLine().ToLower();
                if (initialResponse.StartsWith("yes"))
                {

                    Console.WriteLine("Does this restuarant serve ice cream? Enter yes/no: ");
                    string iceCreamResponse = Console.ReadLine().ToLower();
                    if (iceCreamResponse.StartsWith("yes"))
                    {
                        Console.WriteLine("Does this restuarant serve chicken nuggets? Enter yes/no: ");
                        string nuggetResponse = Console.ReadLine().ToLower();
                        if (nuggetResponse.StartsWith("yes"))
                        {
                            Console.WriteLine("Does this restuarant have its own special sauce? Enter yes/no: ");
                            string sauceResponse = Console.ReadLine().ToLower();
                            if (sauceResponse.StartsWith("yes"))
                            {
                                //McDonalds
                            }
                            else
                            {
                                //Wendy's
                            }
                        }
                        else
                        {
                            Console.WriteLine("Does this restaurant have indoor seating? Enter yes/no: ");
                            string indoorResponse = Console.ReadLine().ToLower();
                            if (indoorResponse.StartsWith("yes"))
                            {

                                Console.WriteLine("Does this restaurant sell cakes? Enter yes/no: ");
                                string cakeResponse = Console.ReadLine().ToLower();
                                if (cakeResponse.StartsWith("yes"))
                                {
                                    //Dairy Queen
                                }
                                else
                                {
                                    //culvers
                                }
                            }
                            else
                            {
                                //Sonic
                            }
                        }
         
                    }
                    else
                    {
                        Console.WriteLine("Does this restuarant serve breakfast? Enter yes/no: ");
                        string breakfastResponse = Console.ReadLine().ToLower();
                        if (breakfastResponse.StartsWith("yes"))
                        {
                            Console.WriteLine("Does this restuarant serve sliders? Enter yes/no: ");
                            string sliderResponse = Console.ReadLine().ToLower();
                            if (sliderResponse.StartsWith("yes"))
                            {
                                //White castle
                            }
                            else
                            {
                                Console.WriteLine("Does the mascot wear a crown? Enter yes/no: ");
                                string mascotResponse = Console.ReadLine().ToLower();
                                if (mascotResponse.StartsWith("yes"))
                                {
                                    //burger king
                                }
                                else
                                {
                                    //hardees
                                }
                            }
                        }
                        else
                        {
                            //Five guys
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Does this restaurant serve cold cut sandwiches? Enter yes/no: ");
                    string coldCutResponse = Console.ReadLine().ToLower();
                    if (coldCutResponse.StartsWith("yes"))
                    {
                        Console.WriteLine("Can you build your own sandwich at this restuarant? Enter yes/no: ");
                        string sandBuildResponse = Console.ReadLine().ToLower();
                        if (sandBuildResponse.StartsWith("yes"))
                        {
                            //Subway
                        }
                        else
                        {
                            //Jimmy Johns
                        }
                    }
                    else
                    {
                        Console.WriteLine("Is this a mexican restaurant? Enter yes/no: ");
                        string mexicanRestuarant = Console.ReadLine().ToLower();
                        if (mexicanRestuarant.StartsWith("yes"))
                        {
                            Console.WriteLine("Can you build your own meal at this restuarant? Enter yes/no: ");
                            string mexBuildResponse = Console.ReadLine().ToLower();
                            if (mexBuildResponse.StartsWith("yes"))
                            {
                                Console.WriteLine("Does this restuarant have free queso? Enter yes/no: ");
                                string freeQueso = Console.ReadLine().ToLower();
                                if (freeQueso.StartsWith("yes"))
                                {
                                    Console.WriteLine("My guess is Qdoba.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    //chipotle
                                }
                            }
                            else
                            {
                                //taco bell
                            }
                        }
                        else
                        {
                            Console.WriteLine("Does this restuarant have chicken sandwiches? Enter yes/no: ");
                            string chickenSandwiches = Console.ReadLine().ToLower();
                            if (chickenSandwiches.StartsWith("yes"))
                            {
                                Console.WriteLine("Is this restuarant closed on Sundays?");
                                string closedSunday = Console.ReadLine().ToLower();
                                if (closedSunday.StartsWith("yes"))
                                {
                                    //Chick fil a
                                }
                                else
                                {
                                    //KFC
                                }
                            }
                            else
                            {
                                Console.WriteLine("Do they serve coffee? Enter yes/no: ");
                                string coffeeShop = Console.ReadLine().ToLower();
                                if (coffeeShop.StartsWith("yes"))
                                {
                                    //starbucks
                                }
                                else
                                {
                                    Console.WriteLine("Do you get a fortune cookie at this restuarant? Enter yes/no: ");
                                    string fortuneCookie = Console.ReadLine().ToLower();
                                    if (fortuneCookie.StartsWith("yes"))
                                    {
                                        //Panda
                                    }
                                    else
                                    {
                                        //Arby's
                                    }
                                }
                            }
                        }
                    }
                }
                
            }
        }
    }
}
