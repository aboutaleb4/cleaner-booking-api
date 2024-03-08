using Domain;
using FluentAssertions;
using Xunit;

namespace Testing;

public class CleanerTests
{
    [Fact]
    public void DomainTest()
    {
        var cleaner = new Cleaner(1, "Ahmed");
        cleaner.Should().BeEquivalentTo(new Cleaner(1, "Ahmed"));
    }
}