using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Cours11.Models
{
    public class Database
    {
        public List<Dragon> Dragons { get; set; }
        public List<DragonTrainer> Trainers { get; set; }

        public Database()
        {
            Dragons = new List<Dragon>();
            Trainers = new List<DragonTrainer>();

            Dragons.Add(new Dragon(1, "Charizard", "charizard"));
            Dragons.Add(new Dragon(2, "Drogon", "drogon"));
            Dragons.Add(new Dragon(3, "Elizabeth", "shrek"));
            Dragons.Add(new Dragon(4, "Spyro", "spyro"));
            Dragons.Add(new Dragon(5, "Toothless", "toothless"));
            Dragons.Add(new Dragon(6, "Blue Eyes White Dragon", "whitedragon"));
            Dragons.Add(new Dragon(7, "Mushu", "mushu"));
            Dragons.Add(new Dragon(8, "Smaug", "smaug"));

            Trainers.Add(new DragonTrainer(1, "Daenerys", 3));
            Trainers.Add(new DragonTrainer(2, "Hiccup", 1));
            Trainers.Add(new DragonTrainer(3, "Ash", 2));
        }
    }
}
