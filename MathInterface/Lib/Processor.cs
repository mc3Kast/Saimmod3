
namespace Math3.Lib
{
    public class Processor : IElement, IGet
    {
        private readonly Random _random;
        private readonly float _processProbability;
        private readonly IGet _element;
        private bool _busy = false;

        public Processor(Random random, float p, IGet element)
        {
            _random = random;
            _processProbability = 1 - p;
            _element = element;
        }

        public bool Get()
        {
            if (!_busy)
            {
                _busy = true;
                return true;
            }
            else return false;
        }

        public void Tick()
        {
            if (_busy)
            {
                if (_random.NextSingle() < _processProbability)
                {
                    _busy = false;
                    _element.Get();
                }
            }
        }
    }
}
