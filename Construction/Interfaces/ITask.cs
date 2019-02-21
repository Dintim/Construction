using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Interfaces
{
    public enum Status { create, process, complite}
    public interface ITask
    {
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        Status Status { get; set; }
        Guid IdWorker { get; set; }
    }
}
