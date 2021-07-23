using System;
using System.Collections.Generic;
using System.Text;

namespace Avcol_Bus_Scheduler
{
    class Bus
    {
        public void Allbusnumbers()
        {
        Display:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    School Bus Numbers   ");//User can leave any time by pressing 1 again in the bus numbers table.
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 1 again to 'Exit'");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("School busses heading to Avondale College in the morning:\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("015 Glendene - Departs 7:50 am and 7:59am\n053 Parrs Park - Departs 7:35am\n056 Forest Hill - Departs 7:26am\n072 Titirangi Village - Departs 7:55am\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("School busses leaving Avondale College in the afternoon");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("012 New Lynn - Departs 3:30pm\n015 Glendene - Departs 3:30pm\n053 Parrs Park - Departs 3:30pm\n056 Forest Hill - Departs 3:30pm\n072 Titirangi Village - Departs 3:25pm\n");
        //User already sees the bus numbers in the mornning and afternoon diplayed.
        Start:
            //User could search for a bus number for a clear bus information and deatails.
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Search for any bus number on the display for more details.");
            Console.ForegroundColor = ConsoleColor.White;
            string UserSearch = string.Format(Console.ReadLine());
            if (UserSearch == "015")
            {
                Console.WriteLine("Glendene");
            }
            else if(UserSearch == "012")
            {
                Console.WriteLine("New Lynn");
            }
            else if (UserSearch == "053")
            {
                Console.WriteLine("Parrs Park");
            }
            else if (UserSearch == "056")
            {
                Console.WriteLine("Forest Hill");
            }
            else if (UserSearch == "072")
            {
                Console.WriteLine("Titirangi Village");
            }
            else if (UserSearch == "1")
            {
                //User returns to the menu.
            }
            switch (UserSearch)
            {
                case "015":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Departs in the morning: 7:50am & 7:54am/ Afternoon: 3:30pm\n Operator: NZ Bus");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press A to search for another bus number or B to back to the display.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UserReturn = Console.ReadLine();
                    switch (UserReturn)
                    {
                        //If User presess "a" then the user gets a chance to search for another bus number.
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bus Numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                            //If User presses "b" then the user goes back to the bus number diplays.
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "012":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Departs in the afternoon only: 3:30pm\n Operator: Pavlovich Coachlines");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UserBack = Console.ReadLine();
                    switch (UserBack)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "053":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Departs in the morning: 7:35am/ Afternoon: 3:30pm\n Operator: Pavolovich Coach Lines");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string ReturnUser = Console.ReadLine();
                    switch (ReturnUser)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "056":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Departs in the morning: 7:26am/ Afternoon: 3:30pm\n Operator: Pavlovich Coach Lines ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string BackUser = Console.ReadLine();
                    switch (BackUser)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "072":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Departs in the morning: 7:55am/ Afternoon: 3:25pm\n Operator: Ritchies Transport");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    Console.ForegroundColor = ConsoleColor.White;
                    string UserStart = Console.ReadLine();
                    switch (UserStart)
                    {
                        case "a":
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "1":
                    // if user presses "1" it clears everyting and the User goes back to the menu then gives the user thesame options from the menu to choose again. 
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("         Avcol Bus Schedule\n     ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Press 1 to see all the school bus numbers\n");
                    Console.WriteLine("Press 2 to see all the school bus routes\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Press 3 to exit app");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" The number you had type must have been invalid.\n(Please press 'Enter' to try again and to see what the display of school bus numbers shows.)", UserSearch);
                    Console.ReadLine();
                    Console.Clear();
                    goto Display;
            }
        }
    }
}
