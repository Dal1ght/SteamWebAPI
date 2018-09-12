using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamUserOAuth
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="AccessToken">OAuth2 token for which to return details</param>
		public static async void GetTokenDetails(string AccessToken)
		{
			var query = HttpUtility.ParseQueryString("");
			query["access_token"] = AccessToken;
			JObject response = await API.Instance.GetResponseAsync("ISteamUserOAuth", "GetTokenDetails", 1, query);
		}
	}
}
