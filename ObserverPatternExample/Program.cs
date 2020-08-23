using ObserverPatternExample.Classes;
using System;

namespace ObserverPatternExample
{
    public class Program
    { 
        static void Main(string[] args)
        {
            #region Init
            TrafficLight trafficLight = new TrafficLight();            
            Car Auto1 = new Car();
            Car Auto2 = new Car();
            Motorcycle Motorrad = new Motorcycle();
            #endregion

            #region ExampleOne
            Console.WriteLine("Blaues Auto fährt Ampel an. registerObserver() wird aufgerufen");
            Console.WriteLine("Ampel ist " + trafficLight.getState());
            trafficLight.registerObserver(Auto1);
            Console.ReadKey();
            Console.WriteLine("Anzahl Beobachter = " + trafficLight.observers.Count);
            Console.ReadKey();
            #endregion

            trafficLight.setState(false);
            Console.WriteLine("Ampel schaltet auf " + trafficLight.getState() + ". setState() wird aufgerufen.");
            Console.ReadKey();

            #region ExampleTwo
            Console.WriteLine("Gelbes Auto und Motorrad fahren Ampel an. registerObserver() wird aufgerufen");          
            trafficLight.registerObserver(Auto2);
            trafficLight.registerObserver(Motorrad);
            Console.ReadKey();

            Console.WriteLine("Anzahl Beobachter = " + trafficLight.observers.Count);
            Console.ReadKey();

            trafficLight.setState(true);
            Console.WriteLine("Ampel schaltet auf " + trafficLight.getState() + ". setState() wird aufgerufen.");
            Console.ReadKey();

            Console.WriteLine("Auto2 fährt = " + Auto2.isDriving + ". unregisterObserver() wird aufgerufen.");
            Console.WriteLine("Motorrad fährt = " + Motorrad.isDriving + ". unregisterObserver() wird aufgerufen.");
            trafficLight.unregisterObserver(Auto2);
            trafficLight.unregisterObserver(Motorrad);
            Console.ReadKey();
            Console.WriteLine("Anzahl Beobachter = " + trafficLight.observers.Count);
            Console.ReadKey();

            #endregion

            trafficLight.setState(false);
            Console.WriteLine("Ampel schaltet auf " + trafficLight.getState() + ". setState() wird aufgerufen.");
            Console.ReadKey();

            #region ExampleThree
            for (int a = 0; a < 20; a++)
            {
                Car car = new Car();
                trafficLight.registerObserver(car);
            }
            trafficLight.setState(true);
            #endregion
        }
    }

    //   Programmstart
    //   Initiiere Ampel(Grün)
    //   Initiiere Auto(x2)
    //   Initiiere Motorrad
    //   Auto 1 fährt an
    //       -> registerObserver
    //   Ampel ist grün
    //       -> Auto fährt weiter 
    //       -> unregisterObserver
    //   Ampel auf rot setzen
    //   Auto 2 fährt an
    //       -> registerObserver
    //   Motorrad fährt an
    //       -> registerObserver
    //   Ampel auf grün setzen 
    //       -> notifyObserver
    //   Auto fährt weiter
    //       -> unregisterObserver
    //   Motorrad fährt weiter
    //       -> unregisterObserver
}
