using Xunit;

namespace XUnitTests;

public class XUnitTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1337, 1336 + 1);
    }
}