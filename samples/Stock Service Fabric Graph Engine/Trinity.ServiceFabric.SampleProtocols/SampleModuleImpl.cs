﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity.Diagnostics;

namespace Trinity.ServiceFabric.SampleProtocols
{
    [Trinity.Extension.AutoRegisteredCommunicationModule]
    public class SampleModuleImpl : ServiceFabricSampleModuleBase
    {
        public override string GetModuleName() => "SampleModuleImpl";

        private string stateMsg = string.Empty;

        public SampleModuleImpl()
        {
            stateMsg = "Tracing";
        }
        public override void PingHandler()
        {
            Log.WriteLine("Ping received from Graph Engine Remoting Client!");
        }
    }
}
