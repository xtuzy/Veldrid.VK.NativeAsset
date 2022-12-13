using System;
using ObjCRuntime;

[assembly: LinkWith("libMoltenVK-macos.a", LinkTarget.Arm64 | LinkTarget.Simulator64, SmartLink = true, ForceLoad = true)]
