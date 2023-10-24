﻿using System;

namespace Math3.Lib
{
    public class Processor : IElement, IGet
    {
        private readonly Random _random;
        private readonly float _processProbability;
        private readonly IGet _element;
        private readonly INotifiable? _queue;
        private bool _busy = false;

        public Processor(Random random, float p, IGet element, INotifiable? queue)
        {
            _random = random;
            _processProbability = 1 - p;
            _element = element;
            if (queue != null)
            {
                _queue = queue;
            }
        }

        public void Get()
        {
            if (!_busy)
            {
                _busy = true;
            }
        }

        public void Tick()
        {
            if (_busy)
            {
                _queue.NotifyNotEmpty();
                if (_random.NextDouble() < _processProbability)
                {
                    _busy = false;
                    _element.Get();
                    _queue.NotifyEmpty();
                }
            }
        }
    }
}
