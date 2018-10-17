using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    public class Student
    {
       public int Sid {get; set;}
       public string Name {get; set;}
       public int Class {get; set;}
       public float Marks {get; set;}
    }
    class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { Sid = 101, Name = "Ashu", Class = 4, Marks = 440.00f };
            Student s2 = new Student { Sid = 102, Name = "Shahil", Class = 5, Marks = 540.00f };
            Student s3 = new Student { Sid = 103, Name = "Ravi", Class = 6, Marks = 640.00f };
            Student s4 = new Student { Sid = 104, Name = "Ankit", Class = 7, Marks = 740.00f };
            Student s5 = new Student { Sid = 105, Name = "Ram", Class = 8, Marks = 840.00f };
            Student s6 = new Student { Sid = 106, Name = "David", Class = 9, Marks = 340.00f };
            List<Student> Student = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            foreach (Student S in Student)
            {
                Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);

            }
            Console.ReadLine();
        }
    }
 }