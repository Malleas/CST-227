using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Student : IComparable<Student>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public int grade { get; set; }

        public int CompareTo(Student other)
        {
            if (this.age == other.age)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            else if (this.grade == other.grade)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            return other.age.CompareTo(this.age);
        }

        public override string ToString()
        {
            return this.firstName + ","
                + this.lastName + ","
                + this.age.ToString() + ","
                + this.grade.ToString();
        }
    }
}
