using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot serviceRobot = new ServiceRobot(
                "SR-100",
                10,
                "V1.0",
                "Customer Assistance"
            );

            IndustrialRobot industrialRobot = new IndustrialRobot(
                "IR-200",
                20,
                "V2.0",
                "Welding"
            );

            EntertainmentRobot entertainmentRobot = new EntertainmentRobot(
                "ER-300",
                8,
                "V1.5",
                "Dancing"
            );

            Console.WriteLine("Original Service Robot");
            serviceRobot.Display();

            Console.WriteLine("\nCloned Service Robot");
            ServiceRobot clonedServiceRobot = (ServiceRobot)serviceRobot.Clone();

            clonedServiceRobot.BatteryCapacity = 15;
            clonedServiceRobot.SoftwareVersion = "V1.1";

            clonedServiceRobot.Display();

            Console.WriteLine("\nOriginal Industrial Robot");
            industrialRobot.Display();

            Console.WriteLine("\nCloned Industrial Robot");
            IndustrialRobot clonedIndustrialRobot = (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.BatteryCapacity = 25;
            clonedIndustrialRobot.SoftwareVersion = "V2.1";

            clonedIndustrialRobot.Display();

            Console.WriteLine("\nOriginal Entertainment Robot");
            entertainmentRobot.Display();

            Console.WriteLine("\nCloned Entertainment Robot");
            EntertainmentRobot clonedEntertainmentRobot = (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.BatteryCapacity = 12;
            clonedEntertainmentRobot.SoftwareVersion = "V1.6";

            clonedEntertainmentRobot.Display();

            Console.ReadLine();
        }
    }
}