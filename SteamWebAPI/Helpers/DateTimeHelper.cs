﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Helpers
{
	public static class DateTimeHelper
	{
		public static DateTime FromUnixTime(long time)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return dateTime.AddSeconds(time);
		}
	}
}
