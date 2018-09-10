using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public class TeamScoreModel
	{
		/// <summary>
		/// Current kills for the corresponding team
		/// </summary>
		[JsonProperty("score")]
		public int Score { get; set; }

		/// <summary>
		/// Towers status
		/// </summary>
		[JsonProperty("tower_state")]
		public TowerStatus TowerStatus { get; set; }

		/// <summary>
		/// Barracks status
		/// </summary>
		[JsonProperty("barracks_state")]
		public BarracksStatus BarracksStatus { get; set; }

		/// <summary>
		/// A list of picks made by the corresponding team
		/// </summary>
		[JsonProperty("picks")]
		public List<int> Picks { get; set; }

		/// <summary>
		/// A list of bans made by the corresponding team
		/// </summary>
		[JsonProperty("bans")]
		public List<int> Bans { get; set; }

		/// <summary>
		/// A list of player details
		/// </summary>
		[JsonProperty("players")]
		public List<LivePlayerModel> Players { get; set; }

		/// <summary>
		/// List of abilities for each hero
		/// </summary>
		[JsonProperty("abilities")]
		public List<AbilityModel> Abilities { get; set; }
	}
}
