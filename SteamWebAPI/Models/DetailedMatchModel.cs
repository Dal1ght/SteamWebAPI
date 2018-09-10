using Newtonsoft.Json;
using SteamWebAPI.Converters;
using System;
using System.Collections.Generic;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails"/>
	/// </summary>
	public class DetailedMatchModel
	{
		/// <summary>
		/// List of players in the match.
		/// </summary>
		[JsonProperty("players")]
		public List<DetailedMatchPlayerModel> Players { get; set; }

		/// <summary>
		/// Dictates the winner of the match, true for radiant; false for dire.
		/// </summary>
		[JsonProperty("radiant_win")]
		public bool RadiantWin { get; set; }

		/// <summary>
		/// The length of the match since the match began.
		/// </summary>
		[JsonProperty("duration")]
		[JsonConverter(typeof(TimeSpanConverter))]
		public TimeSpan Duration { get; set; }

		[JsonProperty("pre_game_duration")]
		[JsonConverter(typeof(TimeSpanConverter))]
		public TimeSpan PreGameDuration { get; set; }

		/// <summary>
		/// Unix timestamp of when the match began.
		/// </summary>
		[JsonProperty("start_time")]
		[JsonConverter(typeof(UnixTimeConverter))]
		public DateTime StartTime { get; set; }

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
		/// Radiant team towers status
		/// </summary>
		[JsonProperty("tower_status_radiant")]
		[JsonConverter(typeof(ValueConstructorConverter))]
		public TowerStatus TowerStatusRadiant { get; set; }

		/// <summary>
		/// Dire team towers status
		/// </summary>
		[JsonProperty("tower_status_dire")]
		[JsonConverter(typeof(ValueConstructorConverter))]
		public TowerStatus TowerStatusDire { get; set; }

		/// <summary>
		/// Radiant team barracks status
		/// </summary>
		[JsonProperty("barracks_status_radiant")]
		[JsonConverter(typeof(ValueConstructorConverter))]
		public BarracksStatus BarracksStatusRadiant { get; set; }

		/// <summary>
		/// Dire team barracks status
		/// </summary>
		[JsonProperty("barracks_status_dire")]
		[JsonConverter(typeof(ValueConstructorConverter))]
		public BarracksStatus BarracksStatusDire { get; set; }

		/// <summary>
		/// The server cluster the match was played upon. Used for downloading replays of matches.
		/// </summary>
		[JsonProperty("cluster")]
		public int Cluster { get; set; }

		/// <summary>
		/// The time in seconds since the match began when first-blood occurred.
		/// </summary>
		[JsonProperty("first_blood_time")]
		[JsonConverter(typeof(TimeSpanConverter))]
		public TimeSpan FirstBloodTime { get; set; }

		[JsonProperty("lobby_type")]
		[JsonConverter(typeof(EnumConverter))]
		public LobbyTypes LobbyType { get; set; }

		/// <summary>
		/// The amount of human players within the match.
		/// </summary>
		[JsonProperty("human_players")]
		public int HummanPlayers { get; set; }

		/// <summary>
		/// The league that this match was a part of. A list of league IDs can be found via the GetLeagueListing method.
		/// </summary>
		[JsonProperty("leagueid")]
		public long LeagueID { get; set; }

		/// <summary>
		/// The number of thumbs-up the game has received by users.
		/// </summary>
		[JsonProperty("positive_votes")]
		public int PositiveVotes { get; set; }

		/// <summary>
		/// The number of thumbs-down the game has received by users.
		/// </summary>
		[JsonProperty("negative_votes")]
		public int NegativeVotes { get; set; }

		[JsonProperty("game_mode")]
		[JsonConverter(typeof(EnumConverter))]
		public GameModes GameMode { get; set; }

		[JsonProperty("flags")]
		public int Flags { get; set; }

		[JsonProperty("engine")]
		[JsonConverter(typeof(EnumConverter))]
		public Engines Engine { get; set; }

		[JsonProperty("radiant_score")]
		public int RadiantScore { get; set; }

		[JsonProperty("dire_score")]
		public int DireScore { get; set; }

		[JsonProperty("tournament_id")]
		public long TournamentID { get; set; }

		[JsonProperty("tournament_round")]
		public int TournamentRound { get; set; }

		[JsonProperty("radiant_team_id")]
		public long RadiantTeamID { get; set; }

		[JsonProperty("radiant_name")]
		public string RadiantTeamName { get; set; }

		[JsonProperty("radiant_logo")]
		public int RadiantLogo { get; set; }

		[JsonProperty("radiant_team_complete")]
		public int RadiantTeamComplete { get; set; }

		[JsonProperty("dire_team_id")]
		public long DireTeamID { get; set; }

		[JsonProperty("dire_name")]
		public string DireTeamName { get; set; }

		[JsonProperty("dire_logo")]
		public int DireLogo { get; set; }

		[JsonProperty("dire_team_complete")]
		public int DireTeamComplete { get; set; }

		[JsonProperty("radiant_captain")]
		public long RadiantCapitan { get; set; }

		[JsonProperty("dire_captain")]
		public long DireCapitan { get; set; }

		/// <summary>
		/// A list of the picks and bans in the match, if the game mode is Captains Mode.
		/// </summary>
		[JsonProperty("picks_bans")]
		public List<PickBanModel> PicksBans { get; set; }
	}
}
