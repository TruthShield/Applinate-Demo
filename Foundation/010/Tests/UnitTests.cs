namespace Tests
{
    using Applinate;
    using Applinate.Test;
    using Demo;
    using FluentAssertions;

    public class UnitTests: ApplinateTestBase
    {
        public UnitTests() : base(ServiceType.Client) { }

        [Fact]
        public async Task QueryWorks()
        {
            var response = await new MyRequest(10).ExecuteAsync().ConfigureAwait(false);

            _ = response.Status.Should().Be(ResponseStatus.Success);
        }

    }
}