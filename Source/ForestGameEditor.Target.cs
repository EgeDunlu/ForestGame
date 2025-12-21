// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ForestGameEditorTarget : TargetRules
{
	public ForestGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Editor;
		ExtraModuleNames.AddRange(new string[] { "ForestGame" });
	}
}