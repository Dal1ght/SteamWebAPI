using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class GameNotificationsService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">The appid to create the session for.</param>
		/// <param name="Context">Game-specified context value the game can used to associate the session with some object on their backend.</param>
		/// <param name="Title">The title of the session to be displayed within each user's list of sessions.</param>
		/// <param name="Users">The initial state of all users in the session.</param>
		/// <param name="Steamid">(Optional) steamid to make the request on behalf of -- if specified, the user must be in the session and all users being added to the session must be friends with the user.</param>
		public static async void UserCreateSession(uint Appid, ulong Context, object Title, object Users, ulong Steamid)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			query["context"] = Context.ToString();
			query["title"] = Title.ToString();
			query["users"] = Users.ToString();
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameNotificationsService", "UserCreateSession", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Sessionid">The sessionid to update.</param>
		/// <param name="Appid">The appid of the session to update.</param>
		/// <param name="Title">(Optional) The new title of the session.  If not specified, the title will not be changed.</param>
		/// <param name="Users">(Optional) A list of users whose state will be updated to reflect the given state. If the users are not already in the session, they will be added to it.</param>
		/// <param name="Steamid">(Optional) steamid to make the request on behalf of -- if specified, the user must be in the session and all users being added to the session must be friends with the user.</param>
		public static async void UserUpdateSession(ulong Sessionid, uint Appid, object Title, object Users, ulong Steamid)
		{
			var query = new NameValueCollection();
			query["sessionid"] = Sessionid.ToString();
			query["appid"] = Appid.ToString();
			query["title"] = Title.ToString();
			query["users"] = Users.ToString();
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameNotificationsService", "UserUpdateSession", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Sessionid">The sessionid to delete.</param>
		/// <param name="Appid">The appid of the session to delete.</param>
		/// <param name="Steamid">(Optional) steamid to make the request on behalf of -- if specified, the user must be in the session.</param>
		public static async void UserDeleteSession(ulong Sessionid, uint Appid, ulong Steamid)
		{
			var query = new NameValueCollection();
			query["sessionid"] = Sessionid.ToString();
			query["appid"] = Appid.ToString();
			query["steamid"] = Steamid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IGameNotificationsService", "UserDeleteSession", 1, query);
		}
	}
}
