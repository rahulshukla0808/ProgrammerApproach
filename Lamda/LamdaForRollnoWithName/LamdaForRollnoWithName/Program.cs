using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaForRollnoWithName
{
    class Program
    {
        static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Student> details = new List<Student>() {
            new Student{ rollNo = 1, name = "Liza" },
                new Student{ rollNo = 2, name = "Stewart" },
                new Student{ rollNo = 3, name = "Tina" },
                new Student{ rollNo = 4, name = "Stefani" },
                new Student { rollNo = 5, name = "Trish" }
        };

            // To sort the details list  
            // based on name of student 
            // in acsending order 
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
            Console.ReadLine();
        }
    }
    }

