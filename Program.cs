using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningEmpl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var emp1 = new Employee("Lara", 45000);
            //var emp2 = new Employee();
            //Employee emp2 = new();
            //Employee emp3 = new Employee();

            //emp2.Name = "David";
            //emp2.Salary = 28000;

            //string hej = "hej " + emp2.Name + " " + "Salary: " + ;

            //Console.WriteLine($"Name: {emp1.Name}, Salary: {emp1.Salary} kr.");
            //Console.WriteLine($"Name: {emp2.Name}, Salary: {emp2.Salary} kr.");


            var employees = new List<Employee>();

            Console.WriteLine("How many employees would you like to add?");
            var nrToAdd = UInt32.Parse(Console.ReadLine());

            for (int i = 0; i < nrToAdd; i++)
            {
                Console.WriteLine($"Enter name:");
                var name = Console.ReadLine();

                Console.WriteLine("Enter salary:");
                var salary = UInt32.Parse(Console.ReadLine());

                var employee = new Employee(name, salary);

                employees.Add(employee);

                Console.WriteLine("\n------------\n");
            }

            foreach (var e in employees)
            {
                Console.WriteLine(e.ToString());
            }

 


            



            


        } 
        

    }
}


    

