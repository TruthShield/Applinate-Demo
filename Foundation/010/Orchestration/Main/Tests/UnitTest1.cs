namespace Tests
{
    using Applinate;
    using Applinate.Test;
    using Demo;

    public class UnitTest1:ApplinateTestBase
    {
        // note: calling the base constructure to configure the test environment
        public UnitTest1() : base() { }

        [Fact]
        public async Task Test()
        {
            var dataValue = 123;

            MockRequest<MyDataRequest, MyDataResponse>
                .SetForTestScope(x => new(ResponseStatus.Success, dataValue));

            var requestValue = 345;

            var response = await new MyRequest(requestValue).ExecuteAsync();

            //response.Value.Should().Be(requestValue + dataValue);

        }
    }
}