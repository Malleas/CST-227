using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 50, 95, 82, 85, 77, 62, 100, 99, 83, 42, 10 };
            
            List<Student> students = new List<Student>();
            students.Add(new Student() { firstName = "Matt", lastName = "Sievers", age = 38, grade = 98 });
            students.Add(new Student() { firstName = "Bob", lastName = "Smith", age = 52, grade = 74 });
            students.Add(new Student() { firstName = "Lisa", lastName = "Jones", age = 22, grade = 85 });
            students.Add(new Student() { firstName = "Carlos", lastName = "Gomez", age = 29, grade = 52 });




            foreach (Student student in students)
            {
                Console.WriteLine("{0} scores is {1} ", student.firstName, student.grade);
            }

            Console.ReadLine();

            var theBestStudents =
                from student in students
                where student.grade > 90
                select student;

            foreach(Student student in theBestStudents)
            {
                Console.WriteLine("{0} has the best oone of the best grades of a {1}", student.firstName, student.grade);
            }

            Console.ReadLine();

            var sortedScores =
                from student in students
                orderby student.grade
                select student;

            foreach (Student student in sortedScores)
            {
                Console.WriteLine("One of the scores was {0}", student.grade);
            }
            Console.ReadLine();

            var bStudents =
                from student in students
                where student.grade < 90 && student.grade > 80
                select student;

            foreach (Student student in bStudents)
            {
                Console.WriteLine("One of our B students is {0} with a grade of {1}", student.firstName, student.grade);
            }
            Console.ReadLine();

            students.Sort();
            Console.WriteLine("Sorted student list using the compareTo() in student class and sort() on the list");
            foreach (Student student in students)
            {
                
                Console.WriteLine(student);
            }

            Console.ReadLine();
        }
    }
}
