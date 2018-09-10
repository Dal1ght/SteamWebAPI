using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class DOTA2Ticket
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="BadgeID">The Badge ID</param>
		/// <param name="ValidBadgeType1">Valid Badge Type 1</param>
		/// <param name="ValidBadgeType2">Valid Badge Type 2</param>
		/// <param name="ValidBadgeType3">Valid Badge Type 3</param>
		public static async void ClaimBadgeReward(string BadgeID, uint ValidBadgeType1, uint ValidBadgeType2, uint ValidBadgeType3)
		{
			var query = new NameValueCollection();
			query["BadgeID"] = BadgeID;
			query["ValidBadgeType1"] = ValidBadgeType1.ToString();
			query["ValidBadgeType2"] = ValidBadgeType2.ToString();
			query["ValidBadgeType3"] = ValidBadgeType3.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Ticket_570", "ClaimBadgeReward", 1, query);
		}
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="BadgeID">The badge ID</param>
		public static async void GetSteamIDForBadgeID(string BadgeID)
		{
			var query = new NameValueCollection();
			query["BadgeID"] = BadgeID;
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Ticket_570", "GetSteamIDForBadgeID", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">The 64-bit Steam ID</param>
		/// <param name="BadgeType">Badge Type</param>
		public static async void SetSteamAccountPurchased(ulong Steamid, uint BadgeType)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			query["BadgeType"] = BadgeType.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Ticket_570", "SetSteamAccountPurchased", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">The 64-bit Steam ID</param>
		/// <param name="ValidBadgeType1">Valid Badge Type 1</param>
		/// <param name="ValidBadgeType2">Valid Badge Type 2</param>
		/// <param name="ValidBadgeType3">Valid Badge Type 3</param>
		public static async void SteamAccountValidForBadgeType(ulong Steamid, uint ValidBadgeType1, uint ValidBadgeType2, uint ValidBadgeType3)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			query["ValidBadgeType1"] = ValidBadgeType1.ToString();
			query["ValidBadgeType2"] = ValidBadgeType2.ToString();
			query["ValidBadgeType3"] = ValidBadgeType3.ToString();
			JObject response = await API.Instance.GetResponseAsync("IDOTA2Ticket_570", "SteamAccountValidForBadgeType", 1, query);
		}
	}
}
