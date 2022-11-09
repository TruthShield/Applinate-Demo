namespace Demo
{
    internal sealed class MyMessageInterceptorFactory: InterceptorFactoryBase
    {
        public override async Task<TResult> ExecuteAsync<TArg, TResult>(ExecuteDelegate<TArg, TResult> next, TArg arg, CancellationToken cancellationToken)
        {
            Console.WriteLine($"intercepted a {typeof(TArg)} message");

            Console.WriteLine("pre-execution processing");

            var result = await next(arg, cancellationToken);

            Console.WriteLine("post execution processing");

            return result;
        }
    }
}