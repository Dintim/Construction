using Construction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.Model
{
    public class HouseProject
    {
        public HouseProject()
        {
            Team.CreateTeam();
            this.CreateProject();
        }
        private Team Team = new Team();
        public List<IPart> parts = new List<IPart>();
        public List<ITask> tasks = new List<ITask>();
        

        public void StartBuilding()
        {
            foreach (IPart ipart in parts)
            {

            }
        }
        public void CreateProject()
        {

        }
    }
}
