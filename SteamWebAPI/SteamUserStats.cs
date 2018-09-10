using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamUserStats
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Gameid">GameID to retrieve the achievement percentages for</param>
		public static async void GetGlobalAchievementPercentagesForApp(ulong Gameid)
		{
			var query = new NameValueCollection();
			query["gameid"] = Gameid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetGlobalAchievementPercentagesForApp", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Gameid">GameID to retrieve the achievement percentages for</param>
		public static async void GetGlobalAchievementPercentagesForAppV2(ulong Gameid)
		{
			var query = new NameValueCollection();
			query["gameid"] = Gameid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetGlobalAchievementPercentagesForApp", 2, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">AppID that we're getting global stats for</param>
		/// <param name="Names">Names of stat to get data for</param>
		/// <param name="Startdate">Start date for daily totals (unix epoch timestamp)</param>
		/// <param name="Enddate">End date for daily totals (unix epoch timestamp)</param>
		public static async void GetGlobalStatsForGame(uint Appid, string[] Names, uint? Startdate = null, uint? Enddate = null)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			query["count"] = Names.Length.ToString();
			for (int i = 0; i < Names.Length; ++i)
			{
				query["name[" + i + "]"] = Names[i];
			}
			if (Startdate != null)
				query["startdate"] = Startdate.ToString();
			if (Enddate != null)
				query["enddate"] = Enddate.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetGlobalStatsForGame", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">AppID that we're getting user count for</param>
		public static async void GetNumberOfCurrentPlayers(uint Appid)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetNumberOfCurrentPlayers", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Steamid">SteamID of user</param>
		/// <param name="Appid">AppID to get achievements for</param>
		/// <param name="L">Language to return strings for</param>
		public static async void GetPlayerAchievements(string Key, ulong Steamid, uint Appid, string L = null)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["appid"] = Appid.ToString();
			if (L != null)
				query["l"] = L;
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetPlayerAchievements", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Appid">appid of game</param>
		/// <param name="L">localized langauge to return (english, french, etc.)</param>
		public static async void GetSchemaForGame(string Key, uint Appid, string L = null)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["appid"] = Appid.ToString();
			if (L != null)
				query["l"] = L;
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetSchemaForGame", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Appid">appid of game</param>
		/// <param name="L">localized language to return (english, french, etc.)</param>
		public static async void GetSchemaForGameV2(string Key, uint Appid, string L = null)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["appid"] = Appid.ToString();
			if (L != null)
				query["l"] = L;
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetSchemaForGame", 2, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Steamid">SteamID of user</param>
		/// <param name="Appid">appid of game</param>
		public static async void GetUserStatsForGame(string Key, ulong Steamid, uint Appid)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["appid"] = Appid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetUserStatsForGame", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Steamid">SteamID of user</param>
		/// <param name="Appid">appid of game</param>
		public static async void GetUserStatsForGameV2(string Key, ulong Steamid, uint Appid)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["appid"] = Appid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserStats", "GetUserStatsForGame", 2, query);
		}
	}
}
