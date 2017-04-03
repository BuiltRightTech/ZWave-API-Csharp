/* 
 *	Copyright (C) 2017 ZWave-API-CSharp
 *	http://www.brtservice.com/programming/ZWave-API-CSharp
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation; either version 3, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/lesser.html
 *
 */

using NLog;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZWaveAPI
{
    public class ZWPort
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static SerialPort sp = new SerialPort();

        private Thread recThread;
        private Thread sendThread;

        public ZWPort()
        {
            // Set up Receiver Thread
            try
            {
                recThread = new Thread(new ThreadStart(ReceiveMessage));
                recThread.Start();
                logger.Info("The Receive Thread has started.");
            }
            catch
            {
                logger.Error("Receiver Thread failed to start");
            }
            //Set up Send Thread
            try
            {
                sendThread = new Thread(new ThreadStart(SendMessage));
                sendThread.Start();
                logger.Info("The send Thread has started.");
            }
            catch
            {
                logger.Error("Send Thread failed to start");
            }
        }

        /// <summary>
        /// Send message if there is one in the queue to specific ZWave Device
        /// </summary>
        private void SendMessage()
        {
            while(true)
            {
                if(sp.IsOpen)
                {
                    
                }
            }
        }

        private void ReceiveMessage()
        {
            throw new NotImplementedException();
        }
    }
}
