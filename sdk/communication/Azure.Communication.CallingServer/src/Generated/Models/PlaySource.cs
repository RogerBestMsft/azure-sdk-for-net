// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The PlaySource. </summary>
    public partial class PlaySource
    {
        /// <summary> Initializes a new instance of PlaySource. </summary>
        /// <param name="sourceType"> Defines the type of the play source. </param>
        public PlaySource(PlaySourceType sourceType)
        {
            SourceType = sourceType;
        }

        /// <summary> Defines the type of the play source. </summary>
        public PlaySourceType SourceType { get; }
        /// <summary> Defines the identifier to be used for caching related media. </summary>
        public string PlaySourceId { get; set; }
    }
}
