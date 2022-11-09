namespace Demo
{
    internal sealed class MyHandler : IRequestHandler<MyRequest, MyResponse>
    {
        public Task<MyResponse> ExecuteAsync(
            MyRequest arg, 
            CancellationToken cancellationToken = default)
        {
            var response = new MyResponse(RequestStatus.Success, arg.Arg);
            return Task.FromResult(response);
        }
    }
}