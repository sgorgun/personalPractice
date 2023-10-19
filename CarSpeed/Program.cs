﻿/*Create new classes: Vehicle and Car.
Add following fields to Vehicle class:


name;

maxSpeed (can be changed only via a constructor).
Fields should NOT be accessible from outside the class.


Create a parametrized constructor with two parameters in order to initialize Vehicle.
Add following properties:


Name (It must be accessible only in the current class and for inheritors. Property is available both for read and write operations);

MaxSpeed (It can be accessible for inheritors and outside of the class. Property is available only for reading).


Inherit Car class from Vehicle class.
Implement a parametrized constructor for Car class and call a base class constructor.
Implement the following methods in Car class:

the first one would change the name of Car;
the second one should NOT modify anything, but retrieve the name of Car.
Both methods must be accessible outside the class!
add virtual(or abstract, based on your decision) methods to drive the Car

make sure that the Car has all required methods to enable the users of the Car could to use them: Start, Stop, Drive,
Accelerate/Decelerate
add unit tests to demonstrate the use of the Car and the ways to drive it.


Unit test requirements:

make sure there are unit tests for all methods
check boundary conditions with Unit tests
use defensive coding and check input parameters
throw exceptions if some conditions or parameters are wrong
provide unit tests for constructors



Topics - classes, inheritance.*/

using System;

namespace InheritanceVehicle
{
    public class Vehicle
    {
        private string name;
        protected int maxSpeed;

        public Vehicle(string name, int maxSpeed)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
        }

        protected string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected int MaxSpeed
        {
            get { return maxSpeed; }
        }
    }

    public class Car : Vehicle
    {
        public Car(string name, int maxSpeed) : base(name, maxSpeed)
        {
        }

        public string NewCar(string newCarName) => Name = newCarName;

        public string GetCarName() => Name;
        
        public virtual void Start()
        {
            Console.WriteLine("Car started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Car stopped");
        }
        
        public virtual void Drive()
        {
            Console.WriteLine("Car is driving");
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("Car is accelerating");
        }

        public virtual void Decelerate()
        {

            Console.WriteLine("Car is Decelerating");
        }
    }

    public sealed class Stub
    {
        public void Test()
        {
            Car car = new Car("BMW", 200);
            car.GetCarName();
            car.NewCar("Bentley");
            car.Start();
            car.Drive();
            car.Accelerate();
            car.Decelerate();
            car.Stop();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 200);
            car.GetCarName();
            car.NewCar("Bentley");
            car.Start();
            car.Drive();
            car.Accelerate();
            car.Decelerate();
            car.Stop();
        }
    }
}
