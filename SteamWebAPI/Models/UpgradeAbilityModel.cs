using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails"/>
	/// </summary>
	public class UpgradeAbilityModel
	{
		/// <summary>
		/// ID of the ability upgraded
		/// </summary>
		[JsonProperty("ability")]
		public int Ability { get; set; }

		/// <summary>
		/// Time since match start that the ability was upgraded.
		/// </summary>
		[JsonProperty("time")]
		[JsonConverter(typeof(TimeSpanConverter))]
		public TimeSpan Time { get; set; }

		/// <summary>
		/// The level of the player at time of upgrading.
		/// </summary>
		[JsonProperty("level")]
		public int Level { get; set; }
	}
}
