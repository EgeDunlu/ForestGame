// Copyright 1998-2015 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ForestGameServerTarget : TargetRules
{
	public ForestGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Server;
		ExtraModuleNames.AddRange(new string[] { "ForestGame" });
	}
}