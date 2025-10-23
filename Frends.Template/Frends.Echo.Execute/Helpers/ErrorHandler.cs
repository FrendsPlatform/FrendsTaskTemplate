using System;
using Frends.Echo.Execute.Definitions;

namespace Frends.Echo.Execute.Helpers;

/// <summary>
///  Provides centralized error handling for task operations.
/// </summary>
public static class ErrorHandler
{
    /// <summary>
    /// Handles an exception that occurs during task execution.
    /// </summary>
    /// <param name="ex">The exception that occurred during task execution.</param>
    /// <param name="options">Configuration options that determine how errors should be handled.</param>
    /// <returns>A Result object containing error information when ThrowErrorOnFailure is false.</returns>
    public static Result Handle(Exception ex, Options options)
    {
        if (options.ThrowErrorOnFailure)
        {
            if (!string.IsNullOrEmpty(options.ErrorMessageOnFailure))
            {
                throw new Exception(options.ErrorMessageOnFailure, ex);
            }

            throw ex;
        }

        var errorMessage = string.IsNullOrEmpty(options.ErrorMessageOnFailure)
            ? ex.Message
            : $"{options.ErrorMessageOnFailure}: {ex.Message}";

        var error = new Error
        {
            Message = errorMessage,
            AdditionalInfo = ex,
        };

        return new Result { Success = false, Error = error };
    }
}
