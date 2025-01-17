// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of manifest attributes. </summary>
    internal partial class ManifestAttributesManifest
    {
        /// <summary> Initializes a new instance of ManifestAttributesManifest. </summary>
        internal ManifestAttributesManifest()
        {
            References = new ChangeTrackingList<ArtifactManifestReference>();
        }

        /// <summary> List of manifest attributes details. </summary>
        public IReadOnlyList<ArtifactManifestReference> References { get; }
        /// <summary> Quarantine tag name. </summary>
        public string QuarantineTag { get; }
    }
}
