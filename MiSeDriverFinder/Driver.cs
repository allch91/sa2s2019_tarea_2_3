using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiSeDriverFinder
{
    public class Driver
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int Driver_pos_x { get; set; }
        public int Driver_pos_y { get; set; }
        public int Driver_pos_z { get; set; }

        public Driver(string name, string number, int driver_pos_x, int driver_pos_y, int driver_pos_z)
        {
            Name = name;
            Number = number;
            Driver_pos_x = driver_pos_x;
            Driver_pos_y = driver_pos_y;
            Driver_pos_z = driver_pos_y;
        }
    }
}