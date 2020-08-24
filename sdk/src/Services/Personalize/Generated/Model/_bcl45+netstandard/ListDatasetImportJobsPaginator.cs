#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Base class for ListDatasetImportJobs paginators.
    /// </summary>
    internal sealed partial class ListDatasetImportJobsPaginator : IPaginator<ListDatasetImportJobsResponse>, IListDatasetImportJobsPaginator
    {
        private readonly IAmazonPersonalize _client;
        private readonly ListDatasetImportJobsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListDatasetImportJobsResponse> Responses => new PaginatedResponse<ListDatasetImportJobsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the DatasetImportJobs
        /// </summary>
        public IPaginatedEnumerable<DatasetImportJobSummary> DatasetImportJobs => 
            new PaginatedResultKeyResponse<ListDatasetImportJobsResponse, DatasetImportJobSummary>(this, (i) => i.DatasetImportJobs);

        internal ListDatasetImportJobsPaginator(IAmazonPersonalize client, ListDatasetImportJobsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListDatasetImportJobsResponse> IPaginator<ListDatasetImportJobsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            ListDatasetImportJobsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListDatasetImportJobs(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (nextToken != null);
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListDatasetImportJobsResponse> IPaginator<ListDatasetImportJobsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            var nextToken = _request.NextToken;
            ListDatasetImportJobsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListDatasetImportJobsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (nextToken != null);
        }
#endif
    }
}
#endif