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

namespace Microsoft.Azure.Commands.Network.Models
{
    using System.Collections.Generic;
    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using Newtonsoft.Json;

    public class PSVirtualWan : PSTopLevelResource
    {
        [Ps1Xml(Label = "Number of attached P2SVpnServerConfigurations", Target = ViewControl.Table, ScriptBlock = "$_.Count")]
        public List<PSP2SVpnServerConfiguration> P2SVpnServerConfigurations { get; set; }

        [Ps1Xml(Label = "Provisioning State", Target = ViewControl.Table)]
        public string ProvisioningState { get; set; }

        [Ps1Xml(Label = "SecurityProviderName", Target = ViewControl.Table)]
        public string SecurityProviderName { get; set; }

        [Ps1Xml(Label = "Office365LocalBreakoutCategory", Target = ViewControl.Table)]
        public string Office365LocalBreakoutCategory { get; set; }

        [Ps1Xml(Label = "AllowVnetToVnetTraffic", Target = ViewControl.Table)]
        public bool AllowVnetToVnetTraffic { get; set; }

        [Ps1Xml(Label = "AllowBranchToBranchTraffic", Target = ViewControl.Table)]
        public bool AllowBranchToBranchTraffic { get; set; }
    }
}