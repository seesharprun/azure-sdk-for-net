// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.StorSimple;
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple
{
    /// <summary>
    /// This is an RESTFul API to manage you StorSimple Objects
    /// </summary>
    public static partial class CloneVolumeOperationsExtensions
    {
        /// <summary>
        /// Clone a backup element.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.ICloneVolumeOperations.
        /// </param>
        /// <param name='sourceDeviceId'>
        /// Required. The identifier of the source device from which clone is
        /// to be triggered
        /// </param>
        /// <param name='triggerCloneRequest'>
        /// Required. The parameters required for clone operation
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use
        /// </param>
        /// <returns>
        /// This is the Job Response for all Device Job Related Calls
        /// </returns>
        public static JobResponse Trigger(this ICloneVolumeOperations operations, string sourceDeviceId, TriggerCloneRequest triggerCloneRequest, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloneVolumeOperations)s).TriggerAsync(sourceDeviceId, triggerCloneRequest, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Clone a backup element.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.StorSimple.ICloneVolumeOperations.
        /// </param>
        /// <param name='sourceDeviceId'>
        /// Required. The identifier of the source device from which clone is
        /// to be triggered
        /// </param>
        /// <param name='triggerCloneRequest'>
        /// Required. The parameters required for clone operation
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. The Custom Request Headers which client must use
        /// </param>
        /// <returns>
        /// This is the Job Response for all Device Job Related Calls
        /// </returns>
        public static Task<JobResponse> TriggerAsync(this ICloneVolumeOperations operations, string sourceDeviceId, TriggerCloneRequest triggerCloneRequest, CustomRequestHeaders customRequestHeaders)
        {
            return operations.TriggerAsync(sourceDeviceId, triggerCloneRequest, customRequestHeaders, CancellationToken.None);
        }
    }
}
