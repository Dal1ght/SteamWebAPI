using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// Player details
	/// </summary>
	public class LivePlayerModel
	{
		/// <summary>
		/// Position of the player in the game
		/// </summary>
		[JsonProperty("player_slot")]
		public PlayerSlotModel PlayerSlot { get; set; }

		/// <summary>
		/// 32-bit account ID.
		/// </summary>
		[JsonProperty("account_id")]
		public long AccountID { get; set; }

		/// <summary>
		/// The hero's unique ID. A list of hero IDs can be found via the <see cref="API.GetHeroes(bool?)"/> method.
		/// </summary>
		[JsonProperty("hero_id")]
		public int HeroID { get; set; }

		/// <summary>
		/// Current kills by the player
		/// </summary>
		[JsonProperty("kills")]
		public int Kills { get; set; }

		/// <summary>
		/// Current deaths for the player
		/// </summary>
		[JsonProperty("death")]
		public int Deaths { get; set; }

		/// <summary>
		/// Current assists for the player
		/// </summary>
		[JsonProperty("assists")]
		public int Assists { get; set; }

		/// <summary>
		/// Current number of last hits
		/// </summary>
		[JsonProperty("last_hits")]
		public int LastHits { get; set; }

		/// <summary>
		/// Current number of denies
		/// </summary>
		[JsonProperty("denies")]
		public int Denies { get; set; }

		/// <summary>
		/// Current gold
		/// </summary>
		[JsonProperty("gold")]
		public int Gold { get; set; }

		/// <summary>
		/// Current level
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }

		/// <summary>
		/// Current gold per minute
		/// </summary>
		[JsonProperty("gold_per_min")]
		public int GPM { get; set; }

		/// <summary>
		/// Current experience points per minute
		/// </summary>
		[JsonProperty("xp_per_min")]
		public int XPM { get; set; }

		/// <summary>
		/// Indicates if the player's ultimate is available, on cooldown, out of mana, etc.
		/// </summary>
		[JsonProperty("ultimate_state")]
		public int UltimateState { get; set; }

		/// <summary>
		/// Seconds left for ultimate cooldown
		/// </summary>
		[JsonProperty("ultimate_cooldown")]
		public int UltimateCooldown { get; set; }

		/// <summary>
		/// ID for the item in the top-left inventory slot
		/// </summary>
		[JsonProperty("item0")]
		public int Item0 { get; set; }

		/// <summary>
		/// ID for the item in the top-center inventory slot
		/// </summary>
		[JsonProperty("item1")]
		public int Item1 { get; set; }

		/// <summary>
		/// ID for the item in the top-right inventory slot
		/// </summary>
		[JsonProperty("item2")]
		public int Item2 { get; set; }

		/// <summary>
		/// ID for the item in the bottom-left inventory slot
		/// </summary>
		[JsonProperty("item3")]
		public int Item3 { get; set; }

		/// <summary>
		/// ID for the item in the bottom-center inventory slot
		/// </summary>
		[JsonProperty("item4")]
		public int Item4 { get; set; }

		/// <summary>
		/// ID for the item in the bottom-right inventory slot
		/// </summary>
		[JsonProperty("item5")]
		public int Item5 { get; set; }

		/// <summary>
		/// Time left on the player's respawn timer in seconds
		/// </summary>
		[JsonProperty("respawn_timer")]
		public int RespawnTimer { get; set; }

		/// <summary>
		/// Player's current position in the map (x coordinate)
		/// </summary>
		[JsonProperty("position_x")]
		public double PositionX { get; set; }

		/// <summary>
		/// Player's current position in the map (y coordinate)
		/// </summary>
		[JsonProperty("position_y")]
		public double PositionY { get; set; }

		/// <summary>
		/// Net worth of the player
		/// </summary>
		[JsonProperty("net_worth")]
		public int NetWorth { get; set; }
	}
}
