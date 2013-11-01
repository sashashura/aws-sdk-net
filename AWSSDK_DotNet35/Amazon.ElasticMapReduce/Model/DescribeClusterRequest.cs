/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCluster operation.
    /// <para>Provides cluster-level details including status, hardware and software configuration, VPC settings, and so on. For information about
    /// the cluster steps, see ListSteps.</para>
    /// </summary>
    public partial class DescribeClusterRequest : AmazonElasticMapReduceRequest
    {
        private string clusterId;


        /// <summary>
        /// The identifier of the cluster to describe.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this.clusterId; }
            set { this.clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this.clusterId != null;
        }

    }
}
    
