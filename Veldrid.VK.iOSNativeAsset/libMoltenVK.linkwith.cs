using System;
using ObjCRuntime;

[assembly: LinkWith("libMoltenVK.a", LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
