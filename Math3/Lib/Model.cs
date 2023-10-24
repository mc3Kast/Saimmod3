using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3.Lib
{
    public class Model
    { 
        private Random _random = new Random();
        public Model() 
        {
            Exit exit = new Exit();
            Processor processor2 = new Processor();
            Processor processor1 = new Processor();
            Queue queue = new Queue();
            Generator generator = new Generator();
        }
    }
}
