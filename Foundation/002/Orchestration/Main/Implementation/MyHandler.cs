namespace Demo
{
    internal sealed class MyHandler : IRequestHandler<MyRequest, MyResponse>
    {
        public Task<MyResponse> ExecuteAsync(
            MyRequest arg, 
            CancellationToken cancellationToken = default)
        {
            var response = new MyResponse(ResponseStatus.Success, arg.Arg1 + arg.Arg2);
            return Task.FromResult(response);
        }
    }
}