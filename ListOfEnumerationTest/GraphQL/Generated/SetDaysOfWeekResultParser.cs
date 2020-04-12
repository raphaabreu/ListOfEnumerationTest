using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Transport;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class SetDaysOfWeekResultParser
        : JsonResultParserBase<ISetDaysOfWeek>
    {
        private readonly IValueSerializer _booleanSerializer;

        public SetDaysOfWeekResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
            _booleanSerializer = serializerResolver.Get("Boolean");
        }

        protected override ISetDaysOfWeek ParserData(JsonElement data)
        {
            return new SetDaysOfWeek1
            (
                DeserializeBoolean(data, "setDaysOfWeek")
            );

        }

        private bool DeserializeBoolean(JsonElement obj, string fieldName)
        {
            JsonElement value = obj.GetProperty(fieldName);
            return (bool)_booleanSerializer.Deserialize(value.GetBoolean());
        }
    }
}
