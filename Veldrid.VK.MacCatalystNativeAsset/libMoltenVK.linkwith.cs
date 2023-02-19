using System;
using ObjCRuntime;

[assembly: LinkWith("libMoltenVK.a", LinkTarget.Arm64 | LinkTarget.Simulator64, Frameworks="IOSurface QuartzCore Metal Foundation IOKit UIKit", SmartLink = true, ForceLoad = true)]
