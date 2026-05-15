// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary> Custom pageable for health events by single resource. </summary>
    internal sealed class HealthEventsBySingleResourcePageable : Pageable<ResourceHealthEventData>
    {
        private readonly ArmClient _client;
        private readonly ResourceIdentifier _scope;
        private readonly string _filter;
        private readonly CancellationToken _cancellationToken;

        public HealthEventsBySingleResourcePageable(ArmClient client, ResourceIdentifier scope, string filter, CancellationToken cancellationToken)
        {
            _client = client;
            _scope = scope;
            _filter = filter;
            _cancellationToken = cancellationToken;
        }

        public override IEnumerable<Page<ResourceHealthEventData>> AsPages(string continuationToken = null, int? pageSizeHint = null)
        {
            var helper = _client.GetCachedClient(c => new EventsBySingleResourceHelper(c, _scope));
            return helper.GetPages(_filter, _cancellationToken);
        }
    }
}
