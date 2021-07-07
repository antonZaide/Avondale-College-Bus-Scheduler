using System;

namespace Avcol_Bus_Scheduler
{
    class Students
    {
        static void Main(string[] args)
        {
        Menu:
            // The programme starts with a display of the two options.
            Console.WriteLine("         Avcol Bus Schedule     ");
            Console.WriteLine("Press 1 to see all the school bus numbers");
            Console.WriteLine("Press 2 to see all the school bus routes");
            Console.WriteLine("Press 3 to exit app");

            var userinput = Console.ReadLine();
            var busNumber = new Bus();
            var busRoute = new Route();
            while (true)
            {
                switch (userinput)
                {
                    // if User presses 1 then the programme would take the user to the bus number tables.
                    case "1":
                        busNumber.Allbusnumbers();
                        break;
                    // if User presses then the programme would take the user to the bus routes table.
                    case "2":
                        busRoute.Allbusroutes();
                        break;
                        default:
                        Console.Clear();
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
         
 