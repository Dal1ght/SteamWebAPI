using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamEnvoy
	{
		/// <summary>
		/// 
		/// </summary>
		public static async void PaymentOutReversalNotification()
		{
			var query = HttpUtility.ParseQueryString("");
			JObject response = await API.Instance.GetResponseAsync("ISteamEnvoy", "PaymentOutReversalNotification", 1, query);
		}
	}
}
