using UnrealBuildTool;

public class FYP_PaperPalTarget : TargetRules
{
	public FYP_PaperPalTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FYP_PaperPal");
	}
}
