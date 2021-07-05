using System;
using System.Collections.Generic;
using System.Text;

namespace Avcol_Bus_Scheduler
{
    class Route
    {
        public void Allbusroutes()
        {
            Start:
            Console.WriteLine("You could search for any School bus route to see more information and routes.");
            Console.WriteLine("School bus routes in the morning:\n\n Starting route and end of route of school busses in the morning display\n 015 Glendene - Tirimoana Rd. to Avondale College\n 053 Parrs Park - 108 Parrs Cross Rd. to Avondale College\n 056 Forest Hill - Opp 125 Forest Hill Rd. to Avondale College\n 072 Titirangi Village - Titirangi Village to Avondale College\n");
           
            Console.WriteLine("School bus routes in the afternoon:\n\n Starting route and end of route of the school busses in the afternoon display\n 012 New Lynn - Avondale College Bus bay to New Lynn interchange\n 015 Glendene - Avondale College Bus bay to Te Atatu Rd.\n 053 Parrs Park - Avondale College Bus bay to Parrs Cross Rd.\n 056 Forest Hill - Avodale College Bus bay to Forest Hill Rd.\n 072 Titirangi Village - Avondale College Bus bay to Titirangi Village");
            Console.WriteLine("Search:");
            string UserSearchRoutes = string.Format(Console.ReadLine());
            Console.WriteLine(UserSearchRoutes);
            if (UserSearchRoutes == "New Lynn")
            {
                Console.Clear();
                Console.WriteLine("'Afternoon only'- Avondale College Bus Bay, Rosebank Rd, Great North Rd, Veronica St, Totara Ave, Stop D New Lynn Interchange");
            }
            else if (UserSearchRoutes == "Glendene")
            {
                Console.Clear();
                Console.WriteLine("Morning - 2 Tirimoana Rd, Glendene Avenue, Farquhar Rd, Phelps Place, Hepburn Rd, Butterworth Dr, Sabulite Rd, St Leonards Rd, Archibald Rd, Archlynn Rd, Kelwyn Rd, Rimu St, Lynwood Rd, Nikau St, Rimu St, Rata St, Ash St, Rosebank Rd, Aspen Rd, Victor St, Avondale College.");
            }
            else if (UserSearchRoutes == "Parrs Park ")
            {
                Console.Clear();
                Console.WriteLine("Morning - From 108 Parrs Cross Rd, West Coast, Rosier, Glengarry, Nandana, Kashmir, Withers, Glendale, West Coast, Great North, Rata, Ash, Rosebank, Aspen, Victor, Avondale College");
            }
            else if (UserSearchRoutes == "Forest Hill")
            {
                Console.Clear();
                Console.WriteLine("Morning - Opp 125 Forest Hill Rd, Forest Hill Rd, West Coast Rd, Sunvue Rd, Solar Rd, Glengarry Rd, Nandana Dr, Kashmir Rd, Withers Rd, Glendale Rd, West Coast Rd, Great North Rd, Rata St, Ash St, Rosebank Rd, Aspen St, Victor St, Avondale College Bus Bay. ");
            }
            else if (UserSearchRoutes == "Titirangi Village")
            {
                Console.Clear();
                Console.WriteLine(" Morning - Titirangi Village, Titirangi, Rata, Ash, Rosebank, Aspen, Victor, Avondale College.");
            }
            else if (UserSearchRoutes == "2")
            {
                //User returns to the menu.
            }
            switch (UserSearchRoutes)
            {
                case "New Lynn":
                    Console.WriteLine("New Lynn School bus only afternoon");
                    string UserSearchReturn = Console.ReadLine();
                    switch (UserSearchReturn)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village");
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Main Menu/ Press Enter to see the list again");
                            Console.ReadLine();
                            Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                            break;
                    }
                    break;
                case "Glendene":
                    Console.WriteLine("Afternoon - Avondale College, Victor St, Rosebank Rd, Riversdale Rd, Wairau Ave, Ash St, Rata St, Rimu St, Nikau St, Lynwood Rd, Rimu St, Kelwyn Rd, Archlynn Rd, Archibald Rd, St Leonards Rd, Sabulite Rd, Butterworth Dr, Hepburn Rd, Phelps Pl, Farquhar Rd, Glendene Ave, Tirimoana Rd, Te Atatu Rd. ");
                    string UserSearchesReturn = Console.ReadLine();
                    switch (UserSearchesReturn)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village");
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Main Menu/ Press Enter to see the list again");
                            Console.ReadLine();
                            Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                            break;
                    }
                    break;
                case "Parrs Park":
                    Console.WriteLine("Afternoon - 	Avondale College, Rosebank, Ash, Rata, Great North, West Coast, Glendale Rd, Withers, Kashmir, Nandana, Glengarry, Rosier, West Coast, Parrs Cross, last stop opposite 106 Parrs Cross Rd.");
                    string UsersSearchesReturn = Console.ReadLine();
                    switch (UsersSearchesReturn)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village");
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Main Menu/ Press Enter to see the list again");
                            Console.ReadLine();
                            Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                            break;
                    }
                    break;
                case "Forest Hill":
                    Console.WriteLine("Afternoon - 	Avondale College Bus Bay, Rosebank Rd, Ash St, Rata St, Great North Rd, West Coast Rd, Glendale Rd, Withers Rd, Kashmir Rd, Nandana Dr, Glengarry Rd, Solar Rd, Libra Rd, Sunvue Rd, West Coast Rd, Forest Hill Rd, 119 Forest Hill Rd.");
                    string UserSearchReturns = Console.ReadLine();
                    switch (UserSearchReturns)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village");
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Main Menu/ Press Enter to see the list again");
                            Console.ReadLine();
                            Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                            break;
                    }
                    break;
                case "Titirangi Village":
                    Console.WriteLine("Afternoon - Avondale College, Rosebank, Ash, Rata, Titirangi, Titirangi Village.");
                    string UserReturnSearch = Console.ReadLine();
                    switch (UserReturnSearch)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village");
                            break;
                        case "b":
                            Console.Clear();
                            Console.WriteLine("Main Menu/ Press Enter to see the list again");
                            Console.ReadLine();
                            Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                            break;
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                    break;
                default:
                    Console.WriteLine("Your choice is invalid (Press Enter to try again)", UserSearchRoutes);
                    Console.ReadLine();
                    goto Start;
            } 
        }
    }
}
