using System;
using dotenv.net;

namespace Frends.Xml.Write.Tests;

public abstract class TestBase
{
    protected TestBase()
    {
        DotEnv.Load();
        SecretKey = Environment.GetEnvironmentVariable("FRENDS_SECRET_KEY");
    }

    protected string SecretKey { get; }
}
