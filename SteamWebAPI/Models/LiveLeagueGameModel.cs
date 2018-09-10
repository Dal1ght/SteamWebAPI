using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// Model of game in-progress.
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetLiveLeagueGames"/>
	/// </summary>
	public class LiveLeagueGameModel
	{
		/// <summary>
		/// An array of the players in the game
		/// </summary>
		[JsonProperty("players")]
		public List<LeaguePlayerModel> Players { get; set; }

		/// <summary>
		/// The Radiant
		/// </summary>
		[JsonProperty("radiant_team")]
		public TeamModel RadiantTeam { get; set; }

		/// <summary>
		/// The Dire
		/// </summary>
		[JsonProperty("dire_team")]
		public TeamModel DireTeam { get; set; }

		/// <summary>
		/// ID of the lobby for the match
		/// </summary>
		[JsonProperty("lobby_id")]
		public long LobbyID { get; set; }

		/// <summary>
		/// Unique match ID
		/// </summary>
		[JsonProperty("match_id")]
		public long MatchID { get; set; }

		/// <summary>
		/// Count of spectators in the game
		/// </summary>
		[JsonProperty("spectators")]
		public int Spectators { get; set; }

		/// <summary>
		/// Tournament league ID for which the game is being played
		/// </summary>
		[JsonProperty("league_id")]
		public int LeagueID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("league_node_id")]
		public int LeagueNodeID { get; set; }

		/// <summary>
		/// Delay in seconds for streaming to spectators
		/// </summary>
		[JsonProperty("stream_delay_s")]
		public int StreamDelay { get; set; }

		/// <summary>
		/// Number of match wins that the Radiant team currently has
		/// </summary>
		[JsonProperty("radiant_series_wins")]
		public int RadiantSeriesWins { get; set; }

		/// <summary>
		/// Number of match wins that the Dire team currently has
		/// </summary>
		[JsonProperty("dire_series_wins")]
		public int DireSeriesWins { get; set; }

		/// <summary>
		/// The game number in the series
		/// </summary>
		[JsonProperty("game_number")]
		public int GameNumber { get; set; }

		/// <summary>
		/// Stores the current game scoreboard
		/// </summary>
		[JsonProperty("scoreboard")]
		public ScoreboardModel Scoreboard { get; set; }
	}
}
