using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class DayOfWeekValueSerializer
        : IValueSerializer
    {
        public string Name => "DayOfWeek";

        public ValueKind Kind => ValueKind.Enum;

        public Type ClrType => typeof(DayOfWeek);

        public Type SerializationType => typeof(string);

        public object Serialize(object value)
        {
            if (value is null)
            {
                return null;
            }

            var enumValue = (DayOfWeek)value;

            switch(enumValue)
            {
                case DayOfWeek.Sunday:
                    return "SUNDAY";
                case DayOfWeek.Monday:
                    return "MONDAY";
                case DayOfWeek.Tuesday:
                    return "TUESDAY";
                case DayOfWeek.Wednesday:
                    return "WEDNESDAY";
                case DayOfWeek.Thursday:
                    return "THURSDAY";
                case DayOfWeek.Friday:
                    return "FRIDAY";
                case DayOfWeek.Saturday:
                    return "SATURDAY";
                default:
                    throw new NotSupportedException();
            }
        }

        public object Deserialize(object serialized)
        {
            if (serialized is null)
            {
                return null;
            }

            var stringValue = (string)serialized;

            switch(stringValue)
            {
                case "SUNDAY":
                    return DayOfWeek.Sunday;
                case "MONDAY":
                    return DayOfWeek.Monday;
                case "TUESDAY":
                    return DayOfWeek.Tuesday;
                case "WEDNESDAY":
                    return DayOfWeek.Wednesday;
                case "THURSDAY":
                    return DayOfWeek.Thursday;
                case "FRIDAY":
                    return DayOfWeek.Friday;
                case "SATURDAY":
                    return DayOfWeek.Saturday;
                default:
                    throw new NotSupportedException();
            }
        }

    }
}
