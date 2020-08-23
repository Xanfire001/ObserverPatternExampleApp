using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternExample.Classes
{
    public class TrafficLight : Subject
    {
        public List<Observer> observers { get; set; } = new List<Observer>();

        private bool state { get; set; }

        public TrafficLight()
        {
            state = true;
        }

        public string getState()
        {
            if (state)
                return "grün";
            else
                return "rot";

        }

        public void setState(bool _state)
        {
            state = _state;
            notifyObservers();
        }
        public void notifyObservers()
        {
            if (observers.Count > 5)
            {
                for (var o = 0; o <= 5; o++)
                {
                    observers[o].Update(state);
                }
            }
            else
            {
                foreach (var o in observers)
                {
                    o.Update(state);
                }
            }
        }

        public bool registerObserver(Observer observer)
        {
            if (!state)
                observers.Add(observer);
            observer.Update(state);
            return state;
        }

        public void unregisterObserver(Observer observer)
        {
            observers.Remove(observer);
        }
    }
}
