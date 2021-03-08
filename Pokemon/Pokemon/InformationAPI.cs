using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class InformationAPI
    {
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public sprites sprites { get; set; }
        public override string ToString()
        {
            return $"Name: {name}, Height: {height}, Weight: {weight}";
        }
    }

    public class sprites
    {
        public string front_default { get; set; }
        public string back_default { get; set; }
    }
}
