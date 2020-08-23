using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ObserverPatternExample
{
    public class Car : Observer
    {
        private bool subjectState { get; set; }
        public bool isDriving { get; private set; }
        public void Update(bool state)
        {
            isDriving = state;
            subjectState = state;
        }
    }
}
