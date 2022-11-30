namespace Demo
{
    public sealed class MyDataResponse : IHaveResponseStatus
    {
        public MyDataResponse(ResponseStatus status, int value)
        {
            Status = status;
            Value = value;
        }

        public ResponseStatus Status { get; }
        public int Value { get; }
    }
}