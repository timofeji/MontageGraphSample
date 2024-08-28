// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MontageGraphSample : ModuleRules
{
	public MontageGraphSample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.Default;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "NavigationSystem", "AIModule", "Niagara", "EnhancedInput" });
    }
}
