using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample
{
    public interface Subject
    {
        List<Observer> observers { get; set; }
        #region Methods
        public bool registerObserver(Observer observer);
        public void unregisterObserver(Observer observer);
        #endregion
    }
}
