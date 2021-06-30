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
            Console.WriteLine("    Display\n Press 1 again to exit   ");
                Console.WriteLine("School busses heading to Avondale College in the morning:\n");
                string Busses = "015 Glendene - Departs 7:50 am and 7:59am\n053 Parrs Park - Departs 7:35am\n056 Forest Hill - Departs 7:26am\n072 Titirangi Village - Departs 7:55am\n\nSchool busses leaving Avondale College in the afternoon.\n\n012 New Lynn - Departs 3:30pm\n015 Glendene - Departs 3:30pm\n053 Parrs Park - Departs 3:30pm\n056 Forest Hill - Departs 3:30pm\n072 Titirangi Village - Departs 3:25pm \n ";
                Console.WriteLine(Busses);
          
         
        Start:
            Console.WriteLine("Search for any bus number on the display for more details.");              
            int UserSearch = int.Parse(Console.ReadLine());
            if (UserSearch == 015)
            {
                Console.WriteLine("Glendene.");
            
            }
            else if(UserSearch == 012)
            {
                Console.WriteLine("New Lynn");
              
            }
            else if (UserSearch == 053)
            {
                Console.WriteLine("Parrs Park");
            }
            else if (UserSearch == 056)
            {
                Console.WriteLine("Forest Hill");
            }
            else if (UserSearch == 072)
            {
                Console.WriteLine("Titirangi Village");
            }
            else
            {
                Console.WriteLine("Chose in Valid");
            }
            switch (UserSearch)
            {
                case 015:
                    Console.WriteLine("Departs in the morning: 7:50am & 7:54am/ Afternoon: 3:30pm\n Operator: NZ Bus");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string UserReturn = Console.ReadLine();
                    switch (UserReturn)
                    {
                        case "A":
                            Console.Clear();
                            Console.WriteLine(" 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "B":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case 012:
                    Console.WriteLine("Departs in the afternoon: 3:30pm\n Operator: Pavlovich Coachlines");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string UserBack = Console.ReadLine();
                    switch (UserBack)
                    {
                        case "A":
                            Console.Clear();
                            Console.WriteLine(" 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "B":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case 053:
                    Console.WriteLine("Departs in the morning: 7:35am/ Afternoon: 3:30pm\n Operator: Pavolovich Coach Lines");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string ReturnUser = Console.ReadLine();
                    switch (ReturnUser)
                    {
                        case "A":
                            Console.Clear();
                            Console.WriteLine(" 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "B":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case 056:
                    Console.WriteLine("Departs in the morning: 7:26am/ Afternoon: 3:30pm\n Operator: Pavlovich Coach Lines ");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string BackUser = Console.ReadLine();
                    switch (BackUser)
                    {
                        case "A":
                            Console.Clear();
                            Console.WriteLine(" 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "B":
                            Console.Clear();
                            goto Display;
                    }
                    break;
                case 072:
                    Console.WriteLine("Departs in the morning: 7:55am/ Afternoon: 3:25pm\n Operator: Ritchies Transport");
                    Console.WriteLine("Press A to return to search for another bus number or B to back to the display.");
                    string UserStart = Console.ReadLine();
                    switch (UserStart)
                    {
                        case "A":
                            Console.Clear();
                            Console.WriteLine(" 015 - Glendene\n 012 - New Lynn\n 053 - Parrs Park\n 056 - Forest Hill\n 072 - Titirangi Village");
                            goto Start;
                        case "B":
                            Console.Clear();
                            goto Display;
                    }
                    break;
            }
        }
    }
}
