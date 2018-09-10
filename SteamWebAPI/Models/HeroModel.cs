using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	//TODO: Steam/steamapps/common/dota 2 beta/gamedota/scripts/npc/npc_heroes.txt
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetHeroes"/>
	/// </summary>
	public class HeroModel
	{
		/// <summary>
		/// The tokenized string for the name of the hero.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// ID of the hero.
		/// </summary>
		[JsonProperty("id")]
		public int ID { get; set; }

		/// <summary>
		/// The localized name of the hero for use in name display.
		/// </summary>
		[JsonProperty("localized_name")]
		public string LocalizedName { get; set; }
	}
}
