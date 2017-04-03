using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZWaveAPI.Enum;

namespace ZWaveAPI.Message
{
    public class Message
    {
        public FrameHeader FrameHeader { get; private set; }
        public MessageType MessageType { get; private set; }
        public Function Function { get; private set; }
        public byte NodeId { get; private set; }

        public TransmitOptions TransmitOptions { get; private set; }
        public byte[] Command { get; private set; }
        public byte Level { get; private set; }
        public byte CallBackId { get; private set; }
        public byte InstanceId { get; set; }

        public byte[] buffer;
        public string logText;
    }
}
