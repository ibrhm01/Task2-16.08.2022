using System;
using Task2_16._08._2022.Models;

namespace Task2_16._08._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.DrivePath = 10;
            c.DriveTime = 2;
            c.CurrentOil = 90;
            Bicycle b = new Bicycle();
            b.DrivePath = 20;
            b.DriveTime = 10;
            Plane p = new Plane();
            p.DrivePath = 72;
            p.DriveTime = 3;
            p.CurrentOil = 60;
            Vehicle[] vehicles = { c, b, p };
            foreach (var item in vehicles)
            {
                Console.WriteLine($"Average Speed: { item.AverageSpeed()}");
            }
            Console.WriteLine($"Remain Oil Amount: {c.RemainOilAmount()}");
            Console.WriteLine($"Remain Oil Amount: {p.RemainOilAmount()}");
        }
    }
}
