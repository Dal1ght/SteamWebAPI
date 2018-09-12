using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class GameServersService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		public static async void GetAccountList(string Key)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "GetAccountList", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Appid">The app to use the account for</param>
		/// <param name="Memo">The memo to set on the new account</param>
		public static async void CreateAccount(string Key, uint Appid, string Memo)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["appid"] = Appid.ToString();
			query["memo"] = Memo;
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "CreateAccount", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The SteamID of the game server to set the memo on</param>
		/// <param name="Memo">The memo to set on the new account</param>
		public static async void SetMemo(string Key, ulong Steamid, string Memo)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["memo"] = Memo;
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "SetMemo", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The SteamID of the game server to reset the login token of</param>
		public static async void ResetLoginToken(string Key, ulong Steamid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "ResetLoginToken", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The SteamID of the game server account to delete</param>
		public static async void DeleteAccount(string Key, ulong Steamid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "DeleteAccount", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">The SteamID of the game server to get info on</param>
		public static async void GetAccountPublicInfo(string Key, ulong Steamid)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "GetAccountPublicInfo", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="LoginToken">Login token to query</param>
		public static async void QueryLoginToken(string Key, string LoginToken)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["login_token"] = LoginToken;
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "QueryLoginToken", 1, query);
		}
	
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="ServerIps"></param>
		public static async void GetServerSteamIDsByIP(string Key, string ServerIps)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["server_ips"] = ServerIps;
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "GetServerSteamIDsByIP", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="ServerSteamids"></param>
		public static async void GetServerIPsBySteamID(string Key, ulong ServerSteamids)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["server_steamids"] = ServerSteamids.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameServersService", "GetServerIPsBySteamID", 1, query);
		}
	}
}
