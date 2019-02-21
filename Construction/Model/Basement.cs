using Construction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Model
{
    public class Basement : IPart
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public ITask Task { get; set; }

        public string GetInfo()
        {
            return string.Format("Наименование: {0} ({1})\nЦена: {2}", Name, Count, Price);
        }
    }
}
