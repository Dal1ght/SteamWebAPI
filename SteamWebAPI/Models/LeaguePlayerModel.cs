using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// Player within a game
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetLiveLeagueGames"/>
	/// </summary>
	public class LeaguePlayerModel
	{
		/// <summary>
		/// 32-bit account ID.
		/// </summary>
		[JsonProperty("account_id")]
		public long AccountID { get; set; }

		/// <summary>
		/// The player's display name.
		/// </summary>
		[JsonProperty("name")]
		public string PlayerName { get; set; }

		/// <summary>
		/// The hero's unique ID. A list of hero IDs can be found via the <see cref="API.GetHeroes(bool?)"/> method.
		/// </summary>
		[JsonProperty("hero_id")]
		public int HeroID { get; set; }

		/// <summary>
		/// What team the player is currently playing as.
		/// </summary>
		[JsonProperty("team")]
		[JsonConverter(typeof(EnumConverter))]
		public Teams Team { get; set; }
	}
}
