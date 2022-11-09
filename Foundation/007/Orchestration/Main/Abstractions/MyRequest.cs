namespace Demo
{
    [ServiceRequest(ServiceType.Orchestration)]
    public sealed class MyRequest:IReturn<MyResponse>
    {
        public MyRequest(int arg)
        {
            Arg = arg;
        }

        public int Arg { get; }
    }
}