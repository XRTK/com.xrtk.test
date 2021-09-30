// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.InputSystem;
using XRTK.Test.Profiles;
using XRTK.Providers.Controllers;

namespace XRTK.Test.Providers.Controllers
{
    [RuntimePlatform(typeof(TestPlatform))]
    [System.Runtime.InteropServices.Guid("ad8b9380-9843-4ef1-b248-af956774ba6c")]
    public class TestControllerDataProvider : BaseControllerDataProvider
    {
        /// <inheritdoc />
        public TestControllerDataProvider(string name, uint priority, TestControllerDataProviderProfile profile, IMixedRealityInputSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}
