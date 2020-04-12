using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SetDaysOfWeekOperation
        : IOperation<ISetDaysOfWeek>
    {
        public string Name => "SetDaysOfWeek";

        public IDocument Document => Mutations.Default;

        public OperationKind Kind => OperationKind.Mutation;

        public Type ResultType => typeof(ISetDaysOfWeek);

        public IReadOnlyList<VariableValue> GetVariableValues()
        {
            return Array.Empty<VariableValue>();
        }
    }
}
