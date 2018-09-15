using System;
using ZooInterface;

namespace Vertebrates
{
    class Bullfrog
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = false;
        public bool BornHardShellEgg { get; set; } = true;
        public string LivesInWater { get; set; } = "Yes and no";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = false;
        public bool Fins { get; set; } = false;
        public string Blooded { get; set; } = "cold";
        public bool BornOnLand { get; set; } = true;

        void IVertebrates.Walk()
        {
            Console.WriteLine("Bullfrongs juuuump!");
        }

        void IVertebrates.Swim()
        {
            Console.WriteLine("They play near water...maybe swim?");
        }

        void IVertebrates.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
