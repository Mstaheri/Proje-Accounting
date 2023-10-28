using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCompanyDAL
{
    public class CurrentSocket
    {
        public Socket currentsock;
        public byte[] buffer;

        public CurrentSocket(Socket currentsock, byte[] buffer = null)
        {
            this.currentsock = currentsock;
            this.buffer = buffer;
        }
    }
}
