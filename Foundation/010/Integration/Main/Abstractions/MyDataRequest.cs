namespace Demo
{
    [ServiceRequest(ServiceType.Integration)]
    public sealed class MyDataRequest : IReturn<MyDataResponse>
    {
        public MyDataRequest(int arg)
        {
            Arg = arg;
        }

        public int Arg { get; }
    }
}