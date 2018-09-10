using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamApps
	{
		/// <summary>
		/// 
		/// </summary>
		public static async void GetAppList()
		{
			var query = new NameValueCollection();
			JObject response = await API.Instance.GetResponseAsync("ISteamApps", "GetAppList", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		public static async void GetAppListV2()
		{
			var query = new NameValueCollection();
			JObject response = await API.Instance.GetResponseAsync("ISteamApps", "GetAppList", 2, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Addr">IP or IP:queryport to list</param>
		public static async void GetServersAtAddress(string Addr)
		{
			var query = new NameValueCollection();
			query["addr"] = Addr;
			JObject response = await API.Instance.GetResponseAsync("ISteamApps", "GetServersAtAddress", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">AppID of game</param>
		/// <param name="Version">The installed version of the game</param>
		public static async void UpToDateCheck(uint Appid, uint Version)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			query["version"] = Version.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamApps", "UpToDateCheck", 1, query);
		}
	}
}
