using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamWebUserPresenceOAuth
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">Steam ID of the user</param>
		/// <param name="Umqid">UMQ Session ID</param>
		/// <param name="Message">Message that was last known to the user</param>
		/// <param name="Pollid">Caller-specific poll id</param>
		/// <param name="Sectimeout">Long-poll timeout in seconds</param>
		/// <param name="Secidletime">How many seconds is client considering itself idle, e.g. screen is off</param>
		/// <param name="UseAccountids">Boolean, 0 (default): return steamid_from in output, 1: return accountid_from</param>
		public static async void PollStatus(string Steamid, ulong Umqid, uint Message, uint? Pollid = null, uint? Sectimeout = null, uint? Secidletime = null, uint? UseAccountids = null)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid;
			query["umqid"] = Umqid.ToString();
			query["message"] = Message.ToString();
			if (Pollid != null)
				query["pollid"] = Pollid.ToString();
			if (Sectimeout != null)
				query["sectimeout"] = Sectimeout.ToString();
			if (Secidletime != null)
				query["secidletime"] = Secidletime.ToString();
			if (UseAccountids != null)
				query["use_accountids"] = UseAccountids.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamWebUserPresenceOAuth", "PollStatus", 1, query);
		}
	}
}
