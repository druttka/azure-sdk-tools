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

namespace Microsoft.WindowsAzure.Commands.ServiceManagement.Test.FunctionalTests.IaasCmdletInfo
{
    using PowershellCore;

    public class RestartAzureVMCmdletInfo : CmdletsInfo
    {
        public RestartAzureVMCmdletInfo(string vmName, string serviceName)
        {
            this.cmdletName = Utilities.RestartAzureVMCmdletName;
            this.cmdletParams.Add(new CmdletParam("Name", vmName));
            this.cmdletParams.Add(new CmdletParam("ServiceName", serviceName));
        }
    }
}
