using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPrototype
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(string modelName, int batteryCapacity, string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return new EntertainmentRobot(ModelName, BatteryCapacity, SoftwareVersion, EntertainmentFeature);
        }

        public override void Display()
        {
            Console.WriteLine("Entertainment Robot");
            base.Display();
            Console.WriteLine("Entertainment Feature: " + EntertainmentFeature);
        }
    }
}
