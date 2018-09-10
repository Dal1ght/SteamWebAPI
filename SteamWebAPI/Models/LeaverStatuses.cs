using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SteamWebAPI.Models
{
	public enum LeaverStatuses
	{
		[Description("NONE - finished match, no abandon.")]
		None = 0,
		[Description("DISCONNECTED - player DC, no abandon.")]
		Disconnected = 1,
		[Description("DISCONNECTED_TOO_LONG - player DC > 5min, abandoned.")]
		DisconnectedTooLong = 2,
		[Description("ABANDONED - player DC, clicked leave, abandoned.")]
		Abandoned = 3,
		[Description("AFK - player AFK, abandoned.")]
		AFK = 4,
		[Description("NEVER_CONNECTED - player never connected, no abandon.")]
		NeverConnected = 5,
		[Description("NEVER_CONNECTED_TOO_LONG - player took too long to connect, no abandon.")]
		NeverConnectedTooLong = 6
	}
}
