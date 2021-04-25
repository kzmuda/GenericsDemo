using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo.Models
{
    public class Person : ICreator
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName},{this.LastName},{this.Age}";
        }

        public void FillProperties(string line)
        {
            var vals = line.Split(',');
            this.FirstName = vals[0];
            this.LastName = vals[1];
            this.Age = int.Parse(vals[2]);
        }


    }
}
