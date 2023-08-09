// <copyright file="Result.cs" company="Frends">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Frends.Echo.Execute.Definitions;

/// <summary>
/// Parameters class usually contains parameters that are required.
/// </summary>
public class Result
{
    internal Result(string output)
    {
        this.Output = output;
    }

    /// <summary>
    /// Contains the input repeated the specified number of times.
    /// </summary>
    /// <example>Example of the output.</example>
    public string Output { get; private set; }
}
