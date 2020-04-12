using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SimpleQuery
        : ISimpleQuery
    {
        public SimpleQuery(
            IReadOnlyList<DayOfWeek?> daysOfWeek)
        {
            DaysOfWeek = daysOfWeek;
        }

        public IReadOnlyList<DayOfWeek?> DaysOfWeek { get; }
    }
}
