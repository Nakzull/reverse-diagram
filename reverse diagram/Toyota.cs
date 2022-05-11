using System;
using System.Collections.Generic;
using System.Text;

namespace reverse_diagram
{
    class Toyota : IGasolineEngine, IBreakable
    {
        private float capacity;

        public float Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Toyota(float c)
        {

        }
        public void Brake()
        {

        }
        public void Inject()
        {

        }
        public void Start()
        {

        }

        public void TurnOff()
        {

        }
    }
}
