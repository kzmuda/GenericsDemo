using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericsDemo.Models;

namespace GenericsDemo
{
    public class GenericTextFileProcessor
    {
        public static void SaveData<T>(List<T> list, string filePath)
        {
            List<string> lines = new List<string>();

            // add a header row
            lines.Add("FirstName,LastName,Age");

            foreach (var element in list)
            {
                lines.Add(element.ToString());
            }

            System.IO.File.WriteAllLines(filePath, lines);
        }

        public static List<T> LoadFromTextFile<T>(string filePath) where T : ICreator, new()
        {
            List<T> output = new List<T>();
            var lines = System.IO.File.ReadAllLines(filePath).ToList();

            // remove the header row
            lines.RemoveAt(0);

            foreach (var line in lines)
            {
                T p = new T();
                p.FillProperties(line);

                output.Add(p);
            }

            return output;
        }

    }
}
