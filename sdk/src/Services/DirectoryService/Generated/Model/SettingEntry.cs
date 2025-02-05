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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about the specified configurable setting for a directory.
    /// </summary>
    public partial class SettingEntry
    {
        private string _allowedValues;
        private string _appliedValue;
        private DateTime? _lastRequestedDateTime;
        private DateTime? _lastUpdatedDateTime;
        private string _name;
        private Dictionary<string, string> _requestDetailedStatus = new Dictionary<string, string>();
        private string _requestedValue;
        private DirectoryConfigurationStatus _requestStatus;
        private string _requestStatusMessage;
        private string _type;

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The valid range of values for the directory setting.
        /// </para>
        /// </summary>
        public string AllowedValues
        {
            get { return this._allowedValues; }
            set { this._allowedValues = value; }
        }

        // Check to see if AllowedValues property is set
        internal bool IsSetAllowedValues()
        {
            return this._allowedValues != null;
        }

        /// <summary>
        /// Gets and sets the property AppliedValue. 
        /// <para>
        /// The value of the directory setting that is applied to the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AppliedValue
        {
            get { return this._appliedValue; }
            set { this._appliedValue = value; }
        }

        // Check to see if AppliedValue property is set
        internal bool IsSetAppliedValue()
        {
            return this._appliedValue != null;
        }

        /// <summary>
        /// Gets and sets the property LastRequestedDateTime. 
        /// <para>
        /// The date and time when the request to update a directory setting was last submitted.
        /// </para>
        /// </summary>
        public DateTime LastRequestedDateTime
        {
            get { return this._lastRequestedDateTime.GetValueOrDefault(); }
            set { this._lastRequestedDateTime = value; }
        }

        // Check to see if LastRequestedDateTime property is set
        internal bool IsSetLastRequestedDateTime()
        {
            return this._lastRequestedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the directory setting was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime.GetValueOrDefault(); }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the directory setting. For example:
        /// </para>
        ///  
        /// <para>
        ///  <code>TLS_1_0</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RequestDetailedStatus. 
        /// <para>
        /// Details about the status of the request to update the directory setting. If the directory
        /// setting is deployed in more than one region, status is returned for the request in
        /// each region where the setting is deployed.
        /// </para>
        /// </summary>
        public Dictionary<string, string> RequestDetailedStatus
        {
            get { return this._requestDetailedStatus; }
            set { this._requestDetailedStatus = value; }
        }

        // Check to see if RequestDetailedStatus property is set
        internal bool IsSetRequestDetailedStatus()
        {
            return this._requestDetailedStatus != null && this._requestDetailedStatus.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestedValue. 
        /// <para>
        /// The value that was last requested for the directory setting.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string RequestedValue
        {
            get { return this._requestedValue; }
            set { this._requestedValue = value; }
        }

        // Check to see if RequestedValue property is set
        internal bool IsSetRequestedValue()
        {
            return this._requestedValue != null;
        }

        /// <summary>
        /// Gets and sets the property RequestStatus. 
        /// <para>
        /// The overall status of the request to update the directory setting request. If the
        /// directory setting is deployed in more than one region, and the request fails in any
        /// region, the overall status is <code>Failed</code>.
        /// </para>
        /// </summary>
        public DirectoryConfigurationStatus RequestStatus
        {
            get { return this._requestStatus; }
            set { this._requestStatus = value; }
        }

        // Check to see if RequestStatus property is set
        internal bool IsSetRequestStatus()
        {
            return this._requestStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestStatusMessage. 
        /// <para>
        /// The last status message for the directory status request.
        /// </para>
        /// </summary>
        public string RequestStatusMessage
        {
            get { return this._requestStatusMessage; }
            set { this._requestStatusMessage = value; }
        }

        // Check to see if RequestStatusMessage property is set
        internal bool IsSetRequestStatusMessage()
        {
            return this._requestStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of directory setting. For example, <code>Protocol</code> or <code>Cipher</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}