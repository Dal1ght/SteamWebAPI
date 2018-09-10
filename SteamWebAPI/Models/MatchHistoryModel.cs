using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchHistory"/>
	/// </summary>
	public class MatchHistoryModel
	{
		/// <summary>
		/// 1 - Success
		/// 15 - Cannot get match history for a user that hasn't allowed it.
		/// </summary>
		[JsonProperty("status")]
		public int Status { get; set; }

		/// <summary>
		/// A message explaining the status, should status not be 1.
		/// </summary>
		[JsonProperty("statusDetail")]
		public string Description { get; set; }

		/// <summary>
		/// The number of matches in this response.
		/// </summary>
		[JsonProperty("num_results")]
		public int NumResults { get; set; }

		/// <summary>
		/// The total number of matches for the query.
		/// </summary>
		[JsonProperty("total_results")]
		public int TotalResults { get; set; }

		/// <summary>
		/// The number of matches left for this query.
		/// </summary>
		[JsonProperty("results_remaining")]
		public int ResultsRemaining { get; set; }

		/// <summary>
		/// A list of matches.
		/// </summary>
		[JsonProperty("matches")]
		public List<MatchModel> Matches { get; set; }
	}
}
