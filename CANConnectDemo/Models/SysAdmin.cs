using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWork;

namespace Models
{
    /// <summary>
    ///  管理用户
    /// </summary>
    public class SysAdmin :BaseModel
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
    }
}
