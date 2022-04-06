using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Tires
    {
        public Tires(int age,double pressure)
        {
            Tires[] tires = new Tires[4];
           this.Age = age;
           this.Pressure = pressure;
        }
        public int Age { get ; set; }
        public double Pressure { get; set; }
    }
}
