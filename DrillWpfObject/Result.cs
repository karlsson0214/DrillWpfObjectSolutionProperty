using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        // objektvariabler
        private int distance;
        private string name;
        private double time;

        // konstruktor
        public Result(int distance, string name, double time)
        {
            this.distance = distance;
            this.name = name;
            this.time = time;
        }

        // properties - egenskaper
        public int Distance
        {
            get
            {
                return distance;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Time
        {
            get
            {
                return time;
            }
        }
    }
}
