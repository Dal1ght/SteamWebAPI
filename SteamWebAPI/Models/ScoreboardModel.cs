using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// Stores the current game scoreboard
	/// </summary>
	public class ScoreboardModel
	{
		/// <summary>
		/// Game length so far, in seconds
		/// </summary>
		[JsonProperty("duration")]
		public int Duration { get; set; }

		/// <summary>
		/// Time until Roshan respawns in the game
		/// </summary>
		[JsonProperty("roshan_respawn_timer")]
		public int RoshanRespawnTimer { get; set; }

		/// <summary>
		/// Radiat team info
		/// </summary>
		[JsonProperty("radiant")]
		public TeamScoreModel Radiant { get; set; }

		/// <summary>
		/// Dire team info
		/// </summary>
		[JsonProperty("dire")]
		public TeamScoreModel Dire { get; set; }
	}
}
