using System;
using System.Collections.Generic;
using System.Text;
using ZooInterface;
using ZooInterface.Invertebrates;

namespace ZooInterface.Vertebrates
{
    public class Turtle : IVertebrates
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = false;
        public bool BornHardShellEgg { get; set; } = true;
        public string LivesInWater { get; set; } = "Yes";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = false;
        public bool Fins { get; set; } = true;
        public string Blooded { get; set; } = "cold";
        public bool BornOnLand { get; set; } = true;

        void IVertebrates.Walk()
        {
            throw new NotImplementedException();
        }

        void IVertebrates.Swim()
        {
            Console.WriteLine("The turtle swims gracefully");
        }

        void IVertebrates.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
