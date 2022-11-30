namespace Tests
{
    using Applinate;
    using Applinate.Test;
    using Demo;
    using FluentAssertions;

    public class UnitTest:ApplinateTestBase
    {
        // note: since clients aren't allowed to call integrations directly,
        //       this constructor sets the test context to be an orchestrator.
        public UnitTest() : base(Applinate.ServiceType.Orchestration) { }

        [Fact]
        public async Task Test1()
        {
            var result = await new MyDataRequest(10).ExecuteAsync();

            result.Value.Should().Be(11);
        }
    }
}