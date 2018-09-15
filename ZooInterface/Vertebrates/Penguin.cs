using System;
using ZooInterface;

namespace Vertebrates
{
    class Penguin : IVertebrates
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = true;
        public bool BornHardShellEgg { get; set; } = true;
        public string LivesInWater { get; set; } = "No";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = false;
        public bool Fins { get; set; } = true;
        public string Blooded { get; set; } = "cold";
        public bool BornOnLand { get; set; } = true;

        void IVertebrates.Walk()
        {
            Console.WriteLine("Penguins waddle, a form of walking.");
        }

        void IVertebrates.Swim()
        {
            Console.WriteLine("The Penguin swims in chilly water.");
        }

        void IVertebrates.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
