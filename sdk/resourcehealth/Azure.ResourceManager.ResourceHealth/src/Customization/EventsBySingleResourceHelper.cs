// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary> Helper to access pipeline and make REST calls for events by single resource. </summary>
    internal sealed class EventsBySingleResourceHelper : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Events _restClient;
        private readonly ResourceIdentifier _scope;

        internal EventsBySingleResourceHelper(ArmClient client, ResourceIdentifier scope) : base(client, scope)
        {
            _scope = scope;
            _clientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restClient = new Events(_clientDiagnostics, Pipeline, Endpoint, "2025-05-01");
        }

        public IEnumerable<Page<ResourceHealthEventData>> GetPages(string filter, CancellationToken cancellationToken)
        {
            RequestContext context = new RequestContext { CancellationToken = cancellationToken };
            Uri nextLink = null;

            while (true)
            {
                HttpMessage message = nextLink == null
                    ? _restClient.CreateGetBySingleResourceRequest(_scope.ToString(), filter, context)
                    : _restClient.CreateNextGetBySingleResourceRequest(nextLink, _scope.ToString(), filter, context);

                Response response = Pipeline.ProcessMessage(message, context);
                var document = JsonDocument.Parse(response.Content);
                var items = new List<ResourceHealthEventData>();

                if (document.RootElement.TryGetProperty("value", out var valueArray))
                {
                    foreach (var item in valueArray.EnumerateArray())
                    {
                        items.Add(ResourceHealthEventData.DeserializeResourceHealthEventData(item, ModelReaderWriterOptions.Json));
                    }
                }

                string nextLinkStr = null;
                if (document.RootElement.TryGetProperty("nextLink", out var nextLinkProp))
                {
                    nextLinkStr = nextLinkProp.GetString();
                }

                yield return Page<ResourceHealthEventData>.FromValues(items, nextLinkStr, response);

                if (string.IsNullOrEmpty(nextLinkStr))
                    break;

                nextLink = new Uri(nextLinkStr);
            }
        }

        public async IAsyncEnumerable<Page<ResourceHealthEventData>> GetPagesAsync(string filter, [System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            RequestContext context = new RequestContext { CancellationToken = cancellationToken };
            Uri nextLink = null;

            while (true)
            {
                HttpMessage message = nextLink == null
                    ? _restClient.CreateGetBySingleResourceRequest(_scope.ToString(), filter, context)
                    : _restClient.CreateNextGetBySingleResourceRequest(nextLink, _scope.ToString(), filter, context);

                Response response = await Pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
                var document = JsonDocument.Parse(response.Content);
                var items = new List<ResourceHealthEventData>();

                if (document.RootElement.TryGetProperty("value", out var valueArray))
                {
                    foreach (var item in valueArray.EnumerateArray())
                    {
                        items.Add(ResourceHealthEventData.DeserializeResourceHealthEventData(item, ModelReaderWriterOptions.Json));
                    }
                }

                string nextLinkStr = null;
                if (document.RootElement.TryGetProperty("nextLink", out var nextLinkProp))
                {
                    nextLinkStr = nextLinkProp.GetString();
                }

                yield return Page<ResourceHealthEventData>.FromValues(items, nextLinkStr, response);

                if (string.IsNullOrEmpty(nextLinkStr))
                    break;

                nextLink = new Uri(nextLinkStr);
            }
        }
    }
}
