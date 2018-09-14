using System;
using System.Collections.Generic;
using System.Text;

namespace ZooInterface
{
    interface IAnimal
    {
        bool NursesYoung { get; }
        bool HairOnBody { get; }
        bool Feathers { get; }
        bool BornHardShellEgg { get; }
        string LivesInWater { get; }
        bool Gills { get; }
        bool Scales { get; }
        bool Fins { get; }
        string Blooded { get; }
        bool BornOnLand { get; }

    }
}
