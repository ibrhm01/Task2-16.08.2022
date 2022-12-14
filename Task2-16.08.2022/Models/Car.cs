using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_16._08._2022.Models
{
    class Car: Vehicle, ITransmission, IWheel, IEngine
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public string TransmissionKind { get; set; }
        public float WheelThickness { get; set; }
        public float HorsePower { get; set; }
        public float TankSize { get; set; }
        public float CurrentOil { get; set; }
        public string FuelType { get; set; }

        public override float AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public float RemainOilAmount()
        {
            return CurrentOil;
        }
    }

}
