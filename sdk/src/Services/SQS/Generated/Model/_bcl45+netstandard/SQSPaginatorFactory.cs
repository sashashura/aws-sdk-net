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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Paginators for the SQS service
    ///</summary>
    public class SQSPaginatorFactory : ISQSPaginatorFactory
    {
        private readonly IAmazonSQS client;

        internal SQSPaginatorFactory(IAmazonSQS client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListDeadLetterSourceQueues operation
        ///</summary>
        public IListDeadLetterSourceQueuesPaginator ListDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request) 
        {
            return new ListDeadLetterSourceQueuesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQueues operation
        ///</summary>
        public IListQueuesPaginator ListQueues(ListQueuesRequest request) 
        {
            return new ListQueuesPaginator(this.client, request);
        }
    }
}
#endif