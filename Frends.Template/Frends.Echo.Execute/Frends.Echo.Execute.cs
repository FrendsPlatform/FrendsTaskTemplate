﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using Frends.Echo.Execute.Definitions;

namespace Frends.Echo.Execute;

/// <summary>
/// Task class.
/// </summary>
public static class Echo
{
    /// <summary>
    /// Echoes the input string the specified number of times.
    /// [Documentation](https://tasks.frends.com/tasks/frends-tasks/Frends-Echo-Execute)
    /// </summary>
    /// <param name="input">Essential parameters.</param>
    /// <param name="connection">Connection parameters.</param>
    /// <param name="options">Additional parameters.</param>
    /// <param name="cancellationToken">A cancellation token provided by Frends Platform.</param>
    /// <returns>object { bool Success, string Output, object Error { string Message, dynamic AdditionalInfo } }</returns>
    // TODO: Remove Connection parameter if the task does not make connections
    public static Result Execute(
        [PropertyTab] Input input,
        [PropertyTab] Connection connection,
        [PropertyTab] Options options,
        CancellationToken cancellationToken)
    {
        try
        {
            // TODO: Do something with connection parameters, e.g., connect to a service.
            _ = connection.ConnectionString;

            // Cancellation token should be provided to methods that support it
            // and checked during long-running operations, e.g., loops
            cancellationToken.ThrowIfCancellationRequested();

            var output = string.Join(options.Delimiter, Enumerable.Repeat(input.Content, input.Repeat));

            return new Result
            {
                Success = true,
                Output = output,
                Error = null,
            };
        }
        catch (Exception e) when (e is not OperationCanceledException)
        {
            if (options.ThrowErrorOnFailure)
            {
                if (string.IsNullOrEmpty(options.ErrorMessageOnFailure))
                    throw;

                throw new Exception(options.ErrorMessageOnFailure, e);
            }

            var errorMessage = !string.IsNullOrEmpty(options.ErrorMessageOnFailure)
                ? options.ErrorMessageOnFailure
                : e.Message;

            return new Result
            {
                Success = false,
                Output = null,
                Error = new Error
                {
                    Message = errorMessage,
                    AdditionalInfo = new
                    {
                        Exception = e,
                    },
                },
            };
        }
    }
}
