using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_ja_liikmed
{
    public class Type
    {
        public string Name { get; }
        public int Age { get; }
        public string Color { get; }

        public Type(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
    }
}
