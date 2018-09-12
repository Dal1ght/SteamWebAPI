using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class PublishedFileService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="QueryType">enumeration EPublishedFileQueryType in clientenums.h</param>
		/// <param name="Page">Current page</param>
		/// <param name="CreatorAppid">App that created the files</param>
		/// <param name="Appid">App that consumes the files</param>
		/// <param name="Requiredtags">Tags to match on. See match_all_tags parameter below</param>
		/// <param name="Excludedtags">(Optional) Tags that must NOT be present on a published file to satisfy the query.</param>
		/// <param name="RequiredFlags">Required flags that must be set on any returned items</param>
		/// <param name="OmittedFlags">Flags that must not be set on any returned items</param>
		/// <param name="SearchText">Text to match in the item's title or description</param>
		/// <param name="Filetype">EPublishedFileInfoMatchingFileType</param>
		/// <param name="ChildPublishedfileid">Find all items that reference the given item.</param>
		/// <param name="Days">If query_type is k_PublishedFileQueryType_RankedByTrend, then this is the number of days to get votes for [1,7].</param>
		/// <param name="IncludeRecentVotesOnly">If query_type is k_PublishedFileQueryType_RankedByTrend, then limit result set just to items that have votes within the day range given</param>
		/// <param name="RequiredKvTags">Required key-value tags to match on.</param>
		/// <param name="Totalonly">(Optional) If true, only return the total number of files that satisfy this query.</param>
		/// <param name="IdsOnly">(Optional) If true, only return the published file ids of files that satisfy this query.</param>
		/// <param name="ReturnVoteData">Return vote data</param>
		/// <param name="ReturnTags">Return tags in the file details</param>
		/// <param name="ReturnKvTags">Return key-value tags in the file details</param>
		/// <param name="ReturnPreviews">Return preview image and video details in the file details</param>
		/// <param name="ReturnChildren">Return child item ids in the file details</param>
		/// <param name="ReturnShortDescription">Populate the short_description field instead of file_description</param>
		/// <param name="ReturnForSaleData">Return pricing information, if applicable</param>
		/// <param name="ReturnPlaytimeStats">Return playtime stats for the specified number of days before today.</param>
		/// <param name="ReturnDetails">By default, if none of the other 'return_*' fields are set, only some voting details are returned. Set this to true to return the default set of details.</param>
		/// <param name="StripDescriptionBbcode">Strips BBCode from descriptions.</param>
		/// <param name="Numperpage">(Optional) The number of results, per page to return.</param>
		/// <param name="MatchAllTags">If true, then items must have all the tags specified, otherwise they must have at least one of the tags.</param>
		/// <param name="CacheMaxAgeSeconds">Allow stale data to be returned for the specified number of seconds.</param>
		/// <param name="Language">Language to search in and also what gets returned. Defaults to English.</param>
		/// <param name="ReturnMetadata">Populate the metadata</param>
		public static async void QueryFiles(string Key, uint QueryType, uint Page, uint CreatorAppid, uint Appid, string Requiredtags, string Excludedtags, string RequiredFlags, string OmittedFlags, string SearchText, uint Filetype, ulong ChildPublishedfileid, uint Days, bool IncludeRecentVotesOnly, object RequiredKvTags, bool Totalonly, bool IdsOnly, bool ReturnVoteData, bool ReturnTags, bool ReturnKvTags, bool ReturnPreviews, bool ReturnChildren, bool ReturnShortDescription, bool ReturnForSaleData, uint ReturnPlaytimeStats, bool ReturnDetails, bool StripDescriptionBbcode, uint? Numperpage = null, bool? MatchAllTags = null, uint? CacheMaxAgeSeconds = null, int? Language = null, bool? ReturnMetadata = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["query_type"] = QueryType.ToString();
			query["page"] = Page.ToString();
			query["creator_appid"] = CreatorAppid.ToString();
			query["appid"] = Appid.ToString();
			query["requiredtags"] = Requiredtags;
			query["excludedtags"] = Excludedtags;
			query["required_flags"] = RequiredFlags;
			query["omitted_flags"] = OmittedFlags;
			query["search_text"] = SearchText;
			query["filetype"] = Filetype.ToString();
			query["child_publishedfileid"] = ChildPublishedfileid.ToString();
			query["days"] = Days.ToString();
			query["include_recent_votes_only"] = IncludeRecentVotesOnly.ToString();
			query["required_kv_tags"] = RequiredKvTags.ToString();
			query["totalonly"] = Totalonly.ToString();
			query["ids_only"] = IdsOnly.ToString();
			query["return_vote_data"] = ReturnVoteData.ToString();
			query["return_tags"] = ReturnTags.ToString();
			query["return_kv_tags"] = ReturnKvTags.ToString();
			query["return_previews"] = ReturnPreviews.ToString();
			query["return_children"] = ReturnChildren.ToString();
			query["return_short_description"] = ReturnShortDescription.ToString();
			query["return_for_sale_data"] = ReturnForSaleData.ToString();
			query["return_playtime_stats"] = ReturnPlaytimeStats.ToString();
			query["return_details"] = ReturnDetails.ToString();
			query["strip_description_bbcode"] = StripDescriptionBbcode.ToString();
			if (Numperpage != null)
				query["numperpage"] = Numperpage.ToString();
			if (MatchAllTags != null)
				query["match_all_tags"] = MatchAllTags.ToString();
			if (CacheMaxAgeSeconds != null)
				query["cache_max_age_seconds"] = CacheMaxAgeSeconds.ToString();
			if (Language != null)
				query["language"] = Language.ToString();
			if (ReturnMetadata != null)
				query["return_metadata"] = ReturnMetadata.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPublishedFileService", "QueryFiles", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Publishedfileids">Set of published file Ids to retrieve details for.</param>
		/// <param name="Includetags">If true, return tag information in the returned details.</param>
		/// <param name="Includeadditionalpreviews">If true, return preview information in the returned details.</param>
		/// <param name="Includechildren">If true, return children in the returned details.</param>
		/// <param name="Includekvtags">If true, return key value tags in the returned details.</param>
		/// <param name="Includevotes">If true, return vote data in the returned details.</param>
		/// <param name="ShortDescription">If true, return a short description instead of the full description.</param>
		/// <param name="Includeforsaledata">If true, return pricing data, if applicable.</param>
		/// <param name="Includemetadata">If true, populate the metadata field.</param>
		/// <param name="ReturnPlaytimeStats">Return playtime stats for the specified number of days before today.</param>
		/// <param name="Appid"></param>
		/// <param name="StripDescriptionBbcode">Strips BBCode from descriptions.</param>
		/// <param name="Language">Specifies the localized text to return. Defaults to English.</param>
		public static async void GetDetails(string Key, ulong Publishedfileids, bool Includetags, bool Includeadditionalpreviews, bool Includechildren, bool Includekvtags, bool Includevotes, bool ShortDescription, bool Includeforsaledata, bool Includemetadata, uint ReturnPlaytimeStats, uint Appid, bool StripDescriptionBbcode, int? Language = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["publishedfileids"] = Publishedfileids.ToString();
			query["includetags"] = Includetags.ToString();
			query["includeadditionalpreviews"] = Includeadditionalpreviews.ToString();
			query["includechildren"] = Includechildren.ToString();
			query["includekvtags"] = Includekvtags.ToString();
			query["includevotes"] = Includevotes.ToString();
			query["short_description"] = ShortDescription.ToString();
			query["includeforsaledata"] = Includeforsaledata.ToString();
			query["includemetadata"] = Includemetadata.ToString();
			query["return_playtime_stats"] = ReturnPlaytimeStats.ToString();
			query["appid"] = Appid.ToString();
			query["strip_description_bbcode"] = StripDescriptionBbcode.ToString();
			if (Language != null)
				query["language"] = Language.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPublishedFileService", "GetDetails", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">Steam ID of the user whose files are being requested.</param>
		/// <param name="Appid">App Id of the app that the files were published to.</param>
		/// <param name="Privacy">(optional) Filter by privacy settings.</param>
		/// <param name="Requiredtags">(Optional) Tags that must be present on a published file to satisfy the query.</param>
		/// <param name="Excludedtags">(Optional) Tags that must NOT be present on a published file to satisfy the query.</param>
		/// <param name="RequiredKvTags">Required key-value tags to match on.</param>
		/// <param name="Filetype">(Optional) File type to match files to.</param>
		/// <param name="CreatorAppid">App Id of the app that published the files, only matched if specified.</param>
		/// <param name="MatchCloudFilename">Match this cloud filename if specified.</param>
		/// <param name="Totalonly">(Optional) If true, only return the total number of files that satisfy this query.</param>
		/// <param name="IdsOnly">(Optional) If true, only return the published file ids of files that satisfy this query.</param>
		/// <param name="ReturnTags">Return tags in the file details</param>
		/// <param name="ReturnPreviews">Return preview image and video details in the file details</param>
		/// <param name="ReturnChildren">Return child item ids in the file details</param>
		/// <param name="ReturnForSaleData">Return pricing information, if applicable</param>
		/// <param name="ReturnPlaytimeStats">Return playtime stats for the specified number of days before today.</param>
		/// <param name="StripDescriptionBbcode">Strips BBCode from descriptions.</param>
		/// <param name="Page">(Optional) Starting page for results.</param>
		/// <param name="Numperpage">(Optional) The number of results, per page to return.</param>
		/// <param name="Type">(Optional) Type of files to be returned.</param>
		/// <param name="Sortmethod">(Optional) Sorting method to use on returned values.</param>
		/// <param name="CacheMaxAgeSeconds">Allow stale data to be returned for the specified number of seconds.</param>
		/// <param name="Language">Specifies the localized text to return. Defaults to English.</param>
		/// <param name="ReturnVoteData">Return vote data</param>
		/// <param name="ReturnKvTags">Return key-value tags in the file details</param>
		/// <param name="ReturnShortDescription">Populate the short_description field instead of file_description</param>
		/// <param name="ReturnMetadata">Populate the metadata field</param>
		public static async void GetUserFiles(string Key, ulong Steamid, uint Appid, uint Privacy, string Requiredtags, string Excludedtags, object RequiredKvTags, uint Filetype, uint CreatorAppid, string MatchCloudFilename, bool Totalonly, bool IdsOnly, bool ReturnTags, bool ReturnPreviews, bool ReturnChildren, bool ReturnForSaleData, uint ReturnPlaytimeStats, bool StripDescriptionBbcode, uint? Page = null, uint? Numperpage = null, string Type = null, string Sortmethod = null, uint? CacheMaxAgeSeconds = null, int? Language = null, bool? ReturnVoteData = null, bool? ReturnKvTags = null, bool? ReturnShortDescription = null, bool? ReturnMetadata = null)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["appid"] = Appid.ToString();
			query["privacy"] = Privacy.ToString();
			query["requiredtags"] = Requiredtags;
			query["excludedtags"] = Excludedtags;
			query["required_kv_tags"] = RequiredKvTags.ToString();
			query["filetype"] = Filetype.ToString();
			query["creator_appid"] = CreatorAppid.ToString();
			query["match_cloud_filename"] = MatchCloudFilename;
			query["totalonly"] = Totalonly.ToString();
			query["ids_only"] = IdsOnly.ToString();
			query["return_tags"] = ReturnTags.ToString();
			query["return_previews"] = ReturnPreviews.ToString();
			query["return_children"] = ReturnChildren.ToString();
			query["return_for_sale_data"] = ReturnForSaleData.ToString();
			query["return_playtime_stats"] = ReturnPlaytimeStats.ToString();
			query["strip_description_bbcode"] = StripDescriptionBbcode.ToString();
			if (Page != null)
				query["page"] = Page.ToString();
			if (Numperpage != null)
				query["numperpage"] = Numperpage.ToString();
			if (Type != null)
				query["type"] = Type;
			if (Sortmethod != null)
				query["sortmethod"] = Sortmethod;
			if (CacheMaxAgeSeconds != null)
				query["cache_max_age_seconds"] = CacheMaxAgeSeconds.ToString();
			if (Language != null)
				query["language"] = Language.ToString();
			if (ReturnVoteData != null)
				query["return_vote_data"] = ReturnVoteData.ToString();
			if (ReturnKvTags != null)
				query["return_kv_tags"] = ReturnKvTags.ToString();
			if (ReturnShortDescription != null)
				query["return_short_description"] = ReturnShortDescription.ToString();
			if (ReturnMetadata != null)
				query["return_metadata"] = ReturnMetadata.ToString();
			JObject response = await API.Instance.GetResponseAsync("IPublishedFileService", "GetUserFiles", 1, query);
		}
	}
}
