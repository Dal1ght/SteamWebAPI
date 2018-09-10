using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class EconService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="MaxTrades">The number of trades to return information for</param>
		/// <param name="StartAfterTime">The time of the last trade shown on the previous page of results, or the time of the first trade if navigating back</param>
		/// <param name="StartAfterTradeid">The tradeid shown on the previous page of results, or the ID of the first trade if navigating back</param>
		/// <param name="NavigatingBack">The user wants the previous page of results, so return the previous max_trades trades before the start time and ID</param>
		/// <param name="GetDescriptions">If set, the item display data for the items included in the returned trades will also be returned</param>
		/// <param name="Language">The language to use when loading item display data</param>
		/// <param name="IncludeFailed"></param>
		/// <param name="IncludeTotal">If set, the total number of trades the account has participated in will be included in the response</param>
		public static async void GetTradeHistory(string Key, uint MaxTrades, uint StartAfterTime, ulong StartAfterTradeid, bool NavigatingBack, bool GetDescriptions, string Language, bool IncludeFailed, bool IncludeTotal)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["max_trades"] = MaxTrades.ToString();
			query["start_after_time"] = StartAfterTime.ToString();
			query["start_after_tradeid"] = StartAfterTradeid.ToString();
			query["navigating_back"] = NavigatingBack.ToString();
			query["get_descriptions"] = GetDescriptions.ToString();
			query["language"] = Language;
			query["include_failed"] = IncludeFailed.ToString();
			query["include_total"] = IncludeTotal.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconService", "GetTradeHistory", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Tradeid"></param>
		/// <param name="GetDescriptions">If set, the item display data for the items included in the returned trades will also be returned</param>
		/// <param name="Language">The language to use when loading item display data</param>
		public static async void GetTradeStatus(string Key, ulong Tradeid, bool GetDescriptions, string Language)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["tradeid"] = Tradeid.ToString();
			query["get_descriptions"] = GetDescriptions.ToString();
			query["language"] = Language;
			JObject response = await API.Instance.GetResponseAsync("IEconService", "GetTradeStatus", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="GetSentOffers">Request the list of sent offers.</param>
		/// <param name="GetReceivedOffers">Request the list of received offers.</param>
		/// <param name="GetDescriptions">If set, the item display data for the items included in the returned trade offers will also be returned. If one or more descriptions can't be retrieved, then your request will fail.</param>
		/// <param name="Language">The language to use when loading item display data.</param>
		/// <param name="ActiveOnly">Indicates we should only return offers which are still active, or offers that have changed in state since the time_historical_cutoff</param>
		/// <param name="HistoricalOnly">Indicates we should only return offers which are not active.</param>
		/// <param name="TimeHistoricalCutoff">When active_only is set, offers updated since this time will also be returned</param>
		public static async void GetTradeOffers(string Key, bool GetSentOffers, bool GetReceivedOffers, bool GetDescriptions, string Language, bool ActiveOnly, bool HistoricalOnly, uint TimeHistoricalCutoff)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["get_sent_offers"] = GetSentOffers.ToString();
			query["get_received_offers"] = GetReceivedOffers.ToString();
			query["get_descriptions"] = GetDescriptions.ToString();
			query["language"] = Language;
			query["active_only"] = ActiveOnly.ToString();
			query["historical_only"] = HistoricalOnly.ToString();
			query["time_historical_cutoff"] = TimeHistoricalCutoff.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconService", "GetTradeOffers", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Tradeofferid"></param>
		/// <param name="Language"></param>
		/// <param name="GetDescriptions">If set, the item display data for the items included in the returned trade offers will also be returned. If one or more descriptions can't be retrieved, then your request will fail.</param>
		public static async void GetTradeOffer(string Key, ulong Tradeofferid, string Language, bool GetDescriptions)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["tradeofferid"] = Tradeofferid.ToString();
			query["language"] = Language;
			query["get_descriptions"] = GetDescriptions.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconService", "GetTradeOffer", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="TimeLastVisit">The time the user last visited.  If not passed, will use the time the user last visited the trade offer page.</param>
		public static async void GetTradeOffersSummary(string Key, uint TimeLastVisit)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["time_last_visit"] = TimeLastVisit.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconService", "GetTradeOffersSummary", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Tradeofferid"></param>
		public static async void DeclineTradeOffer(string Key, ulong Tradeofferid)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["tradeofferid"] = Tradeofferid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconService", "DeclineTradeOffer", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Tradeofferid"></param>
		public static async void CancelTradeOffer(string Key, ulong Tradeofferid)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["tradeofferid"] = Tradeofferid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconService", "CancelTradeOffer", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="SteamidTarget">User you are trading with</param>
		/// <param name="TradeOfferAccessToken">A special token that allows for trade offers from non-friends.</param>
		public static async void GetTradeHoldDurations(string Key, ulong SteamidTarget, string TradeOfferAccessToken)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["steamid_target"] = SteamidTarget.ToString();
			query["trade_offer_access_token"] = TradeOfferAccessToken;
			JObject response = await API.Instance.GetResponseAsync("IEconService", "GetTradeHoldDurations", 1, query);
		}
	}
}
