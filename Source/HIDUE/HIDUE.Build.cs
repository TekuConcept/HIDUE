// MESO Digital Interiors GmbH. All rights reserved 2020

using UnrealBuildTool;

public class HIDUE : ModuleRules
{
	public HIDUE(ReadOnlyTargetRules Target) : base(Target)
	{
        PrecompileForTargets = PrecompileTargetsType.Any;
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		bEnableUndefinedIdentifierWarnings = false;


		if (Target.Platform == UnrealTargetPlatform.Linux) {
			PrivateIncludePaths.AddRange(new string[] {
				"/usr/include",
				"/usr/include/x86_64-linux-gnu"
			});
			PublicSystemLibraries.Add("udev");
			PublicSystemLibraryPaths.AddRange(new string[] {
				"/usr/lib",
				"/usr/lib/x86_64-linux-gnu",
				"/usr/lib/aarch64-linux-gnu",
				"/usr/local/lib",
				"/usr/local/lib/x86_64-linux-gnu",
				"/usr/local/lib/aarch64-linux-gnu"
			});
		}
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "MovieScene"
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
                "UMG"
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
