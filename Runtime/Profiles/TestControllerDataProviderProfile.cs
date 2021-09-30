// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Controllers;
using XRTK.Definitions.Utilities;
using XRTK.Test.Providers.Controllers;

namespace XRTK.Test.Profiles
{
    public class TestControllerDataProviderProfile : BaseMixedRealityControllerDataProviderProfile
    {
        public override ControllerDefinition[] GetDefaultControllerOptions()
        {
            return new[]
            {
                new ControllerDefinition(typeof(TestController), Handedness.Left),
                new ControllerDefinition(typeof(TestController), Handedness.Right)
            };
        }
    }
}
