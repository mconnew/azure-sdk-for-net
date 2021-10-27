// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> A wrap up of Conversation project response. </summary>
    public partial class ConversationTargetIntentResult : TargetIntentResult
    {
        /// <summary> Initializes a new instance of ConversationTargetIntentResult. </summary>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        internal ConversationTargetIntentResult(double confidenceScore) : base(confidenceScore)
        {
            TargetKind = TargetKind.Conversation;
        }

        /// <summary> Initializes a new instance of ConversationTargetIntentResult. </summary>
        /// <param name="targetKind"> This discriminator property specifies the type of the target project that returns the response. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidenceScore"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="result"> The actual response from a Conversation project. </param>
        internal ConversationTargetIntentResult(TargetKind targetKind, string apiVersion, double confidenceScore, ConversationResult result) : base(targetKind, apiVersion, confidenceScore)
        {
            Result = result;
            TargetKind = targetKind;
        }

        /// <summary> The actual response from a Conversation project. </summary>
        public ConversationResult Result { get; }
    }
}
