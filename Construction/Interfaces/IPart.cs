using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Interfaces
{
    public interface IPart
    {
        string Name { get; set; }
        double Price { get; set; }
        int Count { get; set; }
        ITask Task { get; set; }
        string GetInfo();
    }
}
