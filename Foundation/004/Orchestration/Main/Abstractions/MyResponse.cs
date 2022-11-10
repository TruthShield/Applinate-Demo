namespace Demo
{
    public sealed class MyResponse : IHaveResponseStatus
    {
        public MyResponse(ResponseStatus status, int value1)
        {
            Status = status;
            Value1 = value1;
        }

        public ResponseStatus Status { get; }
        public int Value1 { get; }
    }
}