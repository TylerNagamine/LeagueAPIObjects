using System.Collections.Generic;

namespace LeagueApi
{
    // ToDo: Add leaguev2.5, Test BannedChampion

    // Shared
    #region Shared
    public class Observer
    {
        public string encryptionKey { get; set; }
    }
    public class Mastery
    {
        public long masteryId { get; set; }
        public int rank { get; set; }
    }
    public class Rune
    {
        public int count { get; set; }
        public long runeId { get; set; }
    }
    public class BannedChampion
    {
        public long championId { get; set; }
        public int pickTurn { get; set; }
        public long teamId { get; set; }
    }
    #endregion
    // Champion v1.2
    #region Championv1.2
    // Champion
    public class ChampionListDto
    {
        public List<ChampionDto> champions { get; set; }
    }
    public class ChampionDto
    {
        public bool active { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool freeToPlay { get; set; }
        public long id { get; set; }
        public bool rankedPlayEnabled { get; set; }
    }
    #endregion

    // Current-game v1.0
    #region Current game v1.0
    public class CurrentGameInfo
    {
        public List<BannedChampion> bannedChampions { get; set; }
        public long gameId { get; set; }
        public long gameLength { get; set; }
        public string gameMode { get; set; }
        public long gameQueueConfigId { get; set; }
        public long gameStartTime { get; set; }
        public string gameType { get; set; }
        public long mapId { get; set; }
        public Observer observers { get; set; }
        public List<CurrentGameParticipant> participants { get; set; }
        public string platformId { get; set; }
    }

    public class CurrentGameParticipant
    {
        public bool bot { get; set; }
        public long championId { get; set; }
        public List<Mastery> masteries { get; set; }
        public long profileIconId { get; set; }
        public List<Rune> runes { get; set; }
        public long spell1Id { get; set; }
        public long spell2Id { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }
        public long teamId { get; set; }
    }
    #endregion

    // Featured Games v1.0
    #region Featured games v1.0
    public class FeaturedGames
    {
        public long clientRefreshInterval { get; set; }
        public List<FeaturedGameInfo> gameList { get; set; }
    }
    public class FeaturedGameInfo
    {
        public List<BannedChampion> bannedChampions { get; set; }
        public long gameId { get; set; }
        public long gameLength { get; set; }
        public string gameMode { get; set; }
        public long gameQueueConfigId { get; set; }
        public long gameStartTime { get; set; }
        public string gameType { get; set; }
        public long mapId { get; set; }
        public Observer observers { get; set; }
        public List<CurrentGameParticipant> participants { get; set; }
        public string platformId { get; set; }
    }
    #endregion

