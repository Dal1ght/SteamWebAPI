# SteamWebAPI
This is .Net Standard 2.0 library. Requires Newtonsoft.JSON nuget package.

## API supporting
### DOTA2Fantasy (IDOTA2Fantasy_570) 
- GetFantasyPlayerStats
- GetPlayerOfficialInfo

### DOTA2MatchStats (IDOTA2MatchStats_570) 
- GetRealtimeStats

### DOTA2Match (IDOTA2Match_570) 
- GetLeagueListing
- GetLiveLeagueGames
- GetMatchDetails
- GetMatchHistory
- GetMatchHistoryBySequenceNum
- GetTeamInfoByTeamID
- GetTopLiveEventGame
- GetTopLiveGame
- GetTopWeekendTourneyGames
- GetTournamentPlayerStats
- GetTournamentPlayerStatsV2

### DOTA2StreamSystem (IDOTA2StreamSystem_570) 
- GetBroadcasterInfo

### DOTA2Ticket (IDOTA2Ticket_570) 
- ClaimBadgeReward
- GetSteamIDForBadgeID
- SetSteamAccountPurchased
- SteamAccountValidForBadgeType

### EconDOTA2 (IEconDOTA2_570) 
- GetEventStatsForAccount
- GetGameItems
- GetHeroes
- GetItemIconPath
- GetRarities
- GetTournamentPrizePool

### EconItems (IEconItems_570) 
- GetEquippedPlayerItems
- GetPlayerItems
- GetSchemaURL
- GetStoreMetaData

### GCVersion (IGCVersion_570) 
- GetClientVersion
- GetServerVersion

### SteamApps (ISteamApps) 
- GetAppList
- GetAppListV2
- GetServersAtAddress
- UpToDateCheck

### SteamCDN (ISteamCDN) 
- SetClientFilters
- SetPerformanceStats

### SteamDirectory (ISteamDirectory) 
- GetCMList
- GetCSList
- GetSteamPipeDomains

### SteamEconomy (ISteamEconomy) 
- GetAssetClassInfo
- GetAssetPrices

### SteamEnvoy (ISteamEnvoy) 
- PaymentOutReversalNotification

### SteamNews (ISteamNews) 
- GetNewsForApp
- GetNewsForAppV2

### SteamRemoteStorage (ISteamRemoteStorage) 
- GetCollectionDetails
- GetPublishedFileDetails
- GetUGCFileDetails

### SteamUser (ISteamUser) 
- GetFriendList
- GetPlayerBans
- GetPlayerSummaries
- GetPlayerSummariesV2
- GetUserGroupList
- ResolveVanityURL

### SteamUserAuth (ISteamUserAuth) 
- AuthenticateUser
- AuthenticateUserTicket

### SteamUserOAuth (ISteamUserOAuth) 
- GetTokenDetails

### SteamUserStats (ISteamUserStats) 
- GetGlobalAchievementPercentagesForApp
- GetGlobalAchievementPercentagesForAppV2
- GetGlobalStatsForGame
- GetNumberOfCurrentPlayers
- GetPlayerAchievements
- GetSchemaForGame
- GetSchemaForGameV2
- GetUserStatsForGame
- GetUserStatsForGameV2

### SteamWebAPIUtil (ISteamWebAPIUtil) 
- GetServerInfo
- GetSupportedAPIList

### SteamWebUserPresenceOAuth (ISteamWebUserPresenceOAuth) 
- PollStatus

### TFPromos (ITFPromos_570) 
- GetItemID
- GrantItem

### GameServersService (IGameServersService) 
- GetAccountList
- CreateAccount
- SetMemo
- ResetLoginToken
- DeleteAccount
- GetAccountPublicInfo
- QueryLoginToken
- GetServerSteamIDsByIP
- GetServerIPsBySteamID

### BroadcastService (IBroadcastService) 
- PostGameDataFrameRTMP

### ContentServerConfigService (IContentServerConfigService) 
- SetSteamCacheClientFilters
- GetSteamCacheNodeParams
- SetSteamCachePerformanceStats

### PublishedFileService (IPublishedFileService) 
- QueryFiles
- GetDetails
- GetUserFiles

### EconService (IEconService) 
- GetTradeHistory
- GetTradeStatus
- GetTradeOffers
- GetTradeOffer
- GetTradeOffersSummary
- DeclineTradeOffer
- CancelTradeOffer
- GetTradeHoldDurations

### PlayerService (IPlayerService) 
- RecordOfflinePlaytime
- GetRecentlyPlayedGames
- GetOwnedGames
- GetSteamLevel
- GetBadges
- GetCommunityBadgeProgress
- IsPlayingSharedGame

### GameNotificationsService (IGameNotificationsService) 
- UserCreateSession
- UserUpdateSession
- UserDeleteSession

### InventoryService (IInventoryService) 
- SplitItemStack
- CombineItemStacks
- GetPriceSheet

### StoreService (IStoreService) 
- GetAppList

### CheatReportingService (ICheatReportingService) 
- ReportCheatData
