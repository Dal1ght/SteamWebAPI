using Newtonsoft.Json;
using SteamWebAPI.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public class PickBanModel
	{
		/// <summary>
		/// Whether this entry is a pick (true) or a ban (false).
		/// </summary>
		[JsonProperty("is_pick")]
		public bool IsPick { get; set; }

		/// <summary>
		/// The hero's unique ID. A list of hero IDs can be found via the GetHeroes method.
		/// </summary>
		[JsonProperty("hero_id")]
		public int HeroID { get; set; }

		/// <summary>
		/// The team who chose the pick or ban; 0 for Radiant, 1 for Dire.
		/// </summary>
		[JsonProperty("team")]
		[JsonConverter(typeof(EnumConverter))]
		public Teams Team { get; set; }

		/// <summary>
		/// The order of which the picks and bans were selected; 0-19.
		/// </summary>
		[JsonProperty("order")]
		public int Order { get; set; }
	}
}
