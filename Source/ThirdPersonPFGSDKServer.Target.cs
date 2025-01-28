// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ThirdPersonPFGSDKServerTarget : TargetRules
{
	public ThirdPersonPFGSDKServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "ThirdPersonPFGSDK" } );

        DisablePlugins.Add("WMFMediaPlayer");
        DisablePlugins.Add("AsyncLoadingScreen"); //if you are using this plugin
        DisablePlugins.Add("WindowsMoviePlayer");
        DisablePlugins.Add("MediaFoundationMediaPlayer");
    }
}
