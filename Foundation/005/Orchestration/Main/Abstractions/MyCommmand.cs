namespace Demo
{
    [ServiceRequest(ServiceType.Orchestration)]
    public sealed class MyCommmand:ICommand
    {
        public MyCommmand(int arg1)
        {
            Arg1 = arg1;
        }

        public int Arg1 { get; }
    }
}