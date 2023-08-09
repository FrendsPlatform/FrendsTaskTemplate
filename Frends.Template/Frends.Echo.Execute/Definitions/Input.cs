// <copyright file="Input.cs" company="Frends">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Frends.Echo.Execute.Definitions;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Parameters class usually contains parameters that are required.
/// </summary>
public class Input
{
    /// <summary>
    /// Something that will be repeated.
    /// </summary>
    /// <example>Some example of the expected value.</example>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue("Lorem ipsum dolor sit amet.")]
    public string Content { get; set; }
}