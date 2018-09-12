using System;
using System.Collections.Specialized;
using System.Web;
using Newtonsoft.Json.Linq;

namespace SteamWebAPI
{
	public static class CheatReportingService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Key">Access key</param>
		/// <param name="Steamid">steamid of the user running and reporting the cheat.</param>
		/// <param name="Appid">The appid.</param>
		/// <param name="Pathandfilename">path and file name of the cheat executable.</param>
		/// <param name="Webcheaturl">web url where the cheat was found and downloaded.</param>
		/// <param name="TimeNow">local system time now.</param>
		/// <param name="TimeStarted">local system time when cheat process started. ( 0 if not yet run )</param>
		/// <param name="TimeStopped">local system time when cheat process stopped. ( 0 if still running )</param>
		/// <param name="Cheatname">descriptive name for the cheat.</param>
		/// <param name="GameProcessId">process ID of the running game.</param>
		/// <param name="CheatProcessId">process ID of the cheat process that ran</param>
		/// <param name="CheatParam1">cheat param 1</param>
		/// <param name="CheatParam2">cheat param 2</param>
		public static async void ReportCheatData(string Key, ulong Steamid, uint Appid, string Pathandfilename, string Webcheaturl, ulong TimeNow, ulong TimeStarted, ulong TimeStopped, string Cheatname, uint GameProcessId, uint CheatProcessId, ulong CheatParam1, ulong CheatParam2)
		{
			var query = HttpUtility.ParseQueryString("");
			query["key"] = Key;
			query["steamid"] = Steamid.ToString();
			query["appid"] = Appid.ToString();
			query["pathandfilename"] = Pathandfilename;
			query["webcheaturl"] = Webcheaturl;
			query["time_now"] = TimeNow.ToString();
			query["time_started"] = TimeStarted.ToString();
			query["time_stopped"] = TimeStopped.ToString();
			query["cheatname"] = Cheatname;
			query["game_process_id"] = GameProcessId.ToString();
			query["cheat_process_id"] = CheatProcessId.ToString();
			query["cheat_param_1"] = CheatParam1.ToString();
			query["cheat_param_2"] = CheatParam2.ToString();
			JObject response = await API.Instance.GetResponseAsync("ICheatReportingService", "ReportCheatData", 1, query);
		}
	}
}
