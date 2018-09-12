using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamWebAPIUtil
	{
		/// <summary>
		/// 
		/// </summary>
		public static async void GetServerInfo()
		{
			var query = HttpUtility.ParseQueryString("");
			JObject response = await API.Instance.GetResponseAsync("ISteamWebAPIUtil", "GetServerInfo", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		public static async void GetSupportedAPIList(string Key = null)
		{
			var query = HttpUtility.ParseQueryString("");
			if (Key != null)
				query["key"] = Key;
			JObject response = await API.Instance.GetResponseAsync("ISteamWebAPIUtil", "GetSupportedAPIList", 1, query);
		}
	}
}
