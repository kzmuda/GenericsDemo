using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace GenericsDemo
{
    public class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }

        public TValue Value { get; set; }
    }
}
