using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours11.Models
{
    public class DragonTrainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NbDragons { get; set; }
        public List<Dragon> Dragons { get; set; }

        public DragonTrainer(int id, string name, int nbDragons)
        {
            Id = id;
            Name = name;
            NbDragons = nbDragons;
            Dragons = new List<Dragon>();
        }

        public DragonTrainer() { }
    }
}
