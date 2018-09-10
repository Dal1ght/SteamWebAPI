using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public class GameItemModel
	{
		//TODO: Steam/steamapps/common/dota 2 beta/gamedota/scripts/npc/items.txt
		/// <summary>
		/// The unique ID for the item
		/// </summary>
		[JsonProperty("id")]
		public int ID { get; set; }

		/// <summary>
		/// Code name for the item
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The cost in gold of the item
		/// </summary>
		[JsonProperty("cost")]
		public int Cost { get; set; }

		/// <summary>
		/// Indicates if the item is available in the secret shop
		/// </summary>
		[JsonProperty("secret_shop")]
		public bool IsInSecretShop { get; set; }

		/// <summary>
		/// Indicates if the item is available in the side shop in-game
		/// </summary>
		[JsonProperty("side_shop")]
		public bool IsInSideShop { get; set; }

		/// <summary>
		/// Indicates if the item is a recipe
		/// </summary>
		[JsonProperty("recipe")]
		public bool IsRecipe { get; set; }

		/// <summary>
		/// In-game name in the specified language
		/// </summary>
		[JsonProperty("localized_name")]
		public string LocalizedName { get; set; }
	}
}
