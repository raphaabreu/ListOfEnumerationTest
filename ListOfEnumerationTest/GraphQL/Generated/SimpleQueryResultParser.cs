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
    public partial class SimpleQueryResultParser
        : JsonResultParserBase<ISimpleQuery>
    {

        public SimpleQueryResultParser(IValueSerializerCollection serializerResolver)
        {
            if (serializerResolver is null)
            {
                throw new ArgumentNullException(nameof(serializerResolver));
            }
        }

        protected override ISimpleQuery ParserData(JsonElement data)
        {
            return new SimpleQuery
            (
                DeserializeListOfNullableDayOfWeek(data, "daysOfWeek")
            );

        }

        private IReadOnlyList<DayOfWeek?> DeserializeListOfNullableDayOfWeek(JsonElement obj, string fieldName)
        {
            JsonElement list = obj.GetProperty(fieldName);
            int listLength = list.GetArrayLength();
            var listList = new DayOfWeek?[listLength];

            for (int i = 0; i < listLength; i++)
            {
                JsonElement element = list[i];
                if (element.ValueKind == JsonValueKind.Null)
                {
                    listList[i] = null;
                }
                else
                {
                    listList[i] = (DayOfWeek?)_dayOfWeekSerializer.Deserialize(element.GetString());
                }
            }
            return listList;
        }
    }
}
