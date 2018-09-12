using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class ContentServerConfigService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="CacheId">Unique ID number</param>
		/// <param name="CacheKey">Valid current cache API key</param>
		/// <param name="ChangeNotes">Notes</param>
		/// <param name="AllowedIpBlocks">comma-separated list of allowed IP address blocks in CIDR format - blank to clear unfilter</param>
		public static async void SetSteamCacheClientFilters(string Key, uint CacheId, string CacheKey, string ChangeNotes, string AllowedIpBlocks)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["cache_id"] = CacheId.ToString();
			query["cache_key"] = CacheKey;
			query["change_notes"] = ChangeNotes;
			query["allowed_ip_blocks"] = AllowedIpBlocks;
			JObject response = await API.Instance.GetResponseAsync("IContentServerConfigService", "SetSteamCacheClientFilters", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="CacheId">Unique ID number</param>
		/// <param name="CacheKey">Valid current cache API key</param>
		public static async void GetSteamCacheNodeParams(string Key, uint CacheId, string CacheKey)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["cache_id"] = CacheId.ToString();
			query["cache_key"] = CacheKey;
			JObject response = await API.Instance.GetResponseAsync("IContentServerConfigService", "GetSteamCacheNodeParams", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="CacheId">Unique ID number</param>
		/// <param name="CacheKey">Valid current cache API key</param>
		/// <param name="MbpsSent">Outgoing network traffic in Mbps</param>
		/// <param name="MbpsRecv">Incoming network traffic in Mbps</param>
		/// <param name="CpuPercent">Percent CPU load</param>
		/// <param name="CacheHitPercent">Percent cache hits</param>
		public static async void SetSteamCachePerformanceStats(string Key, uint CacheId, string CacheKey, uint MbpsSent, uint MbpsRecv, uint CpuPercent, uint CacheHitPercent)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["cache_id"] = CacheId.ToString();
			query["cache_key"] = CacheKey;
			query["mbps_sent"] = MbpsSent.ToString();
			query["mbps_recv"] = MbpsRecv.ToString();
			query["cpu_percent"] = CpuPercent.ToString();
			query["cache_hit_percent"] = CacheHitPercent.ToString();
			JObject response = await API.Instance.GetResponseAsync("IContentServerConfigService", "SetSteamCachePerformanceStats", 1, query);
		}
	}
}
