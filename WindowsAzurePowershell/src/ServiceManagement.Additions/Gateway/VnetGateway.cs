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

namespace Microsoft.WindowsAzure.Commands.Service.Gateway
{
    using System.Runtime.Serialization;

    [DataContract(Name = "Gateway", Namespace = "http://schemas.microsoft.com/windowsazure")]
    public class VnetGateway
    {
        // Methods
        public VnetGateway()
        { 
        }

        // Properties
        [DataMember]
        public GatewayEvent LastEvent { get;  set; }

        [DataMember]
        public ProvisioningState State { get;  set; }

        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public string VIPAddress { get;  set; }
    }
}