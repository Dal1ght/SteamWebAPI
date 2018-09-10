using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SteamWebAPI.Models
{
	public enum SkillBracket
	{
		[Description("Any")]
		Any = 0,
		[Description("Normal")]
		Normal = 1,
		[Description("High")]
		High = 2,
		[Description("Very High")]
		VeryHigh = 3
	}
}
