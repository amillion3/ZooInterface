using System;
using ZooInterface;

namespace Vertebrates
{
    class Lemur : IVertebrates
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = true;
        public bool HairOnBody { get; set; } = true;
        public bool Feathers { get; set; } = false;
        public bool BornHardShellEgg { get; set; } = false;
        public string LivesInWater { get; set; } = "No";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = false;
        public bool Fins { get; set; } = false;
        public string Blooded { get; set; } = "warm";
        public bool BornOnLand { get; set; } = true;

        void IVertebrates.Walk()
        {
            Console.WriteLine("Lemurs walk and bound!");
        }

        void IVertebrates.Swim()
        {
            throw new NotImplementedException();
        }

        void IVertebrates.Fly()
        {
            Console.WriteLine("Lemurs fly from tree to tree");
        }
    }
}
