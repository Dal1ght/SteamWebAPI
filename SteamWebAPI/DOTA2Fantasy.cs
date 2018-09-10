using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class DOTA2Fantasy
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="FantasyLeagueID">The fantasy league ID</param>
		/// <param name="StartTime">An optional filter for minimum timestamp</param>
		/// <param name="EndTime">An optional filter for maximum timestamp</param>
		/// <param name="MatchID">An optional filter for a specific match</param>
		/// <param name="SeriesID">An optional filter for a specific series</param>
		/// <param name="PlayerAccountID">An optional filter for a specific player</param>
		public static async void GetFantasyPlayerStats(uint FantasyLeagueID, uint? StartTime = null, uint? EndTime = null, ulong? MatchID = null, uint? SeriesID = null, uint? PlayerAccountID = null)
		{
			var query = new NameValueCollection();
			query["FantasyLeagueID"] = FantasyLeagueID.ToString();
			if (StartTime != null)
				query["StartTime"] = StartTime.ToString();
			if (EndTime != null)
				query["EndTime"] = EndTime.ToString();
			if (MatchID != null)
				query["MatchID"] = MatchID.ToString();
			if (SeriesID != null)
				query["SeriesID"] = SeriesID.ToString();
			if (PlayerAccountID != null)
				query["PlayerAccountID"] = PlayerAccountID.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Fantasy_570", "GetFantasyPlayerStats", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Accountid">The account ID to look up</param>
		public static async void GetPlayerOfficialInfo(uint Accountid)
		{
			var query = new NameValueCollection();
			query["accountid"] = Accountid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Fantasy_570", "GetPlayerOfficialInfo", 1, query);
		}
	}
}
