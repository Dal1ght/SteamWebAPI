using Newtonsoft.Json;
using SteamWebAPI.Converters;
using System;

namespace SteamWebAPI.Models
{
	/// <summary>
	/// <see cref="https://developer.valvesoftware.com/wiki/Steam_Web_API"/>
	/// </summary>
	public class PlayerSummaryModel
	{
		/// <summary>
		/// 64bit SteamID of the user
		/// </summary>
		[JsonProperty("steamid")]
		public long SteamID { get; set; }

		/// <summary>
		/// The player's persona name (display name)
		/// </summary>
		[JsonProperty("personaname")]
		public string DisplayName { get; set; }

		/// <summary>
		/// The full URL of the player's Steam Community profile.
		/// </summary>
		[JsonProperty("profileurl")]
		public string ProfileURL { get; set; }

		/// <summary>
		/// The full URL of the player's 32x32px avatar. If the user hasn't configured an avatar, this will be the default ? avatar.
		/// </summary>
		[JsonProperty("avatar")]
		public string AvatarURL { get; set; }

		/// <summary>
		/// The full URL of the player's 64x64px avatar. If the user hasn't configured an avatar, this will be the default ? avatar.
		/// </summary>
		[JsonProperty("avatarmedium")]
		public string AvatarMediumURL { get; set; }

		/// <summary>
		/// The full URL of the player's 184x184px avatar. If the user hasn't configured an avatar, this will be the default ? avatar.
		/// </summary>
		[JsonProperty("avatarfull")]
		public string AvatarFullURL { get; set; }

		/// <summary>
		/// The user's current status. 0 - Offline, 1 - Online, 2 - Busy, 3 - Away, 4 - Snooze, 5 - looking to trade, 6 - looking to play. 
		/// If the player's profile is private, this will always be "0", except if the user has set their status to looking to trade or looking to play, 
		/// because a bug makes those status appear even if the profile is private.
		/// </summary>
		[JsonProperty("personastate")]
		public int State { get; set; }

		/// <summary>
		/// This represents whether the profile is visible or not, and if it is visible, why you are allowed to see it. 
		/// Note that because this WebAPI does not use authentication, there are only two possible values returned: 
		/// 1 - the profile is not visible to you (Private, Friends Only, etc), 
		/// 3 - the profile is "Public", and the data is visible.
		/// </summary>
		[JsonProperty("communityvisibilitystate")]
		public int CommunityVisibilityState { get; set; }

		/// <summary>
		/// If set, indicates the user has a community profile configured (will be set to '1')
		/// </summary>
		[JsonProperty("profilestate")]
		public bool ProfileState { get; set; }

		/// <summary>
		/// The last time the user was online, in unix time.
		/// </summary>
		[JsonProperty("lastlogoff")]
		[JsonConverter(typeof(UnixTimeConverter))]
		public DateTime LastLogoffTime { get; set; }

		/// <summary>
		/// If set, indicates the profile allows public comments.
		/// </summary>
		[JsonProperty("commentpermission")]
		public bool CommentPermission { get; set; }

		/// <summary>
		/// The player's "Real Name", if they have set it.
		/// </summary>
		[JsonProperty("realname")]
		public string RealName { get; set; }

		/// <summary>
		/// The player's primary group, as configured in their Steam Community profile.
		/// </summary>
		[JsonProperty("primaryclanid")]
		public long PrimaryClanID { get; set; }

		/// <summary>
		/// The time the player's account was created.
		/// </summary>
		[JsonProperty("timecreated")]
		[JsonConverter(typeof(UnixTimeConverter))]
		public DateTime TimeCreated { get; set; }

		/// <summary>
		/// If the user is currently in-game, this value will be returned and set to the gameid of that game.
		/// </summary>
		[JsonProperty("gameid")]
		public int GameID { get; set; }

		/// <summary>
		/// The ip and port of the game server the user is currently playing on, if they are playing on-line in a game using Steam matchmaking. 
		/// Otherwise will be set to "0.0.0.0:0".
		/// </summary>
		[JsonProperty("gameserverip")]
		public string GameServerIP { get; set; }

		/// <summary>
		/// If the user is currently in-game, this will be the name of the game they are playing. This may be the name of a non-Steam game shortcut.
		/// </summary>
		[JsonProperty("gameextrainfo")]
		public string GameName { get; set; }

		/// <summary>
		/// If set on the user's Steam Community profile, The user's country of residence, 2-character ISO country code
		/// </summary>
		[JsonProperty("loccountrycode")]
		public string Country { get; set; }

		/// <summary>
		/// If set on the user's Steam Community profile, The user's state of residence
		/// </summary>
		[JsonProperty("locstatecode")]
		public int StateCode { get; set; }

		//TODO: decode country, state and city from https://github.com/Holek/steam-friends-countries

		/// <summary>
		/// An internal code indicating the user's city of residence. A future update will provide this data in a more useful way.
		/// </summary>
		[JsonProperty("loccityid")]
		public int CityID { get; set; }

		/// <summary>
		/// ???
		/// </summary>
		[JsonProperty("personastateflags")]
		public int PersonalStateFlags { get; set; }
	}
}
