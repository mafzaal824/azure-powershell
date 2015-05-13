﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.HDInsight.Models
{
    /// <summary>
    /// The provisioning state of the cluster.
    /// </summary>
    public enum HDInsightClusterProvisioningState
    {
        /// <summary>
        /// The cluster create is in progress.
        /// </summary>
        InProgress = 1,

        /// <summary>
        /// The cluster create failed.
        /// </summary>
        Failed = 2,

        /// <summary>
        /// The cluster create succeeded.
        /// </summary>
        Succeeded = 3,

        /// <summary>
        /// The cluster create is canceled.
        /// </summary>
        Canceled = 4,

        /// <summary>
        /// The cluster is deleting.
        /// </summary>
        Deleting = 5,
    }
}
