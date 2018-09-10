using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Helpers
{
	public static class BoolHelper
	{
		public static string ToIntString(this bool value)
		{
			if (value)
				return "1";
			else
				return "0";
		}

		public static string ToIntString(this bool? value)
		{
			if (value.HasValue)
				return value.HasValue.ToIntString();
			else
				return string.Empty;
		}
	}
}
