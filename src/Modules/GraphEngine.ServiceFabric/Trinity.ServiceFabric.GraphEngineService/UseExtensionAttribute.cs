﻿using System;

namespace Trinity.ServiceFabric.GraphEngineService
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class UseExtensionAttribute : Attribute
    {
        public UseExtensionAttribute(Type _) { }
    }
}