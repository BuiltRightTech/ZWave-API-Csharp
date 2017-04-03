using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWaveAPI.Enum
{
    public enum ApplicationUpdate
    {
        NODE_INFO_RECEIVED = 0x84,
        NODE_INFO_REQ_DONE = 0x82,
        NODE_INFO_REQ_FAILED = 0x81,
        ROUTING_PENDING = 0x80,
        NEW_ID_ASSIGNED = 0x40,
        DELETE_DONE = 0x20,
        SUC_ID = 0x10
    }
}
