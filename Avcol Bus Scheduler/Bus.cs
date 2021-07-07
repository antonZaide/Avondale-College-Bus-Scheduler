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
            Console.WriteLine("    School Bus Numbers\n Press 1 again to exit     ");//User can leave any time by pressing 1 again in the bus numbers table.
            Console.WriteLine("School busses heading to Avondale College in the morning:\n");
                string Busses = "015 Glendene - Departs 7:50 am and 7:59am\n053 Parrs Park - Departs 7:35am\n056 Forest Hill - Departs 7:26am\n072 Titirangi Village - Departs 7:55am\n\nSchool busses leaving Avondale College in the afternoon.\n\n012 New Lynn - Departs 3:30pm\n015 Glendene - Departs 3:30pm\n053 Parrs Park - Departs 3:30pm\n056 Forest Hill - Departs 3:30pm\n072 Titirangi Village - Departs 3:25pm \n ";
                Console.WriteLine(Busses);
            //User already sees the bus numbers in the mornning and afternoon diplayed.
        Start:
            //User could search for a bus number for a clear bus information and deatails.
            Console.WriteLine("Search for any bus number on the display for more details.");              
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
                    Console.WriteLine("Departs in the morning: 7:50am & 7:54am/ Afternoon: 3:30pm\n Operator: NZ Bus");
                    Console.WriteLine("Press A to search for another bus number or B to back to the display.");
                    string UserReturn = Console.ReadLine();
                    switch (UserReturn)
                    {
                        //If User presess "a" then the user gets a chance to search for another bus number.
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Bus Numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                            //If User presses "b" then the user goes back to the bus number diplays.
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "012":
                    Console.WriteLine("Departs in the afternoon: 3:30pm\n Operator: Pavlovich Coachlines");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string UserBack = Console.ReadLine();
                    switch (UserBack)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "053":
                    Console.WriteLine("Departs in the morning: 7:35am/ Afternoon: 3:30pm\n Operator: Pavolovich Coach Lines");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string ReturnUser = Console.ReadLine();
                    switch (ReturnUser)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "056":
                    Console.WriteLine("Departs in the morning: 7:26am/ Afternoon: 3:30pm\n Operator: Pavlovich Coach Lines ");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string BackUser = Console.ReadLine();
                    switch (BackUser)
                    {
                        case "a":
                            Console.Clear();
                            Console.WriteLine("Bus numbers to search:\n 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "b":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case "072":
                    Console.WriteLine("Departs in the morning: 7:55am/ Afternoon: 3:25pm\n Operator: Ritchies Transport");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string UserStart = Console.ReadLine();
                    switch (UserStart)
                    {
                        case "a":
                            Console.Clear();
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
                    Console.WriteLine("        Avcol Bus Schedule     ");
                    Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                    Console.WriteLine("Press 3 to exit app");
                    break;
                default:
                    Console.WriteLine("Your choice is invalid (Press Enter to try again)", UserSearch);
                    Console.ReadLine();
                    goto Start;
            }
        }
    }
}
