using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Echo.Execute.Definitions;

// TODO: Remove this class if the task does not make connections

/// <summary>
/// Connection parameters.
/// </summary>
public class Connection
{
    /// <summary>
    /// Connection string to *service*.
    /// </summary>
    /// <example>Host=127.0.0.1;Port=5432</example>
    [DisplayFormat(DataFormatString = "Text")]
    [DefaultValue("")]
    public string ConnectionString { get; set; }
}
