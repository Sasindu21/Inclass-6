using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(string modelName, int batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override Robot Clone()
        {
            return new ServiceRobot(ModelName, BatteryCapacity, SoftwareVersion, ServiceTask);
        }

        public override void Display()
        {
            Console.WriteLine("Service Robot");
            base.Display();
            Console.WriteLine("Service Task: " + ServiceTask);
        }
    }
}