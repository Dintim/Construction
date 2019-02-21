using Construction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Model
{
    //public class TeamLeader:Worker
    //{
    //    public override double CalcSalary(TimeSpan ts)
    //    {
    //        return base.CalcSalary(ts) * 0.5;
    //    }
    //}

    public class TeamLeader : IWorker
    {
        public TeamLeader()
        {
            Id = Guid.NewGuid();
            Position = Position.manager;
        }
        public Guid Id { get; private set; }
        public string FullName { get; set; }
        public double Salary { get; set; }
        public Position Position { get; private set; }

        public virtual double CalcSalary(TimeSpan ts)
        {
            return ts.TotalHours * Salary*0.5;
        }

        public void PrintInfo()
        {
            Console.WriteLine("id: {0}name: \n{1}position: \n{2}\nsalary: {3}\n-----------------------------\n", Id, FullName, Position, Salary);
        }
    }
}
