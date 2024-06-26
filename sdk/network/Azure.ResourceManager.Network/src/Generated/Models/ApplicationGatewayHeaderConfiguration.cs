// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Header configuration of the Actions set in Application Gateway. </summary>
    public partial class ApplicationGatewayHeaderConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayHeaderConfiguration"/>. </summary>
        public ApplicationGatewayHeaderConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayHeaderConfiguration"/>. </summary>
        /// <param name="headerName"> Header name of the header configuration. </param>
        /// <param name="headerValue"> Header value of the header configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayHeaderConfiguration(string headerName, string headerValue, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HeaderName = headerName;
            HeaderValue = headerValue;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Header name of the header configuration. </summary>
        public string HeaderName { get; set; }
        /// <summary> Header value of the header configuration. </summary>
        public string HeaderValue { get; set; }
    }
}
