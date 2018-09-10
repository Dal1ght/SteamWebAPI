using SteamWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Helpers
{
    public static class ApiHelper
    {
		private static string GetImageSuffix(ImageSizes imageSize)
		{
			switch (imageSize)
			{
				case ImageSizes.SmallHorizontal: return "sb.png";
				case ImageSizes.LargeHorizontal: return "lg.png";
				case ImageSizes.FullHorizontal: return "full.png:";
				case ImageSizes.FullVertical: return "vert.jpg";
			}
			return null;
		}

		public static string GetHeroImageUrl(string heroName, ImageSizes imageSize)
		{
			string hero = heroName.Replace("npc_dota_hero_ ", "");
			return $"http://cdn.dota2.com/apps/dota2/images/heroes/{hero}_{GetImageSuffix(imageSize)}";
		}

		public static string GetItemImageUrl(string itemName, ImageSizes imageSize)
		{
			string item = itemName.Replace("item_", "");
			return $"http://cdn.dota2.com/apps/dota2/images/items/{item}_{GetImageSuffix(imageSize)}";
		}

		public static string GetClusterName(int cluster)
		{
			switch (cluster)
			{
				case 111:
					return "US West";
				case 121:
					return "US East";
				case 122:
					return "US East";
				case 131:
					return "Europe West";
				case 132:
					return "Europe West";
				case 133:
					return "Europe West";
				case 151:
					return "Southeast Asia";
				case 152:
					return "Southeast Asia";
				case 161:
					return "China";
				case 163:
					return "China";
				case 171:
					return "Australia";
				case 181:
					return "Russia";
				case 182:
					return "Russia";
				case 191:
					return "Europe East";
				case 200:
					return "South America";
			}
			return null;
		}

		public static string GetReplayURL(int cluster, long matchID, string replaySalt)
		{
			return $"http://replay{cluster}.valve.net/570/{matchID}_{replaySalt}.dem.bz2";
		}

	}
}
