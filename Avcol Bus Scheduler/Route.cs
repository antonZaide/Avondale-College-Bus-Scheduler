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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\tSchool Bus Routes\t\t\t");//User can leave any time by pressing 2 again in the bus routes table.
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 2 again to'Exit'\n");
            //The User can search for any school bus route that is already being shown to them.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You could search for any School bus route to see more information and routes.\n");
            //The school bus routes in the morning from starting to end has been displayed for the user.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("School bus routes in the morning:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Starting location and end of route of school busses in the morning.\n\n Location: Glendene 015 - Tirimoana Rd. to Avondale College\n\n Location: Parrs Park 053 - 108 Parrs Cross Rd. to Avondale College\n\n Location: Forest Hill 056 - Opp 125 Forest Hill Rd. to Avondale College\n\n Location: Titirangi Village 072 - Titirangi Village to Avondale College\n");
            //The school bus routes in the afternoon from starting to end has also been displayed for the user.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("School bus routes in the afternoon:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Starting location and end of route of the school busses in the afternoon.\n\n Location: New Lynn 012 - Avondale College Bus bay to New Lynn interchange\n\n Location: Glendene 015 - Avondale College Bus bay to Te Atatu Rd.\n\n Location: Parrs Park 053 - Avondale College Bus bay to Parrs Cross Rd.\n\n Location: Forest Hill 056 - Avodale College Bus bay to Forest Hill Rd.\n\n Location: Titirangi Village 072 - Avondale College Bus bay to Titirangi Village\n");
        Search:
            //if User searches any bus routes > the full school bus routes in the morning and the afternoon will be displayed.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Search: Type the bus location in order to see the full school bus routes.");
            Console.ForegroundColor = ConsoleColor.White;
            string UserSearchRoutes = string.Format(Console.ReadLine());
            Console.WriteLine(UserSearchRoutes);
            if (UserSearchRoutes == "New Lynn")
            {
                // The console.clear makes it easier for the user to see what they searched because it clears everything excepect for what route they searched.
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press A to search for another bus route or B to go back to the school bus routes display\n ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("'Afternoon only'- Avondale College Bus Bay, Rosebank Rd, Great North Rd,\n Veronica St, Totara Ave, Stop D New Lynn Interchange - bus routes end\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (UserSearchRoutes == "Glendene")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press A to search for another bus route or B to go back to the school bus routes display\n ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Morning - 2 Tirimoana Rd, Glendene Avenue, Farquhar Rd, Phelps Place, Hepburn Rd, Butterworth Dr, Sabulite Rd,\n St Leonards Rd, Archibald Rd, Archlynn Rd, Kelwyn Rd, Rimu St, Lynwood Rd, Nikau St, Rimu St, Rata St,\n Ash St, Rosebank Rd, Aspen Rd, Victor St, Avondale College.\n\n");
            }
            else if (UserSearchRoutes == "Parrs Park")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press A to search for another bus route or B to go back to the school bus routes display\n ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Morning - From 108 Parrs Cross Rd, West Coast, Rosier, Glengarry, Nandana, Kashmir, Withers, Glendale, West Coast,\n Great North, Rata, Ash, Rosebank, Aspen, Victor, Avondale College\n\n");
            }
            else if (UserSearchRoutes == "Forest Hill")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press A to search for another bus route or B to go back to the school bus routes display\n ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Morning - Opp 125 Forest Hill Rd, Forest Hill Rd, West Coast Rd, Sunvue Rd, Solar Rd, Glengarry Rd, Nandana Dr,\n Kashmir Rd, Withers Rd, Glendale Rd, West Coast Rd, Great North Rd, Rata St, Ash St, Rosebank Rd, Aspen St,\n Victor St, Avondale College Bus Bay.\n\n ");
            }
            else if (UserSearchRoutes == "Titirangi Village")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Press A to search for another bus route or B to go back to the school bus routes display\n ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(" Morning - Titirangi Village, Titirangi, Rata, Ash, Rosebank, Aspen, Victor, Avondale College\n\n");
            }
            else if (UserSearchRoutes == "2")
            {
                //User returns to the menu.
            }
            switch (UserSearchRoutes)
            {
                case "New Lynn":
                    string UserSearchReturn = Console.ReadLine();
                    switch (UserSearchReturn)
                    {
                        //If user presses "a" then the user will search for another bus route.
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village\n New Lynn");
                            goto Search;
                            // If user presses "b" then the user will be back at the displayed start to finish routes.
                        case "b":
                            Console.Clear();
                            goto Start;
                    }
                    break;
                case "Glendene":
                    Console.WriteLine("Afternoon - Avondale College, Victor St, Rosebank Rd, Riversdale Rd, Wairau Ave, Ash St, Rata St, Rimu St, Nikau St,\n Lynwood Rd, Rimu St, Kelwyn Rd, Archlynn Rd, Archibald Rd, St Leonards Rd, Sabulite Rd, Butterworth Dr, Hepburn Rd,\n Phelps Pl, Farquhar Rd, Glendene Ave, Tirimoana Rd, Te Atatu Rd.\n\n ");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UserSearchesReturn = Console.ReadLine();
                    switch (UserSearchesReturn)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village\n New Lynn");
                            goto Search;
                        case "b":
                            Console.Clear();
                            goto Start;
                    }
                    break;
                case "Parrs Park":
                    Console.WriteLine("Afternoon - Avondale College, Rosebank, Ash, Rata, Great North, West Coast, Glendale Rd, Withers, Kashmir, Nandana,\n Glengarry, Rosier, West Coast, Parrs Cross, last stop opposite 106 Parrs Cross Rd.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UsersSearchesReturn = Console.ReadLine();
                    switch (UsersSearchesReturn)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village\n New Lynn");
                            goto Search;
                        case "b":
                            Console.Clear();
                            goto Start;
                    }
                    break;
                case "Forest Hill":
                    Console.WriteLine("Afternoon - Avondale College Bus Bay, Rosebank Rd, Ash St, Rata St, Great North Rd, West Coast Rd, Glendale Rd,\n Withers Rd, Kashmir Rd, Nandana Dr, Glengarry Rd, Solar Rd, Libra Rd, Sunvue Rd, West Coast Rd, Forest Hill Rd,\n 119 Forest Hill Rd.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UserSearchReturns = Console.ReadLine();
                    switch (UserSearchReturns)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village\n New Lynn");
                            goto Search;
                        case "b":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Start;
                    }
                    break;
                case "Titirangi Village":
                    Console.WriteLine("Afternoon - Avondale College, Rosebank, Ash, Rata, Titirangi, Titirangi Village.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UserReturnSearch = Console.ReadLine();
                    switch (UserReturnSearch)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Routes to Search :\n Glendene\n Parrs Park\n Forest Hill\n Titirangi Village\n New Lynn");
                            goto Search;
                        case "b":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            goto Start;
                    }
                    break;
                // if user presses "2" it clears everyting and the User goes back to the menu then gives the user thesame options from the menu to choose again. 
                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\tAvcol Bus Schedule\t\t\t");
                    Console.WriteLine("\t\t\t~~~~~~~~~~~~~~~~~~\n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Press 1 to see all the school bus numbers\n");
                    Console.WriteLine("Press 2 to see all the school bus routes\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Press 3 to exit app");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" The route you had type must have been invalid or the spelling and capitalisation is wrong.\n(Please press 'Enter' to try again and type the correct route on what the display of routes shows)", UserSearchRoutes);
                    Console.ReadLine();
                    Console.Clear();
                    goto Start;
            } 
        }
    }
}
