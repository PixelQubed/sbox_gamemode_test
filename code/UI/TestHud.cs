﻿using Sandbox;
using Sandbox.UI;

namespace RPBox.UI
{
	public partial class TestHud : HudEntity<RootPanel>
	{
		public TestHud()
		{
			Log.Info( "Loading TestHud" );
			if ( !IsClient )
				return;
			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<Health>();
			RootPanel.AddChild<Job>();
			RootPanel.AddChild<InventoryBar>();
			RootPanel.AddChild<CrosshairCanvas>();
			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<VoiceList>();
			RootPanel.AddChild<KillFeed>();
			RootPanel.AddChild<Scoreboard<ScoreboardEntry>>();
			RootPanel.AddChild<SpawnMenu>();
			RootPanel.AddChild<JobSelectMenu>();
		}
	}
}
