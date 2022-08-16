using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_16._08._2022.Models
{
    interface IEngine
    {
        public float HorsePower { get; set; }
        public float TankSize { get; set; }
        public float CurrentOil { get; set; }
        public string FuelType { get; set; }

        public float RemainOilAmount();
    }
}
