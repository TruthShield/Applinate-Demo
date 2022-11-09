namespace Demo
{
    public sealed class MyResponse : IHaveRequestStatus
    {
        public MyResponse(RequestStatus status, int value1)
        {
            Status = status;
            Value1 = value1;
        }

        public RequestStatus Status { get; }
        public int Value1 { get; }
    }
}