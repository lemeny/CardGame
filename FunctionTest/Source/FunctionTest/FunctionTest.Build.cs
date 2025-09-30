// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class FunctionTest : ModuleRules
{
	public FunctionTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"FunctionTest",
			"FunctionTest/Variant_Platforming",
			"FunctionTest/Variant_Platforming/Animation",
			"FunctionTest/Variant_Combat",
			"FunctionTest/Variant_Combat/AI",
			"FunctionTest/Variant_Combat/Animation",
			"FunctionTest/Variant_Combat/Gameplay",
			"FunctionTest/Variant_Combat/Interfaces",
			"FunctionTest/Variant_Combat/UI",
			"FunctionTest/Variant_SideScrolling",
			"FunctionTest/Variant_SideScrolling/AI",
			"FunctionTest/Variant_SideScrolling/Gameplay",
			"FunctionTest/Variant_SideScrolling/Interfaces",
			"FunctionTest/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
