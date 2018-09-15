using System;
using ZooInterface;

namespace Vertebrates
{
    public class Salamander: IVertebrates
    {
        public bool HasBackbone { get; set; } = true;
        public bool NursesYoung { get; set; } = false;
        public bool HairOnBody { get; set; } = false;
        public bool Feathers { get; set; } = false;
        public bool BornHardShellEgg { get; set; } = false;
        public string LivesInWater { get; set; } = "Yes";
        public bool Gills { get; set; } = false;
        public bool Scales { get; set; } = true;
        public bool Fins { get; set; } = false;
        public string Blooded { get; set; } = "cold";
        public bool BornOnLand { get; set; } = true;

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            Console.WriteLine("The salamander struts.");
        }
    }
}
