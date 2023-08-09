using Frends.Echo.Execute.Definitions;
using System.ComponentModel;
using System.Threading;

namespace Frends.Echo.Execute
{
    /// <summary>
    /// Main class of the Task.
    /// </summary>
    public static class Echo
    {
        /// <summary>
        /// This is Task.
        /// [Documentation](https://tasks.frends.com/tasks/frends-tasks/Frends.Echo.Execute)
        /// <param name="input">What to repeat.</param>
        /// <param name="options">Define if repeated multiple times. </param>
        /// <param name="cancellationToken"></param>
        /// <returns>Object { string Output } </returns>
        public static Result Execute([PropertyTab] Input input, [PropertyTab] Options options, CancellationToken cancellationToken)
        {
            var repeats = new string[options.Amount];

            for (var i = 0; i < options.Amount; i++)
            {
                // It is good to check the cancellation token somewhere you spend lot of time, e.g. in loops.
                cancellationToken.ThrowIfCancellationRequested();

                repeats[i] = input.Content;
            }

            var output = new Result
            {
                Output = string.Join(options.Delimiter, repeats)
            };

            return output;
        }
    }
}
