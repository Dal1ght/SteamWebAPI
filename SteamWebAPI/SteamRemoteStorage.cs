using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamRemoteStorage
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Publishedfileids">collection ids to get the details for</param>
		public static async void GetCollectionDetails(ulong[] Publishedfileids)
		{
			var query = new NameValueCollection();
			query["collectioncount"] = Publishedfileids.Length.ToString();
			for (int i = 0; i < Publishedfileids.Length; ++i)
			{
				query["publishedfileids[" + i + "]"] = Publishedfileids[i].ToString();
			}
			JObject response = await API.Instance.GetResponseAsync("ISteamRemoteStorage", "GetCollectionDetails", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Publishedfileids">published file id to look up</param>
		public static async void GetPublishedFileDetails(ulong[] Publishedfileids)
		{
			var query = new NameValueCollection();
			query["itemcount"] = Publishedfileids.Length.ToString();
			for (int i = 0; i < Publishedfileids.Length; ++i)
			{
				query["publishedfileids[" + i + "]"] = Publishedfileids[i].ToString();
			}
			JObject response = await API.Instance.GetResponseAsync("ISteamRemoteStorage", "GetPublishedFileDetails", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Ugcid">ID of UGC file to get info for</param>
		/// <param name="Appid">appID of product</param>
		/// <param name="Steamid">If specified, only returns details if the file is owned by the SteamID specified</param>
		public static async void GetUGCFileDetails(ulong Ugcid, uint Appid, ulong? Steamid = null)
		{
			var query = new NameValueCollection();
			query["ugcid"] = Ugcid.ToString();
			query["appid"] = Appid.ToString();
			if (Steamid != null)
				query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamRemoteStorage", "GetUGCFileDetails", 1, query);
		}
	}
}
