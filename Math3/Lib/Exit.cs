
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
