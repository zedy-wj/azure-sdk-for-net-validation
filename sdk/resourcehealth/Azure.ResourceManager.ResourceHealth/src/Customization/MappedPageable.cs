// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary> A pageable that transforms each item from TSource to TResult. </summary>
    internal sealed class MappedPageable<TSource, TResult> : Pageable<TResult>
    {
        private readonly Pageable<TSource> _source;
        private readonly Func<TSource, TResult> _selector;

        public MappedPageable(Pageable<TSource> source, Func<TSource, TResult> selector)
        {
            _source = source;
            _selector = selector;
        }

        public override IEnumerable<Page<TResult>> AsPages(string continuationToken = null, int? pageSizeHint = null)
        {
            foreach (Page<TSource> page in _source.AsPages(continuationToken, pageSizeHint))
            {
                var items = page.Values.Select(_selector).ToArray();
                yield return Page<TResult>.FromValues(items, page.ContinuationToken, page.GetRawResponse());
            }
        }
    }
}
