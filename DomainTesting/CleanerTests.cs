using Domain;
using FluentAssertions;
using Xunit;

namespace Testing;

public class CleanerTests
{
    [Fact]
    public void NameTest()
    {
        var cleaner = new Cleaner("Ahmed");
        cleaner.Should().BeEquivalentTo(new Cleaner("Ahmed"));
    }
}