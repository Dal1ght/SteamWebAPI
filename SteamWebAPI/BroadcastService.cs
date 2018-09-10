using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class BroadcastService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Appid">AppID of the game being broadcasted</param>
		/// <param name="Steamid">Broadcasters SteamID</param>
		/// <param name="RtmpToken">Valid RTMP token for the Broadcaster</param>
		/// <param name="FrameData">game data frame expressing current state of game (string, zipped, whatever)</param>
		public static async void PostGameDataFrameRTMP(uint Appid, ulong Steamid, string RtmpToken, string FrameData)
		{
			var query = new NameValueCollection();
			query["appid"] = Appid.ToString();
			query["steamid"] = Steamid.ToString();
			query["rtmp_token"] = RtmpToken;
			query["frame_data"] = FrameData;
			JObject response = await API.Instance.GetResponseAsync("IBroadcastService", "PostGameDataFrameRTMP", 1, query);
		}
	}
}
