using System;
using System.Collections.Generic;
using System.Text;
using ZooInterface;
using ZooInterface.Invertebrates;

namespace Invertebrates
{
    public class Spider : IInvertebrates
    {
        public bool HasBackbone { get; set; } = false;
        public bool HasExoSkeleton { get; } = true;
        public string Blooded { get; set; } = "cold";
        public int JointedLegCount { get; set; } = 8;
        public int BodySegmentCount { get; set; } = 3;
        public string Fertilization { get; set; } = "external";
        public string Oviparity { get; set; } = "ovoviviparous";

        public void Walk()
        {
            "Spiders walk on webs.";
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
