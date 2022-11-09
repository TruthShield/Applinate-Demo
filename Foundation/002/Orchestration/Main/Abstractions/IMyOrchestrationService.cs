namespace Demo
{
    [Service(ServiceType.Orchestration)]
    public interface IMyOrchestrationService
    {
        Task<MyResponse> ExecuteMyRequestAsync(MyRequest request, CancellationToken cancellationToken);
    }
}