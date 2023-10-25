
namespace Math3.Lib
{
    public class Queue : IElement, IGet
    {
        private readonly IGet _element;
        private readonly uint _capacity;
        private uint _requests = 0;
        public uint ticksInQueue = 0;

        public Queue(IGet element, uint capacity)
        {
            _element = element;
            _capacity = capacity;
        }

        public bool Get()
        {
            if (_requests < _capacity)
            {
                _requests++;
                if (_element.Get())
                {
                    _requests--;
                }
                else ticksInQueue++;
                return true;
            }
            else return false;
        }

        public void Tick()
        {
            if (_requests > 0)
            {
                if (_element.Get())
                {
                    _requests--;
                }
                else ticksInQueue++;
            }
        }
    }
}
