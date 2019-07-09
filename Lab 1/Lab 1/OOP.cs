using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab_1
{
    public class OOP : IOOP
    {
        public void StudentInfo()
        {
            var studentList = new List<Student>()
            {
                new Student() { Name = "Shruti", id = 65, section = "B" },
                new Student() { Name = "Abdullah", id = 75, section = "B" },
                new Student() { Name = "Maliha", id = 43, section = "A" }
            };
            studentList.Add(new Student() { Name = "Ishan", id = 77, section = "B" });
            studentList.Add(new Student() { Name = "Mayisha", id = 28, section = "A" });
            studentList.Add(new Student() { Name = "Shimul", id = 14, section = "A" });

            int countA = 0, countB = 0;

            foreach (var student in studentList)
            {
                if (student.section == "A")
                    countA++;
                else if (student.section == "B")
                    countB++;
            }
            Console.WriteLine($"Total Students in A: {countA}");
            Console.WriteLine($"Total Students in B: {countB}");

            // LINQ(Language Integrated Query) Query. Very Basic IDEA!!! 

            countA = 0;
            countB = 0;

            countA = studentList.Where(m => m.section == "A").Count();
            countB = studentList.Where(m => m.section == "B").Count();

            Console.WriteLine($"Using LINQ");
            Console.WriteLine($"Total Students in A: {countA}");
            Console.WriteLine($"Total Students in B: {countB}");

            // get the Name and section whose ID are odd.

            var oddNameAndSectionList = studentList.Where(m => m.id % 2 != 0)
                                                   .Select(x => new
                                                   {
                                                       x.Name,
                                                       x.section
                                                   })
                                                   .ToList();

            foreach (var item in oddNameAndSectionList)
            {
                Console.WriteLine($"Name: {item.Name} -> Section: {item.section}");
            }

            Console.ReadLine();
        }
    }
}
