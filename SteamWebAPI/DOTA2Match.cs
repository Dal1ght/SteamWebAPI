using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamWebAPI.Models;

namespace SteamWebAPI
{
	public static class DOTA2Match
	{
		/// <summary>
		/// Information about DotaTV-supported leagues.
		/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetLeagueListing"/>
		/// </summary>
		public static async Task<List<LeagueModel>> GetLeagueListing()
		{
			var query = HttpUtility.ParseQueryString("");
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetLeagueListing", 1, query);
			return JsonConvert.DeserializeObject<List<LeagueModel>>(response["result"]["leagues"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// A list of in-progress league matches, as well as details of that match as it unfolds.
		/// </summary>
		/// <param name="LeagueId">Only show matches of the specified league id</param>
		/// <param name="MatchId">Only show matches of the specified match id</param>
		public static async Task<List<LiveLeagueGameModel>> GetLiveLeagueGames(uint? LeagueId = null, ulong? MatchId = null)
		{
			var query = HttpUtility.ParseQueryString("");
			if (LeagueId != null)
				query["league_id"] = LeagueId.ToString();
			if (MatchId != null)
				query["match_id"] = MatchId.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetLiveLeagueGames", 1, query);
			return JsonConvert.DeserializeObject<List<LiveLeagueGameModel>>(response["result"]["games"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// Information about a particular match.
		/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchDetails"/>
		/// </summary>
		/// <param name="MatchId">Match id</param>
		/// <param name="IncludePersonaNames">Include persona names as part of the response</param>
		public static async Task<DetailedMatchModel> GetMatchDetails(ulong MatchId, bool? IncludePersonaNames = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["match_id"] = MatchId.ToString();
			if (IncludePersonaNames != null)
				query["include_persona_names"] = IncludePersonaNames.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetMatchDetails", 1, query);
			return JsonConvert.DeserializeObject<DetailedMatchModel>(response["result"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// A list of matches, filterable by various parameters.
		/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetMatchHistory"/>
		/// </summary>
		/// <param name="HeroId">The ID of the hero that must be in the matches being queried</param>
		/// <param name="GameMode">Which game mode to return matches for</param>
		/// <param name="Skill">The average skill range of the match, these can be [1-3] with lower numbers being lower skill. Ignored if an account ID is specified</param>
		/// <param name="MinPlayers">Minimum number of human players that must be in a match for it to be returned</param>
		/// <param name="AccountId">An account ID to get matches from. This will fail if the user has their match history hidden</param>
		/// <param name="LeagueId">The league ID to return games from</param>
		/// <param name="StartAtMatchId">The minimum match ID to start from</param>
		/// <param name="MatchesRequested">The number of requested matches to return</param>
		public static async Task<MatchHistoryModel> GetMatchHistory(uint? HeroId = null, uint? GameMode = null, uint? Skill = null, string MinPlayers = null, string AccountId = null, string LeagueId = null, ulong? StartAtMatchId = null, string MatchesRequested = null)
		{
			var query = HttpUtility.ParseQueryString("");
			if (HeroId != null)
				query["hero_id"] = HeroId.ToString();
			if (GameMode != null)
				query["game_mode"] = GameMode.ToString();
			if (Skill != null)
				query["skill"] = Skill.ToString();
			if (MinPlayers != null)
				query["min_players"] = MinPlayers;
			if (AccountId != null)
				query["account_id"] = AccountId;
			if (LeagueId != null)
				query["league_id"] = LeagueId;
			if (StartAtMatchId != null)
				query["start_at_match_id"] = StartAtMatchId.ToString();
			if (MatchesRequested != null)
				query["matches_requested"] = MatchesRequested;
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetMatchHistory", 1, query);
			return JsonConvert.DeserializeObject<MatchHistoryModel>(response["result"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// A list of matches ordered by their sequence num.
		/// </summary>
		/// <param name="StartAtMatchSeqNum"></param>
		/// <param name="MatchesRequested"></param>
		public static async Task<MatchHistoryModel> GetMatchHistoryBySequenceNum(ulong? StartAtMatchSeqNum = null, uint? MatchesRequested = null)
		{
			var query = HttpUtility.ParseQueryString("");
			if (StartAtMatchSeqNum != null)
				query["start_at_match_seq_num"] = StartAtMatchSeqNum.ToString();
			if (MatchesRequested != null)
				query["matches_requested"] = MatchesRequested.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetMatchHistoryBySequenceNum", 1, query);
			return JsonConvert.DeserializeObject<MatchHistoryModel>(response["result"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="StartAtTeamId"></param>
		/// <param name="TeamsRequested"></param>
		public static async void GetTeamInfoByTeamID(ulong? StartAtTeamId = null, uint? TeamsRequested = null)
		{
			var query = HttpUtility.ParseQueryString("");
			if (StartAtTeamId != null)
				query["start_at_team_id"] = StartAtTeamId.ToString();
			if (TeamsRequested != null)
				query["teams_requested"] = TeamsRequested.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetTeamInfoByTeamID", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Partner">Which partner's games to use.</param>
		public static async void GetTopLiveEventGame(int Partner)
		{
			var query = HttpUtility.ParseQueryString("");
			query["partner"] = Partner.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetTopLiveEventGame", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Partner">Which partner's games to use.</param>
		public static async void GetTopLiveGame(int Partner)
		{
			var query = HttpUtility.ParseQueryString("");
			query["partner"] = Partner.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetTopLiveGame", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Partner">Which partner's games to use.</param>
		/// <param name="HomeDivision">Prefer matches from this division.</param>
		public static async void GetTopWeekendTourneyGames(int Partner, int? HomeDivision = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["partner"] = Partner.ToString();
			if (HomeDivision != null)
				query["home_division"] = HomeDivision.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetTopWeekendTourneyGames", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="AccountId"></param>
		/// <param name="LeagueId"></param>
		/// <param name="HeroId"></param>
		/// <param name="TimeFrame"></param>
		/// <param name="MatchId"></param>
		/// <param name="PhaseId"></param>
		public static async void GetTournamentPlayerStats(string AccountId, string LeagueId = null, string HeroId = null, string TimeFrame = null, ulong? MatchId = null, uint? PhaseId = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["account_id"] = AccountId;
			if (LeagueId != null)
				query["league_id"] = LeagueId;
			if (HeroId != null)
				query["hero_id"] = HeroId;
			if (TimeFrame != null)
				query["time_frame"] = TimeFrame;
			if (MatchId != null)
				query["match_id"] = MatchId.ToString();
			if (PhaseId != null)
				query["phase_id"] = PhaseId.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetTournamentPlayerStats", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="AccountId"></param>
		/// <param name="LeagueId"></param>
		/// <param name="HeroId"></param>
		/// <param name="TimeFrame"></param>
		/// <param name="MatchId"></param>
		/// <param name="PhaseId"></param>
		public static async void GetTournamentPlayerStatsV2(string AccountId, string LeagueId = null, string HeroId = null, string TimeFrame = null, ulong? MatchId = null, uint? PhaseId = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["account_id"] = AccountId;
			if (LeagueId != null)
				query["league_id"] = LeagueId;
			if (HeroId != null)
				query["hero_id"] = HeroId;
			if (TimeFrame != null)
				query["time_frame"] = TimeFrame;
			if (MatchId != null)
				query["match_id"] = MatchId.ToString();
			if (PhaseId != null)
				query["phase_id"] = PhaseId.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Match_570", "GetTournamentPlayerStats", 2, query);
		}
	}
}
