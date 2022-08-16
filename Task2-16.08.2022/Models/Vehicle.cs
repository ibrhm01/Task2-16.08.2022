using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_16._08._2022.Models
{
    abstract class Vehicle
    {
        private float _driveTime;
        private float _drivePath;

        public float DriveTime { get; set; }
        public int DrivePath { get; set; }
        public abstract float AverageSpeed();

    }
    
}
