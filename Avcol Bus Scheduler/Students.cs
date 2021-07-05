using System;

namespace Avcol_Bus_Scheduler
{
    class Students
    {
        static void Main(string[] args)
        {
            Menu:
            Console.WriteLine("Press 1 to see all the school bus numbers");
            Console.WriteLine("Press 2 to see all the school bus routes");
            Console.WriteLine("Press 'x' to go back ");
            var userinput = Console.ReadLine();
            var busNumber = new Bus();
            var busRoute = new Route();
            while (true)
            {
                switch (userinput)
                {
                    case "1":
                        busNumber.Allbusnumbers();
                        break;
                    case "2":
                        busRoute.Allbusroutes();
                        break;
                        default:
                        Console.Clear();
                        Console.WriteLine("Chose vaild answer, Choose the right number");
                        goto Menu;          
                }
                userinput = Console.ReadLine();
            }
            
        }
    }
}
         
 