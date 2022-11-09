namespace Demo
{
    using System.Threading.Tasks;

    internal sealed class MyHandlerInterceptor : RequestInterceptorBase<MyRequest, MyResponse>
    {
        public MyHandlerInterceptor(ExecuteDelegate<MyRequest, MyResponse> core) : base(core)
        {
        }

        protected override Task<MyRequest> PreProcessAsync(MyRequest request)
        {
            Console.WriteLine("modifying the request");

            var modifiedRequest = new MyRequest(request.Arg + 1);

            return base.PreProcessAsync(modifiedRequest);
        }

        protected override Task<MyResponse> PostProcessAsync(MyResponse response)
        {
            Console.WriteLine("modifying the response");

            var modifiedResponse = new MyResponse(response.Status, response.Value + 1);

            return base.PostProcessAsync(modifiedResponse);
        }
    }
}