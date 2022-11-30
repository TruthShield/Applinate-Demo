namespace Demo
{
    internal sealed class MyHandler :
        IRequestHandler<MyRequest, MyResponse>,
        ICommandHandler<MyCommand>
    {
        public Task<MyResponse> ExecuteAsync(
            MyRequest arg, 
            CancellationToken cancellationToken = default)
        {
            var response = new MyResponse(ResponseStatus.Success, arg.Arg);
            return Task.FromResult(response);
        }

        public Task<CommandResponse> ExecuteAsync(MyCommand request, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(CommandResponse.Success);
        }
    }
}