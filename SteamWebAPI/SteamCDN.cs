using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamCDN
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Cdnname">Steam name of CDN property</param>
		/// <param name="Allowedipblocks">comma-separated list of allowed IP address blocks in CIDR format - blank for not used</param>
		/// <param name="Allowedasns">comma-separated list of allowed client network AS numbers - blank for not used</param>
		/// <param name="Allowedipcountries">comma-separated list of allowed client IP country codes in ISO 3166-1 format - blank for not used</param>
		public static async void SetClientFilters(string Key, string Cdnname, string Allowedipblocks = null, string Allowedasns = null, string Allowedipcountries = null)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["cdnname"] = Cdnname;
			if (Allowedipblocks != null)
				query["allowedipblocks"] = Allowedipblocks;
			if (Allowedasns != null)
				query["allowedasns"] = Allowedasns;
			if (Allowedipcountries != null)
				query["allowedipcountries"] = Allowedipcountries;
			JObject response = await API.Instance.GetResponseAsync("ISteamCDN", "SetClientFilters", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Cdnname">Steam name of CDN property</param>
		/// <param name="MbpsSent">Outgoing network traffic in Mbps</param>
		/// <param name="MbpsRecv">Incoming network traffic in Mbps</param>
		/// <param name="CpuPercent">Percent CPU load</param>
		/// <param name="CacheHitPercent">Percent cache hits</param>
		public static async void SetPerformanceStats(string Key, string Cdnname, uint? MbpsSent = null, uint? MbpsRecv = null, uint? CpuPercent = null, uint? CacheHitPercent = null)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["cdnname"] = Cdnname;
			if (MbpsSent != null)
				query["mbps_sent"] = MbpsSent.ToString();
			if (MbpsRecv != null)
				query["mbps_recv"] = MbpsRecv.ToString();
			if (CpuPercent != null)
				query["cpu_percent"] = CpuPercent.ToString();
			if (CacheHitPercent != null)
				query["cache_hit_percent"] = CacheHitPercent.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamCDN", "SetPerformanceStats", 1, query);
		}
	}
}
