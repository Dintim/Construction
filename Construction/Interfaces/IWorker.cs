using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Interfaces
{
    public enum Position { manager, worker}
    public interface IWorker
    {
        Guid Id { get; }
        string FullName { get; set; }
        double Salary { get; set; }
        Position Position { get; } 
        void PrintInfo();
        double CalcSalary(TimeSpan ts);
        
    }
}
