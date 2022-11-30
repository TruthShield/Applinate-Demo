namespace Demo
{
    [ServiceRequest(ServiceType.Orchestration)]
    public sealed class MyCommand : ICommand
    {
        public MyCommand(int arg)
        {
            Arg = arg;
        }

        public int Arg { get; }
    }
}