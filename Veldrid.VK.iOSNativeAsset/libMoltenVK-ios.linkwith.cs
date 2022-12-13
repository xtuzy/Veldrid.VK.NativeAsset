using System;
using ObjCRuntime;

[assembly: LinkWith("libMoltenVK-ios.a", LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
