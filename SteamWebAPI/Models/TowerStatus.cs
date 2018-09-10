using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public class TowerStatus
	{
		public bool AncientBottom { get; set; }
		public bool AncientTop { get; set; }
		public bool BottomTier3 { get; set; }
		public bool BottomTier2 { get; set; }
		public bool BottomTier1 { get; set; }
		public bool MiddleTier3 { get; set; }
		public bool MiddleTier2 { get; set; }
		public bool MiddleTier1 { get; set; }
		public bool TopTier3 { get; set; }
		public bool TopTier2 { get; set; }
		public bool TopTier1 { get; set; }

		public TowerStatus(long longValue)
		{
			int value = (int)longValue;
			TopTier1 = (value | 0b00000000001) == value;
			TopTier2 = (value | 0b00000000010) == value;
			TopTier3 = (value | 0b00000000100) == value;
			MiddleTier1 = (value | 0b00000001000) == value;
			MiddleTier2 = (value | 0b00000010000) == value;
			MiddleTier3 = (value | 0b00000100000) == value;
			BottomTier1 = (value | 0b00001000000) == value;
			BottomTier2 = (value | 0b00010000000) == value;
			BottomTier3 = (value | 0b00100000000) == value;
			AncientTop = (value | 0b01000000000) == value;
			AncientBottom = (value | 0b10000000000) == value;
		}
	}
}
