// Created by Timofej Jermolaev, All rights reserved. 

using UnrealBuildTool;
using System.Collections.Generic;

public class MontageGraphSampleTarget : TargetRules
{
	public MontageGraphSampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("MontageGraphSampleTarget");
	}
}
