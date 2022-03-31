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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccountLimits operation.
    /// </summary>
    public partial class DescribeAccountLimitsResponse : AmazonWebServiceResponse
    {
        private List<AccountLimit> _accountLimits = new List<AccountLimit>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AccountLimits. 
        /// <para>
        /// An array of AccountLimit objects that show the current spend limits.
        /// </para>
        /// </summary>
        public List<AccountLimit> AccountLimits
        {
            get { return this._accountLimits; }
            set { this._accountLimits = value; }
        }

        // Check to see if AccountLimits property is set
        internal bool IsSetAccountLimits()
        {
            return this._accountLimits != null && this._accountLimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. If this field is empty
        /// then there are no more results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}