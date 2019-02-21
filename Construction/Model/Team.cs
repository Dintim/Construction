using Construction.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser;


namespace Construction.Model
{
    public class Team
    {
        public List<IWorker> team = new List<IWorker>();
        public void CreateTeam()
        {
            //GenerateUser user = new GenerateUser();
            Random rnd = new Random();
            GenerateUser user1 = new GenerateUser();
            Worker w1 = new Worker(Position.worker);
            w1.FullName = user1.GetUser().name.first + user1.GetUser().name.last;
            w1.Salary = rnd.Next(1000, 5000);
            this.team.Add(w1);
            
            for (int i = 0; i < rnd.Next(4,20); i++)
            {
                GenerateUser user = new GenerateUser(); 
                Worker w = new Worker(Position.worker);
                w.FullName = user.GetUser().name.first + user.GetUser().name.last;
                w.Salary = rnd.Next(1000, 5000);
                team.Add(w);
            }

        }
    }
}
