using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public enum Teams
	{
		Radiant = 0,
		Dire = 1,
		Broadcaster = 2,
		Unassigned = 4
	}

	public class PlayerSlotModel
	{
		/// <summary>
		/// Slot`s team
		/// </summary>
		public Teams Team { get; set; }
		/// <summary>
		/// Slot number (0-4)
		/// </summary>
		public int Slot { get; set; }

		public PlayerSlotModel(long longValue)
		{
			int value = (int)longValue;
			if ((value | 128) == value)
			{
				Team = Teams.Dire;
				Slot = value ^ 128;
			}
			else
			{
				Team = Teams.Radiant;
				Slot = value;
			}
		}
	}
}
