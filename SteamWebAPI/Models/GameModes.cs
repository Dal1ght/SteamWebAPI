using System;
using System.ComponentModel;
using System.Text;

namespace SteamWebAPI.Models
{
	public enum GameModes
	{
		[Description("None")]
		None = 0,

		[Description("All Pick")]
		AllPick = 1,

		[Description("Captain's Mode")]
		CaptainsMode = 2,

		[Description("Random Draft")]
		RandomDraft = 3,

		[Description("Single Draft")]
		SingleDraft = 4,

		[Description("All Random")]
		AllRandom = 5,

		[Description("Intro")]
		Intro = 6,

		[Description("Diretide")]
		Diretide = 7,

		[Description("Reverse Captain's Mode")]
		ReverseCaptainsMode = 8,

		[Description("The Greeviling")]
		TheGreeviling = 9,

		[Description("Tutorial")]
		Tutorial = 10,

		[Description("Mid Only")]
		MidOnly = 11,

		[Description("Least Played")]
		LeastPlayed = 12,

		[Description("New Player Pool")]
		NewPlayerPool = 13,

		[Description("Compendium Matchmaking")]
		CompendiumMatchmaking = 14,

		[Description("Custom")]
		Custom = 15,

		[Description("Captain's Draft")]
		CaptainsDraft = 16,

		[Description("Balanced draft")]
		BalancedDraft = 17,

		[Description("Ability draft")]
		AbilityDraft = 18,

		[Description("Event")]
		Event = 19,

		[Description("All random death match")]
		AllRandomDeathMatch = 20,

		[Description("1 vs. 1 solo mid")]
		SoloMid1vs1 = 21,

		[Description("Ranked all pick")]
		RankedAllPick = 22
	}
}
