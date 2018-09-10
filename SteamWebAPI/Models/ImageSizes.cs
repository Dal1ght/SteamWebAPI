using System;
using System.Collections.Generic;
using System.Text;

namespace SteamWebAPI.Models
{
	public enum ImageSizes
	{
		/// <summary>
		/// 59x33px small horizontal portrait
		/// </summary>
		SmallHorizontal,

		/// <summary>
		/// 205x105px large horizontal portrait
		/// </summary>
		LargeHorizontal,

		/// <summary>
		/// 256x144px full-quality horizontal portrait
		/// </summary>
		FullHorizontal,

		/// <summary>
		/// 235x272px full-quality vertical portrait (note that this is a .jpg)
		/// </summary>
		FullVertical
	}
}
