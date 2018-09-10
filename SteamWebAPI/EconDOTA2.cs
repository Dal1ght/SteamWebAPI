using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SteamWebAPI.Models;

namespace SteamWebAPI
{
	public static class EconDOTA2
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Eventid">The League ID of the compendium you're looking for.</param>
		/// <param name="Accountid">The account ID to look up.</param>
		/// <param name="Language">The language to provide hero names in.</param>
		public static async void GetEventStatsForAccount(uint Eventid, uint Accountid, string Language = null)
		{
			var query = new NameValueCollection();
			query["eventid"] = Eventid.ToString();
			query["accountid"] = Accountid.ToString();
			if (Language != null)
				query["language"] = Language;
			JObject response = await API.Instance.GetResponseAsync("IEconDOTA2_570", "GetEventStatsForAccount", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Language">The language to provide item names in.</param>
		public static async Task<List<GameItemModel>> GetGameItems(string Language = null)
		{
			var query = new NameValueCollection();
			if (Language != null)
				query["language"] = Language;
			JObject response = await API.Instance.GetResponseAsync("IEconDOTA2_570", "GetGameItems", 1, query);
			return JsonConvert.DeserializeObject<List<GameItemModel>>(response["result"]["items"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// A list of heroes within Dota 2.
		/// <see cref="https://wiki.teamfortress.com/wiki/WebAPI/GetHeroes"/>
		/// </summary>
		/// <param name="Itemizedonly">Return a list of itemized heroes only.</param>
		public static async Task<List<HeroModel>> GetHeroes(bool? Itemizedonly = null)
		{
			var query = new NameValueCollection();
			if (Itemizedonly != null)
				query["itemizedonly"] = Itemizedonly.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconDOTA2_570", "GetHeroes", 1, query);
			return JsonConvert.DeserializeObject<List<HeroModel>>(response["result"]["heroes"].ToString(), API.SerializerSettings);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Iconname">The item icon name to get the CDN path of</param>
		/// <param name="Icontype">The type of image you want. 0 = normal, 1 = large, 2 = ingame</param>
		public static async void GetItemIconPath(string Iconname, uint? Icontype = null)
		{
			var query = new NameValueCollection();
			query["iconname"] = Iconname;
			if (Icontype != null)
				query["icontype"] = Icontype.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconDOTA2_570", "GetItemIconPath", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Language">The language to provide rarity names in.</param>
		public static async void GetRarities(string Language = null)
		{
			var query = new NameValueCollection();
			if (Language != null)
				query["language"] = Language;
			JObject response = await API.Instance.GetResponseAsync("IEconDOTA2_570", "GetRarities", 1, query);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="Leagueid">The ID of the league to get the prize pool of</param>
		public static async void GetTournamentPrizePool(uint? Leagueid = null)
		{
			var query = new NameValueCollection();
			if (Leagueid != null)
				query["leagueid"] = Leagueid.ToString();
			JObject response = await API.Instance.GetResponseAsync("IEconDOTA2_570", "GetTournamentPrizePool", 1, query);
		}
	}
}
