using System.Threading;
using Frends.Echo.Execute.Definitions;
using NUnit.Framework;

namespace Frends.Echo.Execute.Tests;

[TestFixture]
public class UnitTests
{
    [Test]
    public void ShouldRepeatContentWithDelimiter()
    {
        var input = new Input { Content = "foobar", Repeat = 3 };

        var connection = new Connection { ConnectionString = "Host=127.0.0.1;Port=12345" };

        var options = new Options { Delimiter = ", ", ThrowErrorOnFailure = true, ErrorMessageOnFailure = null };

        var result = Echo.Execute(input, connection, options, CancellationToken.None);

        Assert.That(result.Output, Is.EqualTo("foobar, foobar, foobar"));
    }
}
