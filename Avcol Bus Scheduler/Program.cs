using System;

namespace Avcol_Bus_Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
        Menu:
            // The programme starts with a display of the two options.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t\t\tAvcol Bus Schedule\t\t\t");
            Console.WriteLine("\t\t\t~~~~~~~~~~~~~~~~~~\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press 1 to see all the school bus numbers\n");
            Console.WriteLine("Press 2 to see all the school bus routes\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 3 to exit the app");
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
         
 