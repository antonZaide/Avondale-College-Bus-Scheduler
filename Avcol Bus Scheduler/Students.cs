using System;

namespace Avcol_Bus_Scheduler
{
    class Students
    {
        static void Main(string[] args)
        {
        Menu:
            // The programme starts with a display of the two options.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         Avcol Bus Schedule\n    ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 1 to see all the school bus numbers\n");
            Console.WriteLine("Press 2 to see all the school bus routes\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 3 to exit app");
            Console.ForegroundColor = ConsoleColor.White;

            var userinput = Console.ReadLine();
            var busNumber = new Bus();
            var busRoute = new Route();
            while (true)
            {
                switch (userinput)
                {
                    // if User presses 1 then the programme would take the user to the bus number tables.
                    case "1":
                        Console.Clear();
                        busNumber.Allbusnumbers();
                        break;
                    // if User presses then the programme would take the user to the bus routes table.
                    case "2":
                        Console.Clear();
                        busRoute.Allbusroutes();
                        break;
                        default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("'There has been an error', Choose 1, 2 ,or 3 to exit ");
                        goto Menu;
                    case "3":
                        return;
                }
                userinput = Console.ReadLine();
            }
            
        }
    }
}
         
 