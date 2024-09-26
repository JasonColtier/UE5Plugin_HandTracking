// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using UnrealBuildTool;

public class SimpleOpenXRHandTracking : ModuleRules
{
	public SimpleOpenXRHandTracking(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
		if (Target.Platform == UnrealTargetPlatform.Android)
		{
			// AndroidPlugin
			{
				// string ManifestFile = Utils.MakePathRelativeTo(ModuleDirectory, "IrwinoAndroidPermission_UPL.xml");
				// AdditionalPropertiesForReceipt.Add("AndroidPlugin", ManifestFile);

				string manifest_file = Path.Combine(ModuleDirectory, "IrwinoAndroidPermission_UPL.xml");

				AdditionalPropertiesForReceipt.Add("AndroidPlugin", manifest_file);
			}
		}	
	}
}
