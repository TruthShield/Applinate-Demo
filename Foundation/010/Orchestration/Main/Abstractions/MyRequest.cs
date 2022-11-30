namespace Demo
{
    [ServiceRequest(ServiceType.Orchestration)]
    public sealed class MyRequest : IReturn<MyResponse>
    {
        public MyRequest(int arg)
        {
            Value = arg;
        }

        public int Value { get; }
    }
}