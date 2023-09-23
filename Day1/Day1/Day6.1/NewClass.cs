using ProjectOne.Day6._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


/**Class are three types Boundry, Control, and Entity
 * class are that interact with external environment is know as Boundry Class
 * Entity are work alone they only hold model Entity are persiset and durable 
 * Control flow of Application 
 * >Request Handler Controlr
 * >Bussiness Controler
 * >Repository Controler 
 * >Separate clss for error Handling 
 * Object are three Types Actor, Servers an Agents 
 * Actor Provide services they dont they act 
 * Servers will provide services 
 * Agents may take servies form other but not from Actors (Delegate)
 *Log Manager*/




namespace ProjectOne.Day6._1
{
    public class Car
    {
        public string RegistrationNo { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public FuelType Fuel { get; set; }
        public Wheel[] Wheels { get; set; } = new Wheel[0];
        public Engine CarEngine { get; set; } = new Engine();

        public enum FuelType
        {
            Petrol,
            Diesel,
            Electric,
            Hybrid
        }

        public class Wheel
        {
            public string Brand { get; set; }
            public int Size { get; set; }
        }

        public class Engine
        {
            public string Type { get; set; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                RegistrationNo = "ABC123",
                Model = "Tharun",
                Fuel = Car.FuelType.Electric,
                Wheels = new Car.Wheel[4],
                CarEngine = new Car.Engine()
            };

            for (int i = 0; i < car.Wheels.Length; i++)
            {
                car.Wheels[i] = new Car.Wheel
                {
                    Brand = "Brand" + (i + 1),
                    Size = 18
                };
            }

            car.CarEngine.Type = "V6";

            Console.WriteLine($"Registration No: {car.RegistrationNo}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Fuel Type: {car.Fuel}");
            Console.WriteLine($"Engine Type: {car.CarEngine.Type}");
            Console.WriteLine("Wheels:");
            foreach (var wheel in car.Wheels)
            {
                Console.WriteLine($"Brand: {wheel.Brand}, Size: {wheel.Size}");
            }
        }
    }
}





/*Create a class called Car.
The Car has a RegistrationNo, Model, FuelType, Wheels[4],
and 1 Engine.
The FuelType must be an Enum
Wheel, and Engine must be INNER Class.*/
