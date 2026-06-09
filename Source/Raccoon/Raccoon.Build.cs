// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Raccoon : ModuleRules
{
	public Raccoon(ReadOnlyTargetRules Target) : base(Target)
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
			"Raccoon",
			"Raccoon/Variant_Platforming",
			"Raccoon/Variant_Platforming/Animation",
			"Raccoon/Variant_Combat",
			"Raccoon/Variant_Combat/AI",
			"Raccoon/Variant_Combat/Animation",
			"Raccoon/Variant_Combat/Gameplay",
			"Raccoon/Variant_Combat/Interfaces",
			"Raccoon/Variant_Combat/UI",
			"Raccoon/Variant_SideScrolling",
			"Raccoon/Variant_SideScrolling/AI",
			"Raccoon/Variant_SideScrolling/Gameplay",
			"Raccoon/Variant_SideScrolling/Interfaces",
			"Raccoon/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
