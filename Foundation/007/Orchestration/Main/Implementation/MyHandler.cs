namespace Demo
{
    internal sealed class MyHandler : IRequestHandler<MyRequest, MyResponse>
    {
        public Task<MyResponse> ExecuteAsync(
            MyRequest arg, 
            CancellationToken cancellationToken = default)
        {
            Console.WriteLine("This will not be executed, the call has been intercepted");

            var response = new MyResponse(ResponseStatus.Success, arg.Arg);
            return Task.FromResult(response);
        }
    }
}