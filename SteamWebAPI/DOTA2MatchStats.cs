using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class DOTA2MatchStats
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="ServerSteamId"></param>
		public static async void GetRealtimeStats(ulong ServerSteamId)
		{
			var query = HttpUtility.ParseQueryString("");
			query["server_steam_id"] = ServerSteamId.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2MatchStats_570", "GetRealtimeStats", 1, query);
		}
	}
}
