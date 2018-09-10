using System;

namespace SteamWebAPI.Models
{
	public class BarracksStatus
	{
		public bool BottomRanged { get; set; }
		public bool BottomMelee { get; set; }
		public bool MiddleRanged { get; set; }
		public bool MiddleMelee { get; set; }
		public bool TopRanged { get; set; }
		public bool TopMelee { get; set; }

		public BarracksStatus(long longValue)
		{
			int value = (int)longValue;
			TopMelee = (value | 0b000001) == value;
			TopRanged = (value | 0b000010) == value;
			MiddleMelee = (value | 0b000100) == value;
			MiddleRanged = (value | 0b001000) == value;
			BottomMelee = (value | 0b010000) == value;
			BottomRanged = (value | 0b100000) == value;
		}
	}
}
