using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork;

namespace Models
{
    [Serializable]
   public class StandardPIDModel :BaseModel
    {
        public double  VhicleSpeed{ get; set; }
        public double  KP{ get; set; }
        public double  KI{ get; set; }
        public double  KD{ get; set; }
        public double  DZ{ get; set; }
        public double  Max{ get; set; }
        public double  PCJ{ get; set; }
        public double  PCK{ get; set; }
        public double  PCI{ get; set; }
        public double  PFJ{ get; set; }
        public double  PFK{ get; set; }
        public double  PFI{ get; set; }
    }
}
