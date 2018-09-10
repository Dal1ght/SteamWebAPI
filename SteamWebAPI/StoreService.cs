using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class StoreService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="IfModifiedSince">Return only items that have been modified since this date.</param>
		/// <param name="HaveDescriptionLanguage">Return only items that have a description in this language.</param>
		/// <param name="IncludeGames">Include games (defaults to enabled)</param>
		/// <param name="IncludeDlc">Include DLC</param>
		/// <param name="IncludeSoftware">Include software items</param>
		/// <param name="IncludeVideos">Include videos and series</param>
		/// <param name="IncludeHardware">Include hardware</param>
		/// <param name="LastAppid">For continuations, this is the last appid returned from the previous call.</param>
		/// <param name="MaxResults">Number of results to return at a time.  Default 10k, max 50k.</param>
		public static async void GetAppList(string Key, uint? IfModifiedSince = null, string HaveDescriptionLanguage = null, bool? IncludeGames = null, bool? IncludeDlc = null, bool? IncludeSoftware = null, bool? IncludeVideos = null, bool? IncludeHardware = null, uint? LastAppid = null, uint? MaxResults = null)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			if (IfModifiedSince != null)
				query["if_modified_since"] = IfModifiedSince.ToString();
			if (HaveDescriptionLanguage != null)
				query["have_description_language"] = HaveDescriptionLanguage;
			if (IncludeGames != null)
				query["include_games"] = IncludeGames.ToString();
			if (IncludeDlc != null)
				query["include_dlc"] = IncludeDlc.ToString();
			if (IncludeSoftware != null)
				query["include_software"] = IncludeSoftware.ToString();
			if (IncludeVideos != null)
				query["include_videos"] = IncludeVideos.ToString();
			if (IncludeHardware != null)
				query["include_hardware"] = IncludeHardware.ToString();
			if (LastAppid != null)
				query["last_appid"] = LastAppid.ToString();
			if (MaxResults != null)
				query["max_results"] = MaxResults.ToString();
			JObject response = await API.Instance.GetResponseAsync("IStoreService", "GetAppList", 1, query);
		}
	}
}
