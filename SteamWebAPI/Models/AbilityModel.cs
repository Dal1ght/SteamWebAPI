using Newtonsoft.Json;
using System;

namespace SteamWebAPI.Models
{
	public class AbilityModel
	{
		// TODO: parse npc_abilities.txt
		/// <summary>
		/// Ability ID
		/// </summary>
		[JsonProperty("ability_id")]
		public int ID { get; set; }

		/// <summary>
		/// Current level for the hero's ability
		/// </summary>
		[JsonProperty("ability_level")]
		public int Level { get; set; }
	}
}
