// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.IO;
using UnityEditor;
using XRTK.Editor;
using XRTK.Editor.Utilities;
using XRTK.Extensions;

namespace XRTK.Test.Editor
{
    [InitializeOnLoad]
    internal static class TestPackageInstaller
    {
        private static readonly string DefaultPath = $"{MixedRealityPreferences.ProfileGenerationPath}Test";
        private static readonly string HiddenPath = Path.GetFullPath($"{PathFinderUtility.ResolvePath<IPathFinder>(typeof(TestPathFinder)).ForwardSlashes()}\\{MixedRealityPreferences.HIDDEN_PROFILES_PATH}");

        static TestPackageInstaller()
        {
            if (!EditorPreferences.Get($"{nameof(TestPackageInstaller)}", false))
            {
                EditorPreferences.Set($"{nameof(TestPackageInstaller)}", PackageInstaller.TryInstallAssets(HiddenPath, DefaultPath));
            }
        }
    }
}
