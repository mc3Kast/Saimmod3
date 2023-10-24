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
        public Exit exit;
        public Processor processor2;
        public Processor processor1;
        public Queue queue;
        public Generator generator;

        public Model() 
        {
            exit = new Exit();
            processor2 = new Processor(_random, 0.45f, exit);
            processor1 = new Processor(_random, 0.40f, processor2);
            queue = new Queue(processor1, 1);
            generator = new Generator(queue);
        }

        public void Run(int n)
        {
            for (int i = 0; i < n; i++)
            {
                processor2.Tick();
                processor1.Tick();
                queue.Tick();
                generator.Tick();
            }
        }
    }
}
