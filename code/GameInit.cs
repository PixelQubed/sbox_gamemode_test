using Sandbox;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace SBoxGamemodeTest
{
	[Library( "game" )]

	
	// <summary>
	// This is your game class. This is an entity that is created serverside when
	// the game starts, and is replicated to the client. 
	// 
	// You can use this to create things like HUD's and declare which player class
	// to use for spawned players.
	// 
	// Your game needs to be registered (using [Library] here) with the same name 
	// as your game addon. If it isn't then we won't be able to find it.
	// </summary>
	public partial class SBoxGamemodeTest : Game
	{
		public SBoxGamemodeTest()
		{
			if ( IsServer )
			{
				Log.Info( "My Gamemode Has Created Serverside!" );

				// Create Hud
				new UI.TestHud();
			}

			if ( IsClient )
			{
				Log.Info( "My Gamemode Has Created Clientside!" );
			}
		}



		/// <summary>
		/// A client has joined the server. Make them a pawn to play with
		/// </summary>
		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			var player = new Pawns.GamePlayer();
			client.Pawn = player;

			player.Respawn();
		}
	}

}
