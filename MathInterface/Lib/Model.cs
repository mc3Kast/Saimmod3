﻿using System;
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
            Processor processor2 = new Processor(_random, 0.45f, exit);
            Processor processor1 = new Processor(_random, 0.40f, processor2);
            Queue queue = new Queue(processor1, 1);
            Generator generator = new Generator(queue);
        }
    }
}