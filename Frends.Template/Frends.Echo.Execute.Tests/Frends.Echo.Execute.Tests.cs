namespace Frends.Echo.Execute.Tests;

using Frends.Echo.Execute.Definitions;
using NUnit.Framework;

/// <summary>
/// Test class.
/// </summary>
[TestFixture]
internal class TestClass
{
    [Test]
    public void ThreeEchos()
    {
        var input = new Input
        {
            Content = "foobar",
        };

        var options = new Options
        {
            Amount = 3,
            Delimiter = ", ",
        };

        var ret = Echo.Execute(input, options, default);

        Assert.That(ret.Output, Is.EqualTo("foobar, foobar, foobar"));
    }
}
