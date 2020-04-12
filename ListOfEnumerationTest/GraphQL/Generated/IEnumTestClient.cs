using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial interface IEnumTestClient
    {
        Task<IOperationResult<global::ListOfEnumerationTest.ISetDaysOfWeek>> SetDaysOfWeekAsync(
            CancellationToken cancellationToken = default);

        Task<IOperationResult<global::ListOfEnumerationTest.ISetDaysOfWeek>> SetDaysOfWeekAsync(
            SetDaysOfWeekOperation operation,
            CancellationToken cancellationToken = default);
    }
}
