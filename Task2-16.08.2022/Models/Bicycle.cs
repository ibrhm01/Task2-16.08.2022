using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_16._08._2022.Models
{
    class Bicycle: Vehicle, ITransmission, IWheel
    {
        public string PedalKind { get; set; }
        public string TransmissionKind { get; set; }
        public float WheelThickness { get; set; }

        public override float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
