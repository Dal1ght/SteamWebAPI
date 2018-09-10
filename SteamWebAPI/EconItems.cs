using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class EconItems
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">The Steam ID to fetch items for</param>
		/// <param name="ClassId">Return items equipped for this class id</param>
		public static async void GetEquippedPlayerItems(ulong Steamid, uint ClassId)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			query["class_id"] = ClassId.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconItems_570", "GetEquippedPlayerItems", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">The Steam ID to fetch items for</param>
		public static async void GetPlayerItems(ulong Steamid)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconItems_570", "GetPlayerItems", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		public static async void GetSchemaURL()
		{
			var query = new NameValueCollection();
			JObject response = await API.Instance.GetResponseAsync("IEconItems_570", "GetSchemaURL", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Language">The language to results in.</param>
		public static async void GetStoreMetaData(string Language = null)
		{
			var query = new NameValueCollection();
			if (Language != null)
				query["language"] = Language;
			JObject response = await API.Instance.GetResponseAsync("IEconItems_570", "GetStoreMetaData", 1, query);
		}
	}
}
