using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetLiveLeagueGames"/>
	/// </summary>
	public class TeamModel
	{
		/// <summary>
		/// The team's name.
		/// </summary>
		[JsonProperty("team_name")]
		public string Name { get; set; }

		/// <summary>
		/// The team's unique ID.
		/// </summary>
		[JsonProperty("team_id")]
		public int ID { get; set; }

		/// <summary>
		/// The UGC id for the team logo. You can resolve this with the GetUGCFileDetails method.
		/// </summary>
		[JsonProperty("team_logo")]
		public long LogoID { get; set; }

		/// <summary>
		/// Whether the players for this team are all team members.
		/// </summary>
		[JsonProperty("complete")]
		public bool Complete { get; set; }
	}
}
