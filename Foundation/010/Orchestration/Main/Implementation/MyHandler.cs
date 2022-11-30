namespace Demo
{
    internal sealed class MyHandler :
        IRequestHandler<MyRequest, MyResponse>
    {
        public async Task<MyResponse> ExecuteAsync(
            MyRequest arg, 
            CancellationToken cancellationToken = default)
        {
            var dataResponse = await new MyDataRequest(234).ExecuteAsync(cancellationToken).ConfigureAwait(false);

            var returnValue  = dataResponse.Value + arg.Value;

            var response     = new MyResponse(ResponseStatus.Success, returnValue);

            return response;
        }
    }
}