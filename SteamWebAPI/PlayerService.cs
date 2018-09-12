using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class PlayerService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid"></param>
		/// <param name="Ticket"></param>
		/// <param name="PlaySessions"></param>
		public static async void RecordOfflinePlaytime(ulong Steamid, string Ticket, object PlaySessions)
		{
			var query = HttpUtility.ParseQueryString("");
			query["steamid"] = Steamid.ToString();
			query["ticket"] = Ticket;
			query["play_sessions"] = PlaySessions.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "RecordOfflinePlaytime", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The player we're asking about</param>
		/// <param name="Count">The number of games to return (0/unset: all)</param>
		public static async void GetRecentlyPlayedGames(string Key, ulong Steamid, uint Count)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["count"] = Count.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "GetRecentlyPlayedGames", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The player we're asking about</param>
		/// <param name="IncludeAppinfo">true if we want additional details (name, icon) about each game</param>
		/// <param name="IncludePlayedFreeGames">Free games are excluded by default.  If this is set, free games the user has played will be returned.</param>
		/// <param name="AppidsFilter">if set, restricts result set to the passed in apps</param>
		public static async void GetOwnedGames(string Key, ulong Steamid, bool IncludeAppinfo, bool IncludePlayedFreeGames, uint AppidsFilter)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["include_appinfo"] = IncludeAppinfo.ToString();
			query["include_played_free_games"] = IncludePlayedFreeGames.ToString();
			query["appids_filter"] = AppidsFilter.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "GetOwnedGames", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The player we're asking about</param>
		public static async void GetSteamLevel(string Key, ulong Steamid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "GetSteamLevel", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The player we're asking about</param>
		public static async void GetBadges(string Key, ulong Steamid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "GetBadges", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The player we're asking about</param>
		/// <param name="Badgeid">The badge we're asking about</param>
		public static async void GetCommunityBadgeProgress(string Key, ulong Steamid, int Badgeid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["badgeid"] = Badgeid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "GetCommunityBadgeProgress", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The player we're asking about</param>
		/// <param name="AppidPlaying">The game player is currently playing</param>
		public static async void IsPlayingSharedGame(string Key, ulong Steamid, uint AppidPlaying)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["appid_playing"] = AppidPlaying.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPlayerService", "IsPlayingSharedGame", 1, query);
		}
	}
}
