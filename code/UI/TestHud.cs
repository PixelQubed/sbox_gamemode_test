﻿using Sandbox;
using Sandbox.UI;

namespace RPGamemode.UI
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
			RootPanel.AddChild<JobSelectMenu>();
		}
	}
}
