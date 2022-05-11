using System;
using System.Collections.Generic;
using System.Text;

namespace reverse_diagram
{
    class Gearbox
    {
        private int currentGear;

        public int CurrentGear
        {
            get { return currentGear; }
            set { currentGear = value; }
        }

        public void ShiftUp(int steps)
        {

        }
        public void ShiftDown(int steps)
        {

        }
        class GearType
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public static void GetGearType()
            {

            }
        }
    }
}
