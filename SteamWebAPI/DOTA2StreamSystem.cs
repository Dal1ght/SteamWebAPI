using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class DOTA2StreamSystem
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="BroadcasterSteamId">64-bit Steam ID of the broadcaster</param>
		/// <param name="LeagueId">LeagueID to use if we aren't in a lobby</param>
		public static async void GetBroadcasterInfo(ulong BroadcasterSteamId, uint? LeagueId = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["broadcaster_steam_id"] = BroadcasterSteamId.ToString();
			if (LeagueId != null)
				query["league_id"] = LeagueId.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2StreamSystem_570", "GetBroadcasterInfo", 1, query);
		}
	}
}
