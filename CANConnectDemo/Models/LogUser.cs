using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using FrameWork;

namespace Models
{
    /// <summary>
    ///  登录用户 暂无数据库
    /// </summary>
    public class LogUser :BaseModel
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
        
    }
}
