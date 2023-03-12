using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop4HomeWork
{
    internal class Program
    {
        enum names {  Vlad=0,Oleg=1,Alex=2,John=3,Naruto=4,Valerii=5,Bogdan=6,Vova=7,Igor=8}
        static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                names name = (names)rand.Next(8);
                int y = rand.Next(2011);
                int m = rand.Next(11);
                int d = rand.Next(20);
                DateTime dt = new DateTime(y, m, d);
                Persons.Add(new Person(name.ToString(), dt));
            }
            Persons.Add(new Person("boy", new DateTime(2015,2,15)));
            foreach (var item in Persons)
            {
                Console.WriteLine("{0} age {1}",item.Name,item.Age());
                if (item.Age()<16)
                {
                    item.ChangeName("Very Young " + item.Name);
                }
            }
            foreach (var item in Persons)
            {
                item.Output();
            }
            foreach (var item in Persons)
            {
                int i = rand.Next(Persons.Count - 1);
                if (item == Persons[i])
                {
                    Console.WriteLine(item.ToString() +  " same as " + Persons[i].ToString());
                }
                
            }
            Console.Read();
        }
    }
    public class Person
    {

        public Person()
        {
            _name = "Oleg";
            _birthYear = new DateTime(1,1,1);
        }

        public Person(string name, DateTime birthYear)
        {
            _name = name;
            _birthYear = birthYear;
        }

        public int Age()
        {
            
            return DateTime.Today.Year-_birthYear.Year;
        }
        public void Input()
        {
            Console.WriteLine("enter Name");
            _name=Console.ReadLine();
            Console.WriteLine("Enter birthYear");
            var year = int.Parse(Console.ReadLine());
            _birthYear =new DateTime(year,1,1);
        }
        public void ChangeName(string name)
        {
            _name = name;
        }
        public override string ToString()
        {
            return $"{_name} Birth date {_birthYear}";
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1.Name == person2.Name && person1.birthYear == person2.birthYear;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return person1.Name != person2.Name && person1.birthYear != person2.birthYear;
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
        #region props
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        private DateTime _birthYear;

        public DateTime birthYear
        {
            get { return _birthYear; }
        }
        #endregion



    }
}
