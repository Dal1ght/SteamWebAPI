using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamWebAPI.Models;

namespace SteamWebAPI
{
	public static class SteamUser
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Steamid">SteamID of user</param>
		/// <param name="Relationship">relationship type (ex: friend)</param>
		public static async void GetFriendList(string Key, ulong Steamid, string Relationship = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			if (Relationship != null)
				query["relationship"] = Relationship;
			JObject response = await API.Instance.GetResponseAsync("ISteamUser", "GetFriendList", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Steamids">Comma-delimited list of SteamIDs</param>
		public static async void GetPlayerBans(string Key, string Steamids)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamids"] = Steamids;
			JObject response = await API.Instance.GetResponseAsync("ISteamUser", "GetPlayerBans", 1, query);
		}

		/// <summary>
		/// Returns basic profile information for a list of 64-bit Steam IDs.
		/// </summary>
		/// <param name="Steamids">list of SteamIDs</param>
		public static async void GetPlayerSummaries(params long[] Steamids)
		{
			var query = HttpUtility.ParseQueryString("");
			StringBuilder sb = new StringBuilder();
			foreach(var id in Steamids)
			{
				sb.Append(id + ",");
			}
			if(sb.Length > 1)
				sb.Remove(sb.Length - 1, 1);
			query["steamids"] = sb.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUser", "GetPlayerSummaries", 1, query);
		}

		/// <summary>
		/// Returns basic profile information for a list of 64-bit Steam IDs.
		/// </summary>
		/// <param name="Steamids">list of SteamIDs (max: 100)</param>
		public static async Task<List<PlayerSummaryModel>> GetPlayerSummariesV2(params long[] Steamids)
		{
			var query = HttpUtility.ParseQueryString("");
			StringBuilder sb = new StringBuilder();
			foreach (var id in Steamids)
			{
				sb.Append(id + ",");
			}
			if (sb.Length > 1)
				sb.Remove(sb.Length - 1, 1);
			query["steamids"] = sb.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUser", "GetPlayerSummaries", 2, query);
			return JsonConvert.DeserializeObject<List<PlayerSummaryModel>>(response["response"]["players"].ToString(), API.SerializerSettings);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Steamid">SteamID of user</param>
		public static async void GetUserGroupList(string Key, ulong Steamid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUser", "GetUserGroupList", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Vanityurl">The vanity URL to get a SteamID for</param>
		/// <param name="UrlType">The type of vanity URL. 1 (default): Individual profile, 2: Group, 3: Official game group</param>
		public static async void ResolveVanityURL(string Key, string Vanityurl, int? UrlType = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["vanityurl"] = Vanityurl;
			if (UrlType != null)
				query["url_type"] = UrlType.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUser", "ResolveVanityURL", 1, query);
		}
	}
}
