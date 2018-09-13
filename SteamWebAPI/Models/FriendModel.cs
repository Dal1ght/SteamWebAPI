using Newtonsoft.Json;
using SteamWebAPI.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public class FriendModel
	{
		/// <summary>
		/// 64 bit Steam ID of the friend.
		/// </summary>
		[JsonProperty("steamid")]
		public long SteamID { get; set; }

		/// <summary>
		/// Relationship qualifier
		/// </summary>
		[JsonProperty("relationship")]
		public string Relationship { get; set; }

		/// <summary>
		/// Unix timestamp of the time when the relationship was created.
		/// </summary>
		[JsonProperty("friend_since")]
		[JsonConverter(typeof(UnixTimeConverter))]
		public DateTime FriendSince { get; set; }
	}
}
