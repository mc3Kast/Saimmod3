
namespace Math3.Lib
{
    public class Exit : IGet
    {
        public uint finishedRequests;

        public Exit()
        {
            finishedRequests = 0;
        }
        public bool Get()
        {
            finishedRequests++;
            return true;
        }
    }
}
