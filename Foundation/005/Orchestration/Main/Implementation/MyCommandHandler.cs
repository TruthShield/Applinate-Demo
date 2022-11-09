namespace Demo
{
    internal sealed class MyCommandHandler : ICommandHandler<MyCommmand>
    {
        public Task<CommandResponse> ExecuteAsync(MyCommmand arg, CancellationToken cancellationToken = default)
        {
            Console.WriteLine("recieved command with " + arg.Arg1);

            return Task.FromResult(CommandResponse.Success);
        }
    }
}