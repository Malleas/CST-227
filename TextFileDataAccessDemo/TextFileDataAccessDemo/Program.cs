using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileDataAccessDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string filePath = @"C:\demos\text.txt";
                if (filePath == null)
                {
                    throw new Exception();
                }

                List<Person> people = new List<Person>();
                List<String> lines = File.ReadAllLines(filePath).ToList();

                int lineCount = 1;

                foreach (string line in lines)
                {




                    string[] entries = line.Split(',');
                    Person p = new Person();
                    if (entries.Length - 1 <= 2)
                    {
                        p.firstName = entries[0];
                        p.lastName = entries[1];
                        p.Url = entries[2];

                        people.Add(p);
                        lineCount += 1;
                    }
                    else
                    {
                        throw new Exception("Error found on line " + lineCount.ToString() + "." + "\n" + "Input does not match FirstName, LastName, URL");
                    }


                }
                List<String> outputLines = new List<string>();
                Console.WriteLine("Here is the list of the people from your file:");
                foreach (Person p in people)
                {
                    Console.WriteLine("First Name: " + p.firstName + " Last Name: " + p.lastName + " Website: " + p.Url);

                    outputLines.Add("First Name: " + p.firstName + " Last Name: " + p.lastName + " Website: " + p.Url + "\n");
                }

                string outPath = @"C:\demos\peopleOut.txt";
                File.WriteAllLines(outPath, outputLines);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}
