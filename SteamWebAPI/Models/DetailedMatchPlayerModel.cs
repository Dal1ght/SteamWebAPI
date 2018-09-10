using Newtonsoft.Json;
using SteamWebAPI.Converters;
using System;
using System.Collections.Generic;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails"/>
	/// </summary>
	public class DetailedMatchPlayerModel : MatchPlayerModel
	{
		/// <summary>
		/// ID of the top-left inventory item.
		/// </summary>
		[JsonProperty("item_0")]
		public int Item0 { get; set; }

		/// <summary>
		/// ID of the top-center inventory item.
		/// </summary>
		[JsonProperty("item_1")]
		public int Item1 { get; set; }

		/// <summary>
		/// ID of the top-right inventory item.
		/// </summary>
		[JsonProperty("item_2")]
		public int Item2 { get; set; }

		/// <summary>
		/// ID of the bottom-left inventory item.
		/// </summary>
		[JsonProperty("item_3")]
		public int Item3 { get; set; }

		/// <summary>
		/// ID of the bottom-center inventory item.
		/// </summary>
		[JsonProperty("item_4")]
		public int Item4 { get; set; }

		/// <summary>
		/// ID of the bottom-right inventory item.
		/// </summary>
		[JsonProperty("item_5")]
		public int Item5 { get; set; }

		/// <summary>
		/// ID of the left backpack item.
		/// </summary>
		[JsonProperty("backpack_0")]
		public int Backpack0 { get; set; }

		/// <summary>
		/// ID of the center backpack item.
		/// </summary>
		[JsonProperty("backpack_1")]
		public int Backpack1 { get; set; }

		/// <summary>
		/// ID of the right backpack item.
		/// </summary>
		[JsonProperty("backpack_2")]
		public int Backpack2 { get; set; }

		/// <summary>
		/// The amount of kills attributed to this player.
		/// </summary>
		[JsonProperty("kills")]
		public int Kills { get; set; }

		/// <summary>
		/// The amount of times this player died during the match.
		/// </summary>
		[JsonProperty("deaths")]
		public int Deaths { get; set; }

		/// <summary>
		/// The amount of assists attributed to this player.
		/// </summary>
		[JsonProperty("assists")]
		public int Assists { get; set; }

		[JsonConverter(typeof(EnumConverter))]
		[JsonProperty("leaver_status")]
		public LeaverStatuses LeaverStatus { get; set; }

		/// <summary>
		/// The amount of last-hits the player got during the match.
		/// </summary>
		[JsonProperty("last_hits")]
		public int LastHits { get; set; }

		/// <summary>
		/// The amount of denies the player got during the match.
		/// </summary>
		[JsonProperty("denies")]
		public int Denies { get; set; }

		/// <summary>
		/// The player's overall gold/minute.
		/// </summary>
		[JsonProperty("gold_per_min")]
		public int GPM { get; set; }

		/// <summary>
		/// The player's overall experience/minute.
		/// </summary>
		[JsonProperty("xp_per_min")]
		public int XPM { get; set; }

		/// <summary>
		/// The player's level at match end.
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// The amount of damage the player dealt to heroes.
		/// </summary>
		[JsonProperty("hero_damage")]
		public int HeroDamage { get; set; }

		/// <summary>
		/// The amount of damage the player dealt to towers.
		/// </summary>
		[JsonProperty("tower_damage")]
		public int TowerDamage { get; set; }

		/// <summary>
		/// The amount of health the player had healed on heroes.
		/// </summary>
		[JsonProperty("hero_healing")]
		public int HeroHealing { get; set; }

		/// <summary>
		/// The amount of gold the player had remaining at the end of the match.
		/// </summary>
		[JsonProperty("gold")]
		public int Gold { get; set; }

		/// <summary>
		/// The amount of gold the player spent during the match.
		/// </summary>
		[JsonProperty("gold_spent")]
		public int GoldSpent { get; set; }

		[JsonProperty("scaled_hero_damage")]
		public int ScaledHeroDamage { get; set; }

		[JsonProperty("scaled_tower_damage")]
		public int ScaledTowerDamage { get; set; }

		[JsonProperty("scaled_hero_healing")]
		public int ScaledHeroHealing { get; set; }

		/// <summary>
		/// A list detailing a player's ability upgrades.
		/// </summary>
		[JsonProperty("ability_upgrades")]
		public List<UpgradeAbilityModel> AbilityUpgrades { get; set; } = new List<UpgradeAbilityModel>();

		/// <summary>
		/// Additional playable units owned by the player.
		/// </summary>
		[JsonProperty("additional_units")]
		public List<AdditionalUnitModel> AdditionalUnits { get; set; } = new List<AdditionalUnitModel>();
	}
}
