using System;
using ZooInterface;

namespace Vertebrates
{
    class Hawk
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = true;
        public bool BornHardShellEgg { get; set; } = true;
        public string LivesInWater { get; set; } = "No";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = false;
        public bool Fins { get; set; } = false;
        public string Blooded { get; set; } = "warm";
        public bool BornOnLand { get; set; } = false;

        void IVertebrates.Walk()
        {
            Console.WriteLine("Hawks can hop.");
        }

        void IVertebrates.Swim()
        {
            throw new NotImplementedException();
        }

        void IVertebrates.Fly()
        {
            Console.WriteLine("Hawks can fly like an aeroplane.");
        }
    }
}
