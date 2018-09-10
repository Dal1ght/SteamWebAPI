using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetLeagueListing"/>
	/// </summary>
	public class LeagueModel
	{
		/// <summary>
		/// The name of the league.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The league's unique ID.
		/// </summary>
		[JsonProperty("leagueid")]
		public int LeagueID { get; set; }

		/// <summary>
		/// A description of the league.
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// The league's website.
		/// </summary>
		[JsonProperty("tournament_url")]
		public string TournamentURL { get; set; }

		[JsonProperty("itemdef")]
		public int ItemDef { get; set; }
	}
}
