using Newtonsoft.Json;
using SteamWebAPI.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchHistory"/>
	/// </summary>
	public class MatchPlayerModel
	{
		/// <summary>
		/// 32-bit account ID.
		/// </summary>
		[JsonProperty("account_id")]
		public long AccountID { get; set; }

		/// <summary>
		/// A player's slot
		/// </summary>
		[JsonProperty("player_slot")]
		[JsonConverter(typeof(ValueConstructorConverter))]
		public PlayerSlotModel PlayerSlot { get; set; }

		/// <summary>
		/// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
		/// </summary>
		[JsonProperty("hero_id")]
		public int HeroID { get; set; }
	}
}
