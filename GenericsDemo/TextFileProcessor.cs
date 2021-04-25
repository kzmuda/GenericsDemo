using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericsDemo.Models;

namespace GenericsDemo
{
    public class TextFileProcessor
    {
        public static void SavePeople(List<Person> people, string filePath)
        {
            List<string> lines = new List<string>();

            // add a header row
            lines.Add("FirstName,LastName,Age");
            foreach (var person in people)
            {
                lines.Add($"{person.FirstName},{person.LastName},{person.Age}");
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public static void SaveLogEntry(List<LogEntry> people, string filePath)
        {
            List<string> lines = new List<string>();

            // add a header row
            lines.Add("Message,Date");
            foreach (var person in people)
            {
                lines.Add(person.ToString());
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public static List<Person> LoadPeople(string filePath)
        {
            List<Person> output = new List<Person>();
            var lines = System.IO.File.ReadAllLines(filePath).ToList();

            // remove the header row
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                var vals = line.Split(',');
                Person p = new Person();
                p.FirstName = vals[0];
                p.LastName = vals[1];
                p.Age = int.Parse(vals[2]);

                output.Add(p);
            }

            return output;
        }

        
    }
}
