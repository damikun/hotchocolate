using System;
using HotChocolate.Fetching;

namespace HotChocolate.Execution.Utilities
{
    internal class NoopBatchDispatcher
        : IBatchDispatcher
    {
        public bool HasTasks => false;

        public event EventHandler? TaskEnqueued;

        public void Dispatch(Action<IExecutionTaskDefinition> enqueue)
        {
        }

        public static NoopBatchDispatcher Default { get; } = new NoopBatchDispatcher();
    }
}
