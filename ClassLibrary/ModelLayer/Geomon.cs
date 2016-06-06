using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.ModelLayer
{
    public class Geomon
    {
        public Geomon(int Id, string Name, int Rarity, string Type, string Image, int Level, int Evo)
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rarity { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public int Level { get; set; }
        public int Evo { get; set; }

    }
}
