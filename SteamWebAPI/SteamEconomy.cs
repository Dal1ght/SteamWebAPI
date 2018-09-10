using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamEconomy
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">Must be a steam economy app.</param>
		/// <param name="ClassCount">Number of classes requested. Must be at least one.</param>
		/// <param name="Classid0">Class ID of the nth class.</param>
		/// <param name="Language">The user's local language</param>
		/// <param name="Instanceid0">Instance ID of the nth class.</param>
		public static async void GetAssetClassInfo(uint Appid, uint ClassCount, ulong Classid0, string Language = null, ulong? Instanceid0 = null)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			query["class_count"] = ClassCount.ToString();
			query["classid0"] = Classid0.ToString();
			if (Language != null)
				query["language"] = Language;
			if (Instanceid0 != null)
				query["instanceid0"] = Instanceid0.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamEconomy", "GetAssetClassInfo", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">Must be a steam economy app.</param>
		/// <param name="Currency">The currency to filter for</param>
		/// <param name="Language">The user's local language</param>
		public static async void GetAssetPrices(uint Appid, string Currency = null, string Language = null)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			if (Currency != null)
				query["currency"] = Currency;
			if (Language != null)
				query["language"] = Language;
			JObject response = await API.Instance.GetResponseAsync("ISteamEconomy", "GetAssetPrices", 1, query);
		}
	}
}
