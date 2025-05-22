using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Echo.Execute.Definitions;

/// <summary>
/// Additional parameters.
/// </summary>
public class Options
{
    /// <summary>
    /// Delimiter to use between the repeated strings.
    /// </summary>
    /// <example>,</example>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue(" ")]
    public string Delimiter { get; set; }

    /// <summary>
    /// Whether to throw an error on failure.
    /// </summary>
    [DefaultValue(true)]
    public bool ThrowErrorOnFailure { get; set; }

    /// <summary>
    /// Overrides the error message on failure.
    /// </summary>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue("")]
    public string ErrorMessageOnFailure { get; set; }
}