    // Game v1.3
    #region Game v1.3
    public class RecentGamesDto
    {
        public HashSet<GameDto> games { get; set; }
        public long summonerId { get; set; }
    }
    public class GameDto
    {
        public int championId { get; set; }
        public long createDate { get; set; }
        public List<PlayerDto> fellowPlayers { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public string gameType { get; set; }
        public bool invalid { get; set; }
        public int ipEarned { get; set; }
        public int level { get; set; }
        public int mapId { get; set; }
        public int spell1 { get; set; }
        public int spell2 { get; set; }
        public RawStatsDto stats { get; set; }
        public string subType { get; set; }
        public int teamId { get; set; }
    }
    public class PlayerDto
    {
        public int championId { get; set; }
        public long summonerId { get; set; }
        public int teamId { get; set; }
    }
    public class RawStatsDto
    {
        public int assists { get; set; }
        public int barracksKilled { get; set; }
        public int championsKilled { get; set; }
        public int combatPlayerScore { get; set; }
        public int consumablesPurchased { get; set; }
        public int damageDealtPlayer { get; set; }
        public int doubleKills { get; set; }
        public int firstBlood { get; set; }
        public int gold { get; set; }
        public int goldEarned { get; set; }
        public int goldSpent { get; set; }
        public int item0 { get; set; }
        public int item1 { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }
        public int item6 { get; set; }
        public int itemsPurchased { get; set; }
        public int killingSprees { get; set; }
        public int largestCriticalStrike { get; set; }
        public int largestKillingSpree { get; set; }
        public int largestMultiKill { get; set; }
        public int legendaryItemsCreated { get; set; }
        public int level { get; set; }
        public int magicDamageDealtPlayer { get; set; }
        public int magicDamageDealtToChampions { get; set; }
        public int magicDamageTaken { get; set; }
        public int minionsDenied { get; set; }
        public int minionsKilled { get; set; }
        public int neutralMinionsKilled { get; set; }
        public int neutralMinionsKilledEnemyJungle { get; set; }
        public int neutralMinionsKilledYourJungle { get; set; }
        public bool nexusKilled { get; set; }
        public int nodeCapture { get; set; }
        public int nodeCaptureAssist { get; set; }
        public int nodeNeutralize { get; set; }
        public int nodeNeutralizeAssist { get; set; }
        public int numDeaths { get; set; }
        public int numItemsBought { get; set; }
        public int objectivePlayerScore { get; set; }
        public int pentaKills { get; set; }
        public int physicalDamageDealtPlayer { get; set; }
        public int physicalDamageDealtToChampions { get; set; }
        public int physicalDamageTaken { get; set; }
        public int playerPosition { get; set; }
        public int playerRole { get; set; }
        public int quadraKills { get; set; }
        public int sightWardsBought { get; set; }
        public int spell1Cast { get; set; }
        public int spell2Cast { get; set; }
        public int spell3Cast { get; set; }
        public int spell4Cast { get; set; }
        public int summonSpell1Cast { get; set; }
        public int summonSpell2Cast { get; set; }
        public int superMonsterKilled { get; set; }
        public int team { get; set; }
        public int teamObjective { get; set; }
        public int timePlayed { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalDamageDealtToChampions { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalHeal { get; set; }
        public int totalPlayerScore { get; set; }
        public int totalScoreRank { get; set; }
        public int totalTimeCrowdControlDealt { get; set; }
        public int totalUnitsHealed { get; set; }
        public int tripleKills { get; set; }
        public int trueDamageDealtPlayer { get; set; }
        public int trueDamageDealtToChampions { get; set; }
        public int trueDamageTaken { get; set; }
        public int turretsKilled { get; set; }
        public int unrealKills { get; set; }
        public int victoryPoTotal { get; set; }
        public int visionWardsBought { get; set; }
        public int wardKilled { get; set; }
        public int wardPlaced { get; set; }
        public bool win { get; set; }
    }
    #endregion

    // status v1.0
    #region status v1.0
    public class ShardStatus
    {
        public string hostname { get; set; }
        public List<string> locales { get; set; }
        public string name { get; set; }
        public string region_tag { get; set; }
        public List<Service> services { get; set; }
        public string slug { get; set; }
    }
    public class Service
    {
        public List<Incident> incidents { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string status { get; set; }
    }
    public class Incident
    {
        public bool active { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public List<Message> updates { get; set; }
    }
    public class Message
    {
        public string author { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public string severity { get; set; }
        public List<Translation> translations { get; set; }
        public string updated_at { get; set; }
    }
    public class Translation
    {
        public string content { get; set; }
        public string locale { get; set; }
        public string updated_at { get; set; }
    }
    #endregion

    // Match v2.2
    #region Match v2.2
    public class MatchDetail
    {
        public int mapId { get; set; }
        public long matchCreation { get; set; }
        public long matchDuration { get; set; }
        public long matchId { get; set; }
        public string matchMode { get; set; }
        public string matchType { get; set; }
        public string matchVersion { get; set; }
        public List<ParticipantIdentity> participantIdentities { get; set; }
        public List<Participant> participants { get; set; }
        public string platformId { get; set; }
        public string queueType { get; set; }
        public string region { get; set; }
        public string season { get; set; }
        public List<Team> teams { get; set; }
        public Timeline timeline { get; set; }
    }
    public class Participant
    {
        public int championId { get; set; }
        public string highestAchievedSeasonTier { get; set; }
        public List<Mastery> masteries { get; set; }
        public int participantId { get; set; }
        public List<Rune> runes { get; set; }
        public int spell1Id { get; set; }
        public int spell2Id { get; set; }
        public ParticipantStats stats { get; set; }
        public int teamId { get; set; }
        public ParticipantTimeline timeline { get; set; }
    }
    public class ParticipantIdentity
    {
	    public int participantId { get; set; }
        public Player player { get; set; }
    }
    public class Team
    {
        public List<BannedChampion> bans { get; set; }
        public int baronKills { get; set; }
        public long dominionVictoryScore { get; set; }
        public int dragonKills { get; set; }
        public bool firstBaron { get; set; }
        public bool firstBlood { get; set; }
        public bool firstDragon { get; set; }
        public bool firstInhibitor { get; set; }
        public bool firstRiftHerald { get; set; }
        public bool firstTower { get; set; }
        public int inhibitorKills { get; set; }
        public int riftHeraldKills { get; set; }
        public int teamId { get; set; }
        public int towerKills { get; set; }
        public int vilemawKills { get; set; }
        public bool winner { get; set; }
    }
    public class Timeline
    {
	    public long frameInterval { get; set; }
        public List<Frame> frames { get; set; }
    }
    public class ParticipantStats
    {
        public long assists { get; set; }
        public long champLevel { get; set; }
        public long combatPlayerScore { get; set; }
        public long deaths { get; set; }
        public long doubleKills { get; set; }
        public bool firstBloodAssist { get; set; }
        public bool firstBloodKill { get; set; }
        public bool firstInhibitorAssist { get; set; }
        public bool firstInhibitorKill { get; set; }
        public bool firstTowerAssist { get; set; }
        public bool firstTowerKill { get; set; }
        public long goldEarned { get; set; }
        public long goldSpent { get; set; }
        public long inhibitorKills { get; set; }
        public long item0 { get; set; }
        public long item1 { get; set; }
        public long item2 { get; set; }
        public long item3 { get; set; }
        public long item4 { get; set; }
        public long item5 { get; set; }
        public long item6 { get; set; }
        public long killingSprees { get; set; }
        public long kills { get; set; }
        public long largestCriticalStrike { get; set; }
        public long largestKillingSpree { get; set; }
        public long largestMultiKill { get; set; }
        public long magicDamageDealt { get; set; }
        public long magicDamageDealtToChampions { get; set; }
        public long magicDamageTaken { get; set; }
        public long minionsKilled { get; set; }
        public long neutralMinionsKilled { get; set; }
        public long neutralMinionsKilledEnemyJungle { get; set; }
        public long neutralMinionsKilledTeamJungle { get; set; }
        public long nodeCapture { get; set; }
        public long nodeCaptureAssist { get; set; }
        public long nodeNeutralize { get; set; }
        public long nodeNeutralizeAssist { get; set; }
        public long objectivePlayerScore { get; set; }
        public long pentaKills { get; set; }
        public long physicalDamageDealt { get; set; }
        public long physicalDamageDealtToChampions { get; set; }
        public long physicalDamageTaken { get; set; }
        public long quadraKills { get; set; }
        public long sightWardsBoughtInGame { get; set; }
        public long teamObjective { get; set; }
        public long totalDamageDealt { get; set; }
        public long totalDamageDealtToChampions { get; set; }
        public long totalDamageTaken { get; set; }
        public long totalHeal { get; set; }
        public long totalPlayerScore { get; set; }
        public long totalScoreRank { get; set; }
        public long totalTimeCrowdControlDealt { get; set; }
        public long totalUnitsHealed { get; set; }
        public long towerKills { get; set; }
        public long tripleKills { get; set; }
        public long trueDamageDealt { get; set; }
        public long trueDamageDealtToChampions { get; set; }
        public long trueDamageTaken { get; set; }
        public long unrealKills { get; set; }
        public long visionWardsBoughtInGame { get; set; }
        public long wardsKilled { get; set; }
        public long wardsPlaced { get; set; }
        public bool winner { get; set; }
    }
    public class ParticipantTimeline
    {
        public ParticipantTimelineData ancientGolemAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData ancientGolemKillsPerMinCounts { get; set; }
        public ParticipantTimelineData assistedLaneDeathsPerMinDeltas { get; set; }
        public ParticipantTimelineData assistedLaneKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData baronAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData baronKillsPerMinCounts { get; set; }
        public ParticipantTimelineData creepsPerMinDeltas { get; set; }
        public ParticipantTimelineData csDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData damageTakenDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData damageTakenPerMinDeltas { get; set; }
        public ParticipantTimelineData dragonAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData dragonKillsPerMinCounts { get; set; }
        public ParticipantTimelineData elderLizardAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData elderLizardKillsPerMinCounts { get; set; }
        public ParticipantTimelineData goldPerMinDeltas { get; set; }
        public ParticipantTimelineData inhibitorAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData inhibitorKillsPerMinCounts { get; set; }
        public string lane { get; set; }
        public string role { get; set; }
        public ParticipantTimelineData towerAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData towerKillsPerMinCounts { get; set; }
        public ParticipantTimelineData towerKillsPerMinDeltas { get; set; }
        public ParticipantTimelineData vilemawAssistsPerMinCounts { get; set; }
        public ParticipantTimelineData vilemawKillsPerMinCounts { get; set; }
        public ParticipantTimelineData wardsPerMinDeltas { get; set; }
        public ParticipantTimelineData xpDiffPerMinDeltas { get; set; }
        public ParticipantTimelineData xpPerMinDeltas { get; set; }
    }
    public class Player
    {
        public string matchHistoryUri { get; set; }
        public int profileIcon { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }
    }
    public class Frame
    {
        public List<Event> events { get; set; }
        public Dictionary<string, ParticipantFrame> participantFrames { get; set; }
        public long timestamp { get; set; }
    }
    public class ParticipantTimelineData
    {
        public double tenToTwenty { get; set; }
        public double thirtyToEnd { get; set; }
        public double twentyToThirty { get; set; }
        public double zeroToTen { get; set; }
    }
    public class Event
    {
        public string ascendedType { get; set; }
        public List<int> assistingParticipantIds { get; set; }
        public string buildingType { get; set; }
        public int creatorId { get; set; }
        public string eventType { get; set; }
        public int itemAfter { get; set; }
        public int itemBefore { get; set; }
        public int itemId { get; set; }
        public int killerId { get; set; }
        public string laneType { get; set; }
        public string levelUpType { get; set; }
        public string monsterType { get; set; }
        public int participantId { get; set; }
        public string pointCaptured { get; set; }
        public Position position { get; set; }
        public int skillSlot { get; set; }
        public int teamId { get; set; }
        public long timestamp { get; set; }
        public string towerType { get; set; }
        public int victimId { get; set; }
        public string wardType { get; set; }
    }
    public class ParticipantFrame
    {
        public int currentGold { get; set; }
        public int dominionScore { get; set; }
        public int jungleMinionsKilled { get; set; }
        public int level { get; set; }
        public int minionsKilled { get; set; }
        public int participantId { get; set; }
        public Position position { get; set; }
        public int teamScore { get; set; }
        public int totalGold { get; set; }
        public int xp { get; set; }
    }
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    #endregion

    // MatchList v2.2
    #region MatchList v2.2
    public class MatchList
    {
        public int endIndex { get; set; }
        public List<MatchReference> matches { get; set; }
        public int startIndex { get; set; }
        public int totalGames { get; set; }
    }
    public class MatchReference
    {
        public long champion { get; set; }
        public string lane { get; set; }
        public long matchId { get; set; }
        public string platformId { get; set; }
        public string queue { get; set; }
        public string region { get; set; }
        public string role { get; set; }
        public string season { get; set; }
        public long timestamp { get; set; }
    }
    #endregion

    // stats v1.3
    #region stats v1.3
    #region Ranked stats by summoner ID
    public class RankedStatsDto
    {
        public List<ChampionStatsDto> champions { get; set; }
        public long modifyDate { get; set; }
        public long summonerId { get; set; }
    }
    public class ChampionStatsDto
    {
        public int id { get; set; }
        public AggregatedStatsDto stats { get; set; }
    }
    public class AggregatedStatsDto
    {
        public int averageAssists { get; set; }
        public int averageChampionsKilled { get; set; }
        public int averageCombatPlayerScore { get; set; }
        public int averageNodeCapture { get; set; }
        public int averageNodeCaptureAssist { get; set; }
        public int averageNodeNeutralize { get; set; }
        public int averageNodeNeutralizeAssist { get; set; }
        public int averageNumDeaths { get; set; }
        public int averageObjectivePlayerScore { get; set; }
        public int averageTeamObjective { get; set; }
        public int averageTotalPlayerScore { get; set; }
        public int botGamesPlayed { get; set; }
        public int killingSpree { get; set; }
        public int maxAssists { get; set; }
        public int maxChampionsKilled { get; set; }
        public int maxCombatPlayerScore { get; set; }
        public int maxLargestCriticalStrike { get; set; }
        public int maxLargestKillingSpree { get; set; }
        public int maxNodeCapture { get; set; }
        public int maxNodeCaptureAssist { get; set; }
        public int maxNodeNeutralize { get; set; }
        public int maxNodeNeutralizeAssist { get; set; }
        public int maxNumDeaths { get; set; }
        public int maxObjectivePlayerScore { get; set; }
        public int maxTeamObjective { get; set; }
        public int maxTimePlayed { get; set; }
        public int maxTimeSpentLiving { get; set; }
        public int maxTotalPlayerScore { get; set; }
        public int mostChampionKillsPerSession { get; set; }
        public int mostSpellsCast { get; set; }
        public int normalGamesPlayed { get; set; }
        public int rankedPremadeGamesPlayed { get; set; }
        public int rankedSoloGamesPlayed { get; set; }
        public int totalAssists { get; set; }
        public int totalChampionKills { get; set; }
        public int totalDamageDealt { get; set; }
        public int totalDamageTaken { get; set; }
        public int totalDeathsPerSession { get; set; }
        public int totalDoubleKills { get; set; }
        public int totalFirstBlood { get; set; }
        public int totalGoldEarned { get; set; }
        public int totalHeal { get; set; }
        public int totalMagicDamageDealt { get; set; }
        public int totalMinionKills { get; set; }
        public int totalNeutralMinionsKilled { get; set; }
        public int totalNodeCapture { get; set; }
        public int totalNodeNeutralize { get; set; }
        public int totalPentaKills { get; set; }
        public int totalPhysicalDamageDealt { get; set; }
        public int totalQuadraKills { get; set; }
        public int totalSessionsLost { get; set; }
        public int totalSessionsPlayed { get; set; }
        public int totalSessionsWon { get; set; }
        public int totalTripleKills { get; set; }
        public int totalTurretsKilled { get; set; }
        public int totalUnrealKills { get; set; }
    }
    #endregion
    #region Player stats summaries by ID
    public class PlayerStatsSummaryListDto
    {
        public List<PlayerStatsSummaryDto> playerStatSummaries { get; set; }
        public long summonerId { get; set; }
    }
    public class PlayerStatsSummaryDto
    {
        public AggregatedStatsDto aggregatedStats { get; set; }
        public int losses { get; set; }
        public long modifyDate { get; set; }
        public string playerStatSummaryType { get; set; }
        public int wins { get; set; }
    }
    #endregion
    #endregion

    // Summoner v1.4
    #region Summoner v1.4
    #region Summoner info by name
    public class SummonerDto
    {
        public long id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public long summonerLevel { get; set; }
    }
    #endregion
    #region Summoner mastery pages
    public class MasteryPagesDto
    {
        public HashSet<MasteryPageDto> pages { get; set; }
        public long summonerId { get; set; }
    }
    public class MasteryPageDto
    {
        public bool current { get; set; }
        public long id { get; set; }
        public List<MasteryDto> masteries { get; set; }
        public string name { get; set; }
    }
    public class MasteryDto
    {
        public int id { get; set; }
        public int rank { get; set; }
    }
    #endregion
    #region Rune pages by summoner id
    public class RunePagesDto
    {
        public HashSet<RunePageDto> pages { get; set; }
        public long summonerId { get; set; }
    }
    public class RunePageDto
    {
        public bool current { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public HashSet<RuneSlotDto> slots { get; set; }
    }
    public class RuneSlotDto
    {
        public int runeId { get; set; }
        public int runeSlotId { get; set; }
    }
    #endregion
    #endregion
}
