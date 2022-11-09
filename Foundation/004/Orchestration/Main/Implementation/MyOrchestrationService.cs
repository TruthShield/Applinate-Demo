namespace Demo
{
    internal sealed class MyOrchestrationService : IMyOrchestrationService
    {
        public Task<MyResponse> ExecuteMyRequestAsync(MyRequest request, CancellationToken cancellationToken)
        {
            var response = new MyResponse(RequestStatus.Success, request.Arg1 + request.Arg2);
            return Task.FromResult(response);
        }
    }
}