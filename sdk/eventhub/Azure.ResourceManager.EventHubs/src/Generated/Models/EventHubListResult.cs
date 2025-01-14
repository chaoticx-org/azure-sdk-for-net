// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> The result of the List EventHubs operation. </summary>
    internal partial class EventHubListResult
    {
        /// <summary> Initializes a new instance of EventHubListResult. </summary>
        internal EventHubListResult()
        {
            Value = new ChangeTrackingList<Eventhub>();
        }

        /// <summary> Initializes a new instance of EventHubListResult. </summary>
        /// <param name="value"> Result of the List EventHubs operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of EventHubs. </param>
        internal EventHubListResult(IReadOnlyList<Eventhub> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List EventHubs operation. </summary>
        public IReadOnlyList<Eventhub> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of EventHubs. </summary>
        public string NextLink { get; }
    }
}
