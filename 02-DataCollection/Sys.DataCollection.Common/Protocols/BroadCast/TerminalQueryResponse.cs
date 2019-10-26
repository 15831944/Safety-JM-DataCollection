﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.DataCollection.Common.Protocols
{
    /// <summary>
    /// 终端管理
    /// </summary>
    public class TerminalQueryResponse : Sys.DataCollection.Common.Protocols.DeviceProtocol
    {
        /// <summary>
        /// 响应代码, 0表示成功, 其他表示失败
        /// </summary>
        public string retCode { get; set; }
        /// <summary>
        /// 分区标识
        /// </summary>
        public string zoneId { get; set; }
        /// <summary>
        /// 分区标识
        /// </summary>
        public List<TermInfo> termList { get; set; }
    }

}
