using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(string modelName, int batteryCapacity, string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            return new IndustrialRobot(ModelName, BatteryCapacity, SoftwareVersion, IndustrialTask);
        }

        public override void Display()
        {
            Console.WriteLine("Industrial Robot");
            base.Display();
            Console.WriteLine("Industrial Task: " + IndustrialTask);
        }
    }
}