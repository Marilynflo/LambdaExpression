using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> Employee = new List<Employee>()
            {
            new Employee() { FirstName = "Joe", LastName = "Rogan", Id = 1 },
            new Employee() { FirstName = "Jenny", LastName = "Lee", Id = 2 },
            new Employee() { FirstName = "Brad", LastName = "Pitt", Id = 3 },
            new Employee() { FirstName = "Angelina", LastName = "Jolie", Id = 4 },
            new Employee() { FirstName = "Jennifer", LastName = "Aniston", Id = 5 },
            new Employee() { FirstName = "Bruce", LastName = "Willis", Id = 6 },
            new Employee() { FirstName = "Christina", LastName = "Ricci", Id = 7 },
            new Employee() { FirstName = "Joe", LastName = "Jill", Id = 8 },
            new Employee() { FirstName = "Dennis", LastName = "Rodman", Id = 9 },
            new Employee() { FirstName = "Jared", LastName = "Palecki", Id = 10 }
            };

            List<Employee> People = new List<Employee>();
            foreach (Employee name in Employee)

            {
                if (name.FirstName == "Joe")
                {
                    People.Add(name);
                    Console.WriteLine("Names with " + name.FirstName + " using foreach loop");
                }
            }

            List<Employee> People2 = new List<Employee>();
            People2 = Employee.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee person in People2)
            {
                Console.WriteLine("Names " + person.FirstName + " Added to the List using lambda");
            }

            List<Employee> People3 = new List<Employee>();
            People3 = Employee.Where(x => (x.Id > 5)).ToList();
            foreach (Employee personId in People3)
            {
                Console.WriteLine(personId.FirstName + " " + personId.LastName);
            }
            Console.ReadLine();
        }
    }
}