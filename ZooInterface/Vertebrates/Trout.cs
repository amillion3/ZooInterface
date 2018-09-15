using System;
using ZooInterface;

namespace Vertebrates
{
    public class Trout : IVertebrates
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = false;
        public bool BornHardShellEgg { get; set; } = false;
        public string LivesInWater { get; set; } = "Yes";
        public bool Gills { get; set; } = true;
        public bool Scales { get; set; } = true;
        public bool Fins { get; set; } = true;
        public string Blooded { get; set; } = "cold";
        public bool BornOnLand { get; set; } = false;

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            Console.WriteLine("The trout swims like a fish!");
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
