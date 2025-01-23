using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Rectangle : IRectangle
    {

        public Rectangle(int area)
        {
            this.Area = area;
        }
        public int Area { get; set; }

        public string displayInfo()
        {
            return $"This is Rectangle and its Area is {Area}";
        }
    }
}
