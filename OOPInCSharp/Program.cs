using System;
using System.Collections.Generic;

namespace OOPInCSharp
{
    /*
Task A:  OOP in C#

Start a Console Application in Visual Studio for C# (.NET framework). Implement a class Student that contains name, id and age of the student (assume the name and id are string, and age is int).  Remember to implement the properties (get / set methods) in the class Student.  

Also add in the class Student a method, GetInformation()
  
 public string GetInformation()
  {
         // to be completed
  }

that returns all the info of the student (the method should return a single string containing the concatenation of name, id and age). 

In the Main method:

- Create and add 10 objects of class Student in an array of Student objects 

- Display the info (name, id and age) for all the students (use a loop) present in the array by using you implemented method GetInformation. 
     */
    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> customerName = new Queue<string>();
            string userOption = "1";
            while (userOption != "5")
            {
                Console.WriteLine("Please select an option to begin");
                Console.WriteLine("enter 1 to enqueue new customer");
                Console.WriteLine("enter 2 to deque a customer");
                Console.WriteLine("enter 3 to display the total number of names in the queue");
                Console.WriteLine("enter 4 to display the full contents of the queue");
                Console.WriteLine("enter 5 to exit");

                userOption = Console.ReadLine();

                if (userOption == "1")
                {
                    if (customerName.Count < 20)
                    {
                        EnqueueCustomer();
                    }
                    else
                    {
                        Console.WriteLine("You have reached the maximum, Please dequeue a customer to continue");
                    }
                }
                else if (userOption == "2")
                {
                    customerName.Dequeue();
                }
                else if (userOption == "3")
                {
                    Console.WriteLine($"The total number of names in the queue are: {customerName.Count}");
                }
                else if (userOption == "4")
                {
                    Console.WriteLine("Contents of the Queue");
                    foreach (var name in customerName)
                    {
                        Console.WriteLine($"{name}");
                    }
                }
                else if (userOption == "5")
                {
                    
                }
                else
                {
                    Console.WriteLine("Please select 1 of the given options");
                }
            }

            /*
            Student[] students =
            {
                new Student {Name = "Titus", Age = 15, Id = "001"},
                new Student {Name = "Ema", Age = 14, Id = "002"},
                new Student {Name = "Lois", Age = 14, Id = "003"},
                new Student {Name = "Izy", Age = 14, Id = "004"},
                new Student {Name = "Ali", Age = 14, Id = "005"},
                new Student {Name = "Frank", Age = 14, Id = "006"},
                new Student {Name = "Ben", Age = 14, Id = "007"},
                new Student {Name = "Moli", Age = 14, Id = "008"},
                new Student {Name = "Ann", Age = 14, Id = "009"},
                new Student {Name = "Eddie", Age = 14, Id = "010"},
                
            };

            foreach (var student in students)
            {
                Console.WriteLine(student.GetInformation());
            } */

            void EnqueueCustomer()
            {
                Console.WriteLine("Please enter customer name to enqueue");
                string nameOfCustomer = Console.ReadLine();
                customerName.Enqueue(nameOfCustomer);
            }
        }

        
    }

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string GetInformation()
        {
            var studentInfo = $"id= {Id}, name = {Name}, Age = {Age}";
            return studentInfo;
        }
    }
}