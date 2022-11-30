namespace Demo
{
    public sealed class MyResponse : IHaveResponseStatus
    {
        public MyResponse(ResponseStatus status, int value)
        {
            Status = status;
            Value = value;
        }

        public ResponseStatus Status { get; }
        public int Value { get; }
    }
}