using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class GCVersion
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="GameID">ID of game</param>
		public static async void GetClientVersion(int GameID)
		{
			var query = HttpUtility.ParseQueryString("");
			JObject response = await API.Instance.GetResponseAsync($"IGCVersion_{GameID}", "GetClientVersion", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="GameID">ID of game</param>
		public static async void GetServerVersion(int GameID)
		{
			var query = HttpUtility.ParseQueryString("");
			JObject response = await API.Instance.GetResponseAsync($"IGCVersion_{GameID}", "GetServerVersion", 1, query);
		}
	}
}
