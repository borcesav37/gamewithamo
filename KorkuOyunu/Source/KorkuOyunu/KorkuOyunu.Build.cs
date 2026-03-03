// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KorkuOyunu : ModuleRules
{
	public KorkuOyunu(ReadOnlyTargetRules Target) : base(Target)
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
			"KorkuOyunu",
			"KorkuOyunu/Variant_Horror",
			"KorkuOyunu/Variant_Horror/UI",
			"KorkuOyunu/Variant_Shooter",
			"KorkuOyunu/Variant_Shooter/AI",
			"KorkuOyunu/Variant_Shooter/UI",
			"KorkuOyunu/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
