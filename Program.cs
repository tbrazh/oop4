using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    internal class Program
    {
        static Car car1 = new Car("tesla","red", 500);
        static Car car2 = new Car("lanos", "grey", 100);
        
        static void Main(string[] args)
        {
            Car car3 = new Car("BogDan","Yelow",15);
            car1.ChangePrice(5);
            car2.ChangePrice(10);
            car3.ChangePrice(90);

            car3.color = "Green";

            car3.Print();

            Console.WriteLine(car1.ToString());
            
            Console.WriteLine(car2.ToString());
            
            Console.ReadLine();
        }
    }

    class Car
    {
        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
        public Car()
        {
            name = "Default name";
            color = "Default color";
            price = 0;
        }

        public string name;
        public double price;
        
        private string _color;
        public string color
        {
            get { return _color; }
            set { _color = value; }
        }

        public const string CompanyName = "The Best Company";
        public void Print()
        {
            Console.WriteLine($"Имя: {name} Цвет: {color}");
        }

        public void Input()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter color");
            color = Console.ReadLine();
        }
        public static bool operator == (Car car1, Car car2)
        {
            return car1.name == car2.name && car1.price == car2.price;
        }
        public static bool operator !=(Car car1, Car car2)
        {
            return car1.name != car2.name && car1.price != car2.price;
        }
        public void ChangePrice(double x)
        {
            price = price - (price/100*x);
        }

        public override string ToString()
        {
            return $"name {name} , color {color}, price {price}, CompanyName {CompanyName}";
        }
    }


}
