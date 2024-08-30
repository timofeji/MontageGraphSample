// Created by Timofej Jermolaev, All rights reserved. 

using UnrealBuildTool;
using System.Collections.Generic;

public class MontageGraphSampleEditorTarget : TargetRules
{
	public MontageGraphSampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("MontageGraphSample");
	}
}
