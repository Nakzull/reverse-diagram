using System;
using System.Collections.Generic;
using System.Text;

namespace reverse_diagram
{
    class Bicycle : IBreakable
    {
        private string registrationNumber;

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public Bicycle(int numberOfWheels)
        {
            List<Wheel> wheels = new List<Wheel>(numberOfWheels);
        }

        public void Brake()
        {

        }
    }
}
