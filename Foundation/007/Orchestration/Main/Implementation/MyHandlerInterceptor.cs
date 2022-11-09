namespace Demo
{
    using System.Threading;

    internal sealed class MyHandlerInterceptor : RequestInterceptorBase<MyRequest, MyResponse>
    {
        public MyHandlerInterceptor(ExecuteDelegate<MyRequest, MyResponse> core) : base(core)
        {
        }

        public override Task<MyResponse> ExecuteAsync(MyRequest arg, CancellationToken cancellationToken)
        {
            Console.WriteLine("Intercepting the behavior completely");

            return Task.FromResult(new MyResponse(RequestStatus.Success, 0));
        }
    }
}