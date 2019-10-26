﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.DataCollection.Common.Protocols
{
    /// <summary>
    /// 监听呼叫
    /// </summary>
    public class MonitorCallResponse : Sys.DataCollection.Common.Protocols.DeviceProtocol
    {
        /// <summary>
        /// 响应代码, 0表示成功, 其他表示失败
        /// </summary>
        public string retCode { get; set; }
    }
}
