﻿using Sys.DataCollection.Common.Commands;
using Sys.DataCollection.Common.Protocols;
using Sys.DataCollection.Common.Protocols.Devices;
using Sys.DataCollection.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sys.DataCollection.Driver
{
    /// <summary>
    /// 分站历史控制记录请求
    /// </summary>
    public class QueryHistoryControlRequestCommand : QueryHistoryControlRequest
    {
        /// <summary>
        /// 设备分站信息
        /// </summary>
        public DeviceInfo def;
        public byte[] ToBytes()
        {
            byte[] bytes = null;
            bytes = new byte[11];
            bytes[0] = 0x5A;
            bytes[1] = 0xA5;
            bytes[2] = 0x7E;
            bytes[3] = 0xE7;
            bytes[4] = (byte)def.Fzh;
            bytes[5] = 0x58;
            CommandUtil.ConvertInt16ToByte((ushort)(bytes.Length - 4), bytes, 6);//长度,6,7        
            bytes[8] = (byte)(this.LastAcceptFlag);
            CommandUtil.CRC16_CCITT(bytes, 4, bytes.Length - 2);//累加和
            return bytes;
        }
    }
}
