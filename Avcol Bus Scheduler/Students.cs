using System;

namespace Avcol_Bus_Scheduler
{
    class Students
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to see all the school bus numbers");
            Console.WriteLine("Press 2 to see all the school bus routes");
            var userinput = Console.ReadLine();
            var busRoute = new Routes();
            var busNumber = new Bus();
            while (true)
            {
                switch (userinput)
                {
                    case "1":
                        busNumber.Allbusnumbers();
                        Console.Clear();
                        Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                        break;
                    
                    default:
                        Console.WriteLine("Chose vaild answer");
                        break;
                    case "2":
                        busRoute.Allbusroutes();
                        Console.Clear();
                        Console.WriteLine("Press 1 to see all the school bus numbers\nPress 2 to see all the school bus routes");
                        break;


                }
                userinput = Console.ReadLine();
            }
            
        }
    }
}
         
 