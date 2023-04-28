﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Storage.CoreWCF.Channels
{
    /// <summary>
    /// The enum which will be used by message encoder.
    /// </summary>
    public enum AzureQueueStorageMessageEncoding
    {
        /// <summary>
        /// Indicates using Binary message encoder.
        /// </summary>
        Binary,

        /// <summary>
        /// Indicates using Text message encoder.
        /// </summary>
        Text,
    }
}
