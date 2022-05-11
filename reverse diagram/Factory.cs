using System;
using System.Collections.Generic;
using System.Text;

namespace reverse_diagram
{
    class Factory
    {
        Vehicle vehicle = new Car();

        public static void Instance()
        {

        }

        private Factory()
        {

        }
        public Vehicle Create(int type)
        {
            return vehicle;
        }
    }
}
