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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify Instance Groups Request Marshaller
    /// </summary>       
    internal class ModifyInstanceGroupsRequestMarshaller : IMarshaller<IRequest, ModifyInstanceGroupsRequest> 
    {
        

        public IRequest Marshall(ModifyInstanceGroupsRequest modifyInstanceGroupsRequest) 
        {

            IRequest request = new DefaultRequest(modifyInstanceGroupsRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.ModifyInstanceGroups";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                

                if (modifyInstanceGroupsRequest != null && modifyInstanceGroupsRequest.InstanceGroups != null && modifyInstanceGroupsRequest.InstanceGroups.Count > 0)
                {
                    List<InstanceGroupModifyConfig> instanceGroupsList = modifyInstanceGroupsRequest.InstanceGroups;
                    writer.WritePropertyName("InstanceGroups");
                    writer.WriteArrayStart();

                    foreach (InstanceGroupModifyConfig instanceGroupsListValue in instanceGroupsList) 
                    {
                        writer.WriteObjectStart();
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceGroupId()) 
                        {
                            writer.WritePropertyName("InstanceGroupId");
                            writer.Write(instanceGroupsListValue.InstanceGroupId);
                        }
                        if (instanceGroupsListValue != null && instanceGroupsListValue.IsSetInstanceCount()) 
                        {
                            writer.WritePropertyName("InstanceCount");
                            writer.Write(instanceGroupsListValue.InstanceCount);
                        }

                        if (instanceGroupsListValue != null && instanceGroupsListValue.EC2InstanceIdsToTerminate != null && instanceGroupsListValue.EC2InstanceIdsToTerminate.Count > 0) 
                        {
                            List<string> eC2InstanceIdsToTerminateList = instanceGroupsListValue.EC2InstanceIdsToTerminate;
                            writer.WritePropertyName("EC2InstanceIdsToTerminate");
                            writer.WriteArrayStart();

                            foreach (string eC2InstanceIdsToTerminateListValue in eC2InstanceIdsToTerminateList) 
                            { 
                                writer.Write(StringUtils.FromString(eC2InstanceIdsToTerminateListValue));
                            }

                            writer.WriteArrayEnd();
                        }
                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
