using System;

using System.Collections.Generic;
using System.Text;

namespace ZooInterface.Invertebrates
{
    public interface IInvertebrates
    {
        bool HasBackbone { get; }
        bool HasExoSkeleton { get; }
        string Blooded { get; } // cold or warm
        int JointedLegCount { get; }
        int BodySegmentCount { get; }
        string Fertilization { get; } // internal or external
        string Oviparity { get; } // oviparous or ovoviviparous


        void Walk();
        void Swim();
        void Fly();
    }
}
