using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamNews
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">AppID to retrieve news for</param>
		/// <param name="Maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="Enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="Count"># of posts to retrieve (default 20)</param>
		public static async void GetNewsForApp(uint Appid, uint? Maxlength = null, uint? Enddate = null, uint? Count = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["appid"] = Appid.ToString();
			if (Maxlength != null)
				query["maxlength"] = Maxlength.ToString();
			if (Enddate != null)
				query["enddate"] = Enddate.ToString();
			if (Count != null)
				query["count"] = Count.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamNews", "GetNewsForApp", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">AppID to retrieve news for</param>
		/// <param name="Maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="Enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="Count"># of posts to retrieve (default 20)</param>
		/// <param name="Feeds">Comma-seperated list of feed names to return news for</param>
		public static async void GetNewsForApp(uint Appid, uint? Maxlength = null, uint? Enddate = null, uint? Count = null, string Feeds = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["appid"] = Appid.ToString();
			if (Maxlength != null)
				query["maxlength"] = Maxlength.ToString();
			if (Enddate != null)
				query["enddate"] = Enddate.ToString();
			if (Count != null)
				query["count"] = Count.ToString();
			if (Feeds != null)
				query["feeds"] = Feeds;
			JObject response = await API.Instance.GetResponseAsync("ISteamNews", "GetNewsForApp", 2, query);
		}
	}
}
