namespace Demo
{
    [ServiceRequest(ServiceType.Orchestration)]
    public sealed class MyRequest:IReturn<MyResponse>
    {
        public MyRequest(int arg1, int arg2)
        {
            Arg1 = arg1;
            Arg2 = arg2;
        }

        public int Arg1 { get; }
        public int Arg2 { get; }
    }
}