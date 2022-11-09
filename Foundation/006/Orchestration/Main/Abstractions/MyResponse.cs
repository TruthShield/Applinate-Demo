namespace Demo
{
    public sealed class MyResponse : IHaveRequestStatus
    {
        public MyResponse(RequestStatus status, int value)
        {
            Status = status;
            Value = value;
        }

        public RequestStatus Status { get; }
        public int Value { get; }
    }
}