using UnrealBuildTool;

public class MyProjectTarget : TargetRules
{
	public MyProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject");
	}
}
