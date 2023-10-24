using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3.Lib
{
    public class Exit : IGet
    {
        public uint finishedRequests = 0;
        public void Get()
        {
            finishedRequests++;
        }
    }
}
