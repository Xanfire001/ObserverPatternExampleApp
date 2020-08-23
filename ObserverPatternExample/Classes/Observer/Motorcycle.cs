using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample.Classes
{
    public class Motorcycle : Observer
    {
        public bool subjectState { get; set; }
        public bool isDriving { get; private set; }

        public void Update(bool state)
        {
            isDriving = state;
            subjectState = state;
        }
    }
}
