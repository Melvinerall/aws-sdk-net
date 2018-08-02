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
 * Do not modify this file. This file is generated from the polly-2016-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Polly.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Polly.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSpeechSynthesisTask Request Marshaller
    /// </summary>       
    public class StartSpeechSynthesisTaskRequestMarshaller : IMarshaller<IRequest, StartSpeechSynthesisTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSpeechSynthesisTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSpeechSynthesisTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Polly");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "POST";

            string uriResourcePath = "/v1/synthesisTasks";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLanguageCode())
                {
                    context.Writer.WritePropertyName("LanguageCode");
                    context.Writer.Write(publicRequest.LanguageCode);
                }

                if(publicRequest.IsSetLexiconNames())
                {
                    context.Writer.WritePropertyName("LexiconNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLexiconNamesListValue in publicRequest.LexiconNames)
                    {
                            context.Writer.Write(publicRequestLexiconNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetOutputFormat())
                {
                    context.Writer.WritePropertyName("OutputFormat");
                    context.Writer.Write(publicRequest.OutputFormat);
                }

                if(publicRequest.IsSetOutputS3BucketName())
                {
                    context.Writer.WritePropertyName("OutputS3BucketName");
                    context.Writer.Write(publicRequest.OutputS3BucketName);
                }

                if(publicRequest.IsSetOutputS3KeyPrefix())
                {
                    context.Writer.WritePropertyName("OutputS3KeyPrefix");
                    context.Writer.Write(publicRequest.OutputS3KeyPrefix);
                }

                if(publicRequest.IsSetSampleRate())
                {
                    context.Writer.WritePropertyName("SampleRate");
                    context.Writer.Write(publicRequest.SampleRate);
                }

                if(publicRequest.IsSetSnsTopicArn())
                {
                    context.Writer.WritePropertyName("SnsTopicArn");
                    context.Writer.Write(publicRequest.SnsTopicArn);
                }

                if(publicRequest.IsSetSpeechMarkTypes())
                {
                    context.Writer.WritePropertyName("SpeechMarkTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSpeechMarkTypesListValue in publicRequest.SpeechMarkTypes)
                    {
                            context.Writer.Write(publicRequestSpeechMarkTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetText())
                {
                    context.Writer.WritePropertyName("Text");
                    context.Writer.Write(publicRequest.Text);
                }

                if(publicRequest.IsSetTextType())
                {
                    context.Writer.WritePropertyName("TextType");
                    context.Writer.Write(publicRequest.TextType);
                }

                if(publicRequest.IsSetVoiceId())
                {
                    context.Writer.WritePropertyName("VoiceId");
                    context.Writer.Write(publicRequest.VoiceId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartSpeechSynthesisTaskRequestMarshaller _instance = new StartSpeechSynthesisTaskRequestMarshaller();        

        internal static StartSpeechSynthesisTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSpeechSynthesisTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}