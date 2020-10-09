using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._3
{
    public class Vehicle
    {
        public int cost, speed;
        public DateTime date;
        public Vehicle(int cost, int speed, DateTime date)
        {
            this.cost = cost;
            this.speed = speed;
            this.date = date;
        }
        public void Show()
        {
            Console.WriteLine($"Цена: {cost} руб., скорость: {speed}, дата изготовления: {date}.");
        }
    }
    public class Plane : Vehicle
    {
        public int hight, numberOfPassengers;
        public Plane(int cost, int speed, DateTime date, int hight, int numberOfPassengers)
            : base(cost, speed, date)
        {
            this.hight = hight;
            this.numberOfPassengers = numberOfPassengers;
        }
        public void Print()
        {
            Show();
            Console.WriteLine($"Максимальная высота: {hight}, количество пассажиров: {numberOfPassengers}.");
            Console.WriteLine(new String('-', 25));
        }
    }
    class Car : Vehicle
    {
        public string type;
        public Car(int cost, int speed, DateTime date, string type)
            : base(cost, speed, date)
        {
            this.type = type;
        }
        public void Print()
        {
            Show();
            Console.WriteLine($"Тип кузова: {type}.");
            Console.WriteLine(new String('-', 25));
        }
    }
    class Ship : Vehicle
    {
        public string homePort;
        public int numberOfPassengers;
        public Ship(int cost, int speed, DateTime date, string homePort, int numberOfPassengers)
           : base(cost, speed, date)
        {
            this.homePort = homePort;
            this.numberOfPassengers = numberOfPassengers;
        }
        public void Print()
        {
            Show();
            Console.WriteLine($"Порт прописки: {homePort}, количество пассажиров: {numberOfPassengers}.");
            Console.WriteLine(new String('-', 25));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1_110_000, 180, new DateTime(2017, 10, 14), "хечбек");
            car.Print();
            Plane plane = new Plane(3_000_000, 300, DateTime.Today, 10, 300);
            plane.Print();
            Ship ship = new Ship(3_000_000, 80, DateTime.Today, "Новороссийск", 15);
            ship.Print();
        }
    }
}
