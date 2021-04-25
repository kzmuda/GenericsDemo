using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo.Models
{
    public class LogEntry
    {
        public string ErrorMessage { get; set; }

        public DateTime EventDate { get; set; }


        public override string ToString()
        {
            return $"{this.ErrorMessage} {this.EventDate}";
        }
    }
}
