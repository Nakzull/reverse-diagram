using System;
using System.Collections.Generic;
using System.Text;

namespace reverse_diagram
{
    class Car : Vehicle
    {
        Gearbox gearbox = new Gearbox();
        Wheel wheel1 = new Wheel();
        Wheel wheel2 = new Wheel();
        Wheel wheel3 = new Wheel();
        Wheel wheel4 = new Wheel();
        private string registrationNumber;

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        private string registrationYear;

        public string RegistrationYear
        {
            get { return registrationYear; }
            set { registrationYear = value; }
        }

        private IEngine engine { get; set; }

        public void Start()
        {
            
        }

        
        internal Car()
        {

        }

        public Car(string color)
        {

        }

        public Car(string color, float size)
        {

        }
    }
}
