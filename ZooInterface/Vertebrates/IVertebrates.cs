using System;
using System.Collections.Generic;
using System.Text;

namespace ZooInterface
{
    interface IVertebrates
    {
        bool HasBackbone { get; }
        bool NursesYoung { get; }
        bool HairOnBody { get; }
        bool Feathers { get; }
        bool BornHardShellEgg { get; }
        string LivesInWater { get; }
        bool Gills { get; }
        bool Scales { get; }
        bool Fins { get; }
        string Blooded { get; } // cold or warm
        bool BornOnLand { get; }

        void Walk();
        void Swim();
        void Fly();
    }
}
