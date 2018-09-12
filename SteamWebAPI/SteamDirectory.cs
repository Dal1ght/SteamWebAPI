using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamDirectory
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Cellid">Client's Steam cell ID</param>
		/// <param name="Maxcount">Max number of servers to return</param>
		public static async void GetCMList(uint Cellid, uint? Maxcount = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["cellid"] = Cellid.ToString();
			if (Maxcount != null)
				query["maxcount"] = Maxcount.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamDirectory", "GetCMList", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Cellid">Client's Steam cell ID</param>
		/// <param name="Maxcount">Max number of servers to return</param>
		public static async void GetCSList(uint Cellid, uint? Maxcount = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["cellid"] = Cellid.ToString();
			if (Maxcount != null)
				query["maxcount"] = Maxcount.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamDirectory", "GetCSList", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		public static async void GetSteamPipeDomains()
		{
			var query = HttpUtility.ParseQueryString("");
			JObject response = await API.Instance.GetResponseAsync("ISteamDirectory", "GetSteamPipeDomains", 1, query);
		}
	}
}
