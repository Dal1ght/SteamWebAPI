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
	public class MatchModel
	{
		/// <summary>
		/// The matches unique ID.
		/// </summary>
		[JsonProperty("match_id")]
		public long MatchID { get; set; }

		/// <summary>
		/// A 'sequence number', representing the order in which matches were recorded.
		/// </summary>
		[JsonProperty("match_seq_num")]
		public long MatchSeqNum { get; set; }

		/// <summary>
		/// Timestamp of when the match began.
		/// </summary>
		[JsonConverter(typeof(UnixTimeConverter))]
		[JsonProperty("start_time")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// Lobby type
		/// </summary>
		//[JsonConverter(typeof(EnumConverter))]
		[JsonProperty("lobby_type")]
		public LobbyTypes LobbyType { get; set; }

		[JsonProperty("radiant_team_id")]
		public int RadianTeamID { get; set; }

		[JsonProperty("dire_team_id")]
		public int DireTeamID { get; set; }

		/// <summary>
		/// The list of players within the match.
		/// </summary>
		[JsonProperty("players")]
		public List<MatchPlayerModel> Players { get; set; }
	}
}
