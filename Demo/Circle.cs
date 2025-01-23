using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Circle : ICircle
    {
        public int Area { get; set; }
        public Circle(int area)
        {
            this.Area = area;
        }


        public string displayInfo()
        {
            return $"This is Circle and its Area is {Area}";
        }
    }
}

