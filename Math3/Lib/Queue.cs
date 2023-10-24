using System;

namespace Math3.Lib
{
    public class Queue : IElement, IGet, INotifiable
    {
        private readonly IGet _element;
        private readonly uint _capacity;
        private uint _requests = 0;
        private bool _nextIsEmpty = true;

        public Queue(IGet element, uint capacity)
        {
            _element = element;
            _capacity = capacity;
        }

        public void Get()
        {
            if (_requests < _capacity)
            {
                _requests++;
            }
        }


        public void NotifyEmpty()
        {
            _nextIsEmpty = true;
        }

        public void NotifyNotEmpty()
        {
            _nextIsEmpty = false;
        }

        public void Tick()
        {
            if (_nextIsEmpty && _requests > 0)
            {
                _element.Get();
                _requests--;
            }
        }
    }
}
