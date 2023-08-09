// <copyright file="Frends.Echo.Execute.Tests.cs" company="Frends">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Frends.Echo.Execute.Tests;

using System;
using Frends.Echo.Execute.Definitions;
using NUnit.Framework;

/// <summary>
/// Test class.
/// </summary>
[TestFixture]
internal class TestClass
{
    /// <summary>
    /// You need to run Frends.Community.Echo.SetPaswordsEnv.ps1 before running unit test, or some other way set environment variables e.g. with GitHub Secrets.
    /// </summary>
    [Test]
    public void ThreeEchos()
    {
        var input = new Input
        {
            Content = Environment.GetEnvironmentVariable("EXAMPLE_ENVIROMENT_VARIABLE"),
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
