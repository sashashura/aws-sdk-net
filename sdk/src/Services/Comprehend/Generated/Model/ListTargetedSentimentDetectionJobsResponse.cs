/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// This is the response object from the ListTargetedSentimentDetectionJobs operation.
    /// </summary>
    public partial class ListTargetedSentimentDetectionJobsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<TargetedSentimentDetectionJobProperties> _targetedSentimentDetectionJobPropertiesList = new List<TargetedSentimentDetectionJobProperties>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Identifies the next page of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TargetedSentimentDetectionJobPropertiesList. 
        /// <para>
        /// A list containing the properties of each job that is returned.
        /// </para>
        /// </summary>
        public List<TargetedSentimentDetectionJobProperties> TargetedSentimentDetectionJobPropertiesList
        {
            get { return this._targetedSentimentDetectionJobPropertiesList; }
            set { this._targetedSentimentDetectionJobPropertiesList = value; }
        }

        // Check to see if TargetedSentimentDetectionJobPropertiesList property is set
        internal bool IsSetTargetedSentimentDetectionJobPropertiesList()
        {
            return this._targetedSentimentDetectionJobPropertiesList != null && this._targetedSentimentDetectionJobPropertiesList.Count > 0; 
        }

    }
}