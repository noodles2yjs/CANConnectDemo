using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork;

namespace Models
{
    [Serializable]
  public  class StandardTempProtectionModel : BaseModel// 温度保护
    {
        public double CutInTemp { get; set; }
        public double CutInTime { get; set; }
        public double Slope { get; set; }
        public double WeakeningRatio { get; set; } // 削弱比
        public double RecoverTime1 { get; set; }
        public double RecoverTime2 { get; set; }
        public double RecoverTemp { get; set; }

    }
}
