using System;
using ZooInterface;

namespace Vertebrates
{
    class Crocodile : IVertebrates
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = false;
        public bool BornHardShellEgg { get; set; } = true;
        public string LivesInWater { get; set; } = "Yes";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = true;
        public bool Fins { get; set; } = false;
        public string Blooded { get; set; } = "cold";
        public bool BornOnLand { get; set; } = false;

        void IVertebrates.Walk()
        {
            Console.WriteLine("Crocodiles move fast.");
        }

        void IVertebrates.Swim()
        {
            Console.WriteLine("Hawks can hop.");
        }

        void IVertebrates.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
