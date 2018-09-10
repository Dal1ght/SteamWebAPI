using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class TFPromos
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">The Steam ID to fetch items for</param>
		/// <param name="Promoid">The promo ID to grant an item for</param>
		public static async void GetItemID(ulong Steamid, uint Promoid)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			query["promoid"] = Promoid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ITFPromos_570", "GetItemID", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">The Steam ID to fetch items for</param>
		/// <param name="Promoid">The promo ID to grant an item for</param>
		public static async void GrantItem(ulong Steamid, uint Promoid)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			query["promoid"] = Promoid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ITFPromos_570", "GrantItem", 1, query);
		}
	}
}
