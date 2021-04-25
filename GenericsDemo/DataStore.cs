using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class DataStore<Typ>
    {
        public int COunt { get; set; }

        public Typ Data { get; set; }

        public void Save(Typ data)
        {

        }
    }
}
