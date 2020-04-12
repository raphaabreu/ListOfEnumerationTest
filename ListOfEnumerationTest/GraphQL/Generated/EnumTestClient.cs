using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class EnumTestClient
        : IEnumTestClient
    {
        private const string _clientName = "EnumTestClient";

        private readonly global::StrawberryShake.IOperationExecutor _executor;

        public EnumTestClient(global::StrawberryShake.IOperationExecutorPool executorPool)
        {
            _executor = executorPool.CreateExecutor(_clientName);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::ListOfEnumerationTest.ISetDaysOfWeek>> SetDaysOfWeekAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            return _executor.ExecuteAsync(
                new SetDaysOfWeekOperation(),
                cancellationToken);
        }

        public global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<global::ListOfEnumerationTest.ISetDaysOfWeek>> SetDaysOfWeekAsync(
            SetDaysOfWeekOperation operation,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }

            return _executor.ExecuteAsync(operation, cancellationToken);
        }
    }
}
