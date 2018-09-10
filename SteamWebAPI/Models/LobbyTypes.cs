using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SteamWebAPI.Models
{
	public enum LobbyTypes
	{
		[Description("Invalid")]
		Invalid = -1,
		[Description("Public matchmaking")]
		PublicMatchmaking = 0,
		[Description("Practise")]
		Practise = 1,
		[Description("Tournament")]
		Tournament = 2,
		[Description("Tutorial")]
		Tutorial = 3,
		[Description("Co-op with bots")]
		CoopWithBots = 4,
		[Description("Team match")]
		TeamMatch = 5,
		[Description("Solo Queue")]
		SoloQueue = 6,
		[Description("Ranked Matchmaking")]
		RankedMatchmaking = 7,
		[Description("1v1 Solo Mid")]
		OneVsOneSoloMid = 8
	}
}
