using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class SteamUserAuth
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Steamid">Should be the users steamid, unencrypted.</param>
		/// <param name="Sessionkey">Should be a 32 byte random blob of data, which is then encrypted with RSA using the Steam system's public key.  Randomness is important here for security.</param>
		/// <param name="EncryptedLoginkey">Should be the users hashed loginkey, AES encrypted with the sessionkey.</param>
		public static async void AuthenticateUser(ulong Steamid, byte[] Sessionkey, byte[] EncryptedLoginkey)
		{
			var query = new NameValueCollection();
			query["steamid"] = Steamid.ToString();
			query["sessionkey"] = Sessionkey.ToString();
			query["encrypted_loginkey"] = EncryptedLoginkey.ToString();
			JObject response = await API.Instance.GetResponseAsync("ISteamUserAuth", "AuthenticateUser", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">access key</param>
		/// <param name="Appid">appid of game</param>
		/// <param name="Ticket">Ticket from GetAuthSessionTicket.</param>
		public static async void AuthenticateUserTicket(string Key, uint Appid, string Ticket)
		{
			var query = new NameValueCollection();
			query["key"] = Key;
			query["appid"] = Appid.ToString();
			query["ticket"] = Ticket;
			JObject response = await API.Instance.GetResponseAsync("ISteamUserAuth", "AuthenticateUserTicket", 1, query);
		}
	}
}
