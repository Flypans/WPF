using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplate
{


    public class Players
    {
        public string Name { get; set; } = "";
        public string Birthday { get; set; } = "";
        public string Team { get; set; } = "";
        public string Salary { get; set; } = "";

        public override string ToString()
        {
            return $"Name : {Name}, Birthday : {Birthday}, School: {Team}, Salary : {Salary}";
        }

        public static List<Players> GetPlayers()
        {
            return new List<Players>
            {
                new Players{Name="Marco Reus", Birthday="19890531", Salary="1200", Team="BVB"},
                new Players { Name = "Niklas Süle", Birthday = "19950930", Salary = "1000", Team = "BVB" },
                new Players { Name = "Emre Can", Birthday = "19940112", Salary = "900", Team = "BVB" },
                new Players { Name = "Mats Hummels", Birthday = "19881216", Salary = "800", Team = "BVB" },
            };
        }
    }
}
