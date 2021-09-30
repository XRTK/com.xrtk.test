// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.CameraSystem;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.CameraSystem;
using XRTK.Providers.CameraSystem;

namespace XRTK.Test.Providers.CameraSystem
{
    [RuntimePlatform(typeof(TestPlatform))]
    [System.Runtime.InteropServices.Guid("8de33923-65c5-4114-9983-a408b0e3a600")]
    public class TestCameraDataProvider : BaseCameraDataProvider
    {
        /// <inheritdoc />
        public TestCameraDataProvider(string name, uint priority, BaseMixedRealityCameraDataProviderProfile profile, IMixedRealityCameraSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}