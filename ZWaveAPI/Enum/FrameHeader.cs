﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWaveAPI.Enum
{
    public enum FrameHeader
    {
        /// <summary>
        /// Start of frame
        /// </summary>
        SOF = 0x01,
        /// <summary>
        /// Acknowledge
        /// </summary>
        ACK = 0x06,
        /// <summary>
        /// Negative acknowledge
        /// </summary>
        NAK = 0x15,
        /// <summary>
        /// Cancel
        /// </summary>
        CAN = 0x18
    }
}
