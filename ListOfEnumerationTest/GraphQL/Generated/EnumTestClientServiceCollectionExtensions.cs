using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using StrawberryShake;
using StrawberryShake.Configuration;
using StrawberryShake.Http;
using StrawberryShake.Http.Pipelines;
using StrawberryShake.Http.Subscriptions;
using StrawberryShake.Serializers;
using StrawberryShake.Transport;

namespace ListOfEnumerationTest
{
    [System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public static partial class EnumTestClientServiceCollectionExtensions
    {
        private const string _clientName = "EnumTestClient";

        public static IOperationClientBuilder AddEnumTestClient(
            this IServiceCollection serviceCollection)
        {
            if (serviceCollection is null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            serviceCollection.AddSingleton<IEnumTestClient, EnumTestClient>();

            serviceCollection.AddSingleton<IOperationExecutorFactory>(sp =>
                new HttpOperationExecutorFactory(
                    _clientName,
                    sp.GetRequiredService<IHttpClientFactory>().CreateClient,
                    sp.GetRequiredService<IClientOptions>().GetOperationPipeline<IHttpOperationContext>(_clientName),
                    sp.GetRequiredService<IClientOptions>().GetOperationFormatter(_clientName),
                    sp.GetRequiredService<IClientOptions>().GetResultParsers(_clientName)));

            IOperationClientBuilder builder = serviceCollection.AddOperationClientOptions(_clientName)
                .AddValueSerializer(() => new DayOfWeekValueSerializer())
                .AddResultParser(serializers => new SimpleQueryResultParser(serializers))
                .AddOperationFormatter(serializers => new JsonOperationFormatter(serializers))
                .AddHttpOperationPipeline(b => b.UseHttpDefaultPipeline());

            serviceCollection.TryAddSingleton<IOperationExecutorPool, OperationExecutorPool>();
            return builder;
        }

    }
}
