using System;
using System.Collections;
using System.Collections.Generic;
using GenericsDemo.Models;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> strStore = new DataStore<string>();

            StringDataStore str = new StringDataStore();


            DemoTextFileFileStorage();

        }

        private static void DemoTextFileFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> entries = new List<LogEntry>();

            PopulateList(people, entries);

            string peopleFile = @"D:\TMP\people.csv";
            string logFile = @"D:\TMP\log.csv";

            // TextFileProcessor.SavePeople(people, peopleFile);
            GenericTextFileProcessor.SaveData<Person>(people, peopleFile);

            // var newPeople = TextFileProcessor.LoadPeople(peopleFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);
            foreach (var person in newPeople)
            {
                Console.Out.WriteLine(person.LastName);
            }

        }

        private static void PopulateList(List<Person> people, List<LogEntry> entries)
        {
            people.Add(new Person { FirstName = "Anna", LastName = "Kowalska", Age = 20 });
            people.Add(new Person { FirstName = "Jan", LastName = "Malinowski", Age = 18 });
            people.Add(new Person { FirstName = "Olga", LastName = "Nowak", Age = 32 });

            entries.Add(new LogEntry { ErrorMessage = "Null reference exception", EventDate = DateTime.Now});
            entries.Add(new LogEntry { ErrorMessage = "Fatal error", EventDate = DateTime.Now });
        }
    }
}
