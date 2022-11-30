namespace Demo
{
    using System.Threading;
    using System.Threading.Tasks;

    internal sealed class MyDataHandler :
            IRequestHandler<MyDataRequest, MyDataResponse>
    {
        public Task<MyDataResponse> ExecuteAsync(MyDataRequest request, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(new MyDataResponse(ResponseStatus.Success, request.Arg + 1));
        }
    }
}