using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class InventoryService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Appid"></param>
		/// <param name="Itemid"></param>
		/// <param name="Quantity"></param>
		public static async void SplitItemStack(string Key, uint Appid, ulong Itemid, uint Quantity)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["appid"] = Appid.ToString();
			query["itemid"] = Itemid.ToString();
			query["quantity"] = Quantity.ToString();
			JObject response = await API.Instance.GetResponseAsync("IInventoryService", "SplitItemStack", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Appid"></param>
		/// <param name="Fromitemid"></param>
		/// <param name="Destitemid"></param>
		/// <param name="Quantity"></param>
		public static async void CombineItemStacks(string Key, uint Appid, ulong Fromitemid, ulong Destitemid, uint Quantity)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["appid"] = Appid.ToString();
			query["fromitemid"] = Fromitemid.ToString();
			query["destitemid"] = Destitemid.ToString();
			query["quantity"] = Quantity.ToString();
			JObject response = await API.Instance.GetResponseAsync("IInventoryService", "CombineItemStacks", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Ecurrency"></param>
		public static async void GetPriceSheet(string Key, int Ecurrency)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["ecurrency"] = Ecurrency.ToString();
			JObject response = await API.Instance.GetResponseAsync("IInventoryService", "GetPriceSheet", 1, query);
		}
	}
}
