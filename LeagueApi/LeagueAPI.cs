using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace LeagueApi
{
    #region Objects
    // ToDo: Add leaguev2.5

    // Shared
    #region Shared
    public class Observer
    {
        public string encryptionKey { get; set; }
        public bool Equals(Observer other)
        {
            if (this.encryptionKey == other.encryptionKey)
                return true;
            return false;
        }
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
    public class BasicDataStatsDto
    {
        public double FlatArmorMod { get; set; }
        public double FlatAttackSpeedMod { get; set; }
        public double FlatBlockMod { get; set; }
        public double FlatCritChanceMod { get; set; }
        public double FlatCritDamageMod { get; set; }
        public double FlatEXPBonus { get; set; }
        public double FlatEnergyPoolMod { get; set; }
        public double FlatEnergyRegenMod { get; set; }
        public double FlatHPPoolMod { get; set; }
        public double FlatHPRegenMod { get; set; }
        public double FlatMPPoolMod { get; set; }
        public double FlatMPRegenMod { get; set; }
        public double FlatMagicDamageMod { get; set; }
        public double FlatMovementSpeedMod { get; set; }
        public double FlatPhysicalDamageMod { get; set; }
        public double FlatSpellBlockMod { get; set; }
        public double PercentArmorMod { get; set; }
        public double PercentAttackSpeedMod { get; set; }
        public double PercentBlockMod { get; set; }
        public double PercentCritChanceMod { get; set; }
        public double PercentCritDamageMod { get; set; }
        public double PercentDodgeMod { get; set; }
        public double PercentEXPBonus { get; set; }
        public double PercentHPPoolMod { get; set; }
        public double PercentHPRegenMod { get; set; }
        public double PercentLifeStealMod { get; set; }
        public double PercentMPPoolMod { get; set; }
        public double PercentMPRegenMod { get; set; }
        public double PercentMagicDamageMod { get; set; }
        public double PercentMovementSpeedMod { get; set; }
        public double PercentPhysicalDamageMod { get; set; }
        public double PercentSpellBlockMod { get; set; }
        public double PercentSpellVampMod { get; set; }
        public double rFlatArmorModPerLevel { get; set; }
        public double rFlatArmorPenetrationMod { get; set; }
        public double rFlatArmorPenetrationModPerLevel { get; set; }
        public double rFlatCritChanceModPerLevel { get; set; }
        public double rFlatCritDamageModPerLevel { get; set; }
        public double rFlatDodgeMod { get; set; }
        public double rFlatDodgeModPerLevel { get; set; }
        public double rFlatEnergyModPerLevel { get; set; }
        public double rFlatEnergyRegenModPerLevel { get; set; }
        public double rFlatGoldPer10Mod { get; set; }
        public double rFlatHPModPerLevel { get; set; }
        public double rFlatHPRegenModPerLevel { get; set; }
        public double rFlatMPModPerLevel { get; set; }
        public double rFlatMPRegenModPerLevel { get; set; }
        public double rFlatMagicDamageModPerLevel { get; set; }
        public double rFlatMagicPenetrationMod { get; set; }
        public double rFlatMagicPenetrationModPerLevel { get; set; }
        public double rFlatMovementSpeedModPerLevel { get; set; }
        public double rFlatPhysicalDamageModPerLevel { get; set; }
        public double rFlatSpellBlockModPerLevel { get; set; }
        public double rFlatTimeDeadMod { get; set; }
        public double rFlatTimeDeadModPerLevel { get; set; }
        public double rPercentArmorPenetrationMod { get; set; }
        public double rPercentArmorPenetrationModPerLevel { get; set; }
        public double rPercentAttackSpeedModPerLevel { get; set; }
        public double rPercentCooldownMod { get; set; }
        public double rPercentCooldownModPerLevel { get; set; }
        public double rPercentMagicPenetrationMod { get; set; }
        public double rPercentMagicPenetrationModPerLevel { get; set; }
        public double rPercentMovementSpeedModPerLevel { get; set; }
        public double rPercentTimeDeadMod { get; set; }
        public double rPercentTimeDeadModPerLevel { get; set; }
    }
    public class GoldDto
    {
        public int test { get; set; } // Originally named base.  Can't use it?
        public bool purchasable { get; set; }
        public int sell { get; set; }
        public int total { get; set; }
    }
    public class MetaDataDto
    {
        public bool isRune { get; set; }
        public string tier { get; set; }
        public string type { get; set; }
    }
    public class SpellVarsDto
    {
        public List<double> coeff { get; set; }
        public string dyn { get; set; }
        public string key { get; set; }
        public string link { get; set; }
        public string ranksWith { get; set; }
    }
    public class ImageDto
    {
        public string full { get; set; }
        public string group { get; set; }
        public int h { get; set; }
        public string sprite { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
    #endregion

    // Champion v1.2
    #region Championv1.2
    // Champion
    public class ChampionListDto
    {
        public List<ChampionDto> champions { get; set; }

        public Dictionary<string, ChampionDto> data { get; set; }
        public string format { get; set; }
        public Dictionary<string, string> keys { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
    public class ChampionDto
    {
        public bool active { get; set; }
        public bool botEnabled { get; set; }
        public bool botMmEnabled { get; set; }
        public bool freeToPlay { get; set; }
        public long id { get; set; }
        public bool rankedPlayEnabled { get; set; }

        public List<string> allytips { get; set; }
        public string blurb { get; set; }
        public List<string> enemytips { get; set; }
        public ImageDto image { get; set; }
        public InfoDto info { get; set; }
        public string key { get; set; }
        public string lore { get; set; }
        public string name { get; set; }
        public string partype { get; set; }
        public PassiveDto passive { get; set; }
        public List<RecommendedDto> recommended { get; set; }
        public List<SkinDto> skins { get; set; }
        public List<ChampionSpellDto> spells { get; set; }
        public StatsDto stats { get; set; }
        public List<string> tags { get; set; }
        public string title { get; set; }
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

    // Static data v1.2
    #region Static
    #region Champion
    // ChampionListDto in Championv1.2
    // ChampionDto in Championv1.2
    public class ChampionSpellDto
    {
        public List<ImageDto> altimages { get; set; }
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<object> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public ImageDto image { get; set; }
        public string key { get; set; }
        public LevelTipDto leveltip { get; set; }
        public int maxrank { get; set; }
        public string name { get; set; }
        public object range { get; set; }
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public string tooltip { get; set; }
        public List<SpellVarsDto> vars { get; set; }
    }
    public class InfoDto
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int difficulty { get; set; }
        public int magic { get; set; }
    }
    public class PassiveDto
    {
        public string description { get; set; }
        public ImageDto image { get; set; }
        public string name { get; set; }
        public string sanitizedDescription { get; set; }
    }
    public class RecommendedDto
    {
        public List<BlockDto> blocks { get; set; }
        public string champion { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public bool priority { get; set; }
        public string title { get; set; }
        public string type { get; set; }
    }
    public class SkinDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int num { get; set; }
    }
    public class StatsDto
    {
        public double armor { get; set; }
        public double armorperlevel { get; set; }
        public double attackdamage { get; set; }
        public double attackdamageperlevel { get; set; }
        public double attackrange { get; set; }
        public double attackspeedoffset { get; set; }
        public double attackspeedperlevel { get; set; }
        public double crit { get; set; }
        public double critperlevel { get; set; }
        public double hp { get; set; }
        public double hpperlevel { get; set; }
        public double hpregen { get; set; }
        public double hpregenperlevel { get; set; }
        public double movespeed { get; set; }
        public double mp { get; set; }
        public double mpperlevel { get; set; }
        public double mpregen { get; set; }
        public double mpregenperlevel { get; set; }
        public double spellblock { get; set; }
        public double spellblockperlevel { get; set; }
    }
    public class BlockDto
    {
        public List<BlockItemDto> items { get; set; }
        public bool recMath { get; set; }
        public string type { get; set; }
    }
    public class BlockItemDto
    {
        public int count { get; set; }
        public int id { get; set; }
    }
    #endregion
    #region Items
    public class ItemListDto
    {
        public BasicDataDto basic { get; set; }
        public Dictionary<string, ItemDto> data { get; set; }
        public List<GroupDto> groups { get; set; }
        public List<ItemTreeDto> tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
    public class BasicDataDto
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public GoldDto gold { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaDataDto rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }
    public class GroupDto
    {
        public string MaxGroupOwnable { get; set; }
        public string key { get; set; }
    }
    public class ItemDto
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public Dictionary<string, string> effect { get; set; }
        public List<string> from { get; set; }
        public GoldDto gold { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaDataDto rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }
    public class ItemTreeDto
    {
        public string header { get; set; }
        public List<string> tags { get; set; }
    }
    #endregion
    #region Masteries
    public class MasteryListDto
    {
        public Dictionary<string, MasteryDto> data { get; set; }
        public MasteryTreeDto tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
    public class MasteryDto
    {
        public List<string> description { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public string masteryTree { get; set; }
        public string name { get; set; }
        public string prereq { get; set; }
        public int rank { get; set; }
        public int ranks { get; set; }
        public List<string> sanitizedDescription { get; set; }
    }
    public class MasteryTreeDto
    {
        public List<MasteryTreeListDto> Cunning { get; set; }
        public List<MasteryTreeListDto> Ferocity { get; set; }
        public List<MasteryTreeListDto> Resolve { get; set; }
    }
    // ImageDto in static champion
    public class MasteryTreeListDto
    {
        public List<MasteryTreeItemDto> masteryTreeItems { get; set; }
    }
    public class MasteryTreeItemDto
    {
        public int masteryId { get; set; }
        public string prereq { get; set; }
    }
    #endregion
    #region Runes
    public class RuneListDto
    {
        public BasicDataDto basic { get; set; }
        public Dictionary<string, RuneDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
    public class RuneDto
    {
        public string colloq { get; set; }
        public bool consumeOnFull { get; set; }
        public bool consumed { get; set; }
        public int depth { get; set; }
        public string description { get; set; }
        public List<string> from { get; set; }
        public string group { get; set; }
        public bool hideFromAll { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public bool inStore { get; set; }
        public List<string> into { get; set; }
        public Dictionary<string, bool> maps { get; set; }
        public string name { get; set; }
        public string plaintext { get; set; }
        public string requiredChampion { get; set; }
        public MetaDataDto rune { get; set; }
        public string sanitizedDescription { get; set; }
        public int specialRecipe { get; set; }
        public int stacks { get; set; }
        public BasicDataStatsDto stats { get; set; }
        public List<string> tags { get; set; }
    }
    #endregion
    #region SummonerSpell
    public class SummonerSpellListDto
    {
        public Dictionary<string, SummonerSpellDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }
    }
    public class SummonerSpellDto
    {
        public List<double> cooldown { get; set; }
        public string cooldownBurn { get; set; }
        public List<int> cost { get; set; }
        public string costBurn { get; set; }
        public string costType { get; set; }
        public string description { get; set; }
        public List<object> effect { get; set; }
        public List<string> effectBurn { get; set; }
        public int id { get; set; }
        public ImageDto image { get; set; }
        public string key { get; set; }
        public LevelTipDto leveltip { get; set; }
        public int maxrank { get; set; }
        public List<string> modes { get; set; }
        public string name { get; set; }
        public object range { get; set; }
        public string rangeBurn { get; set; }
        public string resource { get; set; }
        public string sanitizedDescription { get; set; }
        public string sanitizedTooltip { get; set; }
        public int summonerLevel { get; set; }
        public string tooltip { get; set; }
        public List<SpellVarsDto> vars { get; set; }
    }
    public class LevelTipDto
    {
        public List<string> effect { get; set; }
        public List<string> label { get; set; }
    }
    #endregion
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
    #endregion
    #region Functions
    public class LeagueApi
    {
        #region Varibles
        // Request match list
        private static string MATCH_LIST_REQUEST = "https://na.api.pvp.net/api/lol/na/v2.2/matchlist/by-summoner/?championIds=&seasons=PRESEASON2015,SEASON2015,PRESEASON2016,SEASON2016&api_key=";

        // Request match info
        private static string MATCH_REQUEST = "https://na.api.pvp.net/api/lol/na/v2.2/match/?api_key=";

        // Request champion list
        private static string CHAMP_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?api_key=";

        // Request masteries list
        private static string MASTERY_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/mastery?version=&api_key=";

        // SMN Name request URL
        private static string SMN_NAME_REQUEST = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/?api_key=";

        // League status request
        private static string LOLSTATUS_REQUEST = "http://status.leagueoflegends.com/shards/na";
        #endregion

        private static T Get_Json<T>(string url)
        {
            var webReq = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)webReq.GetResponse();
            }
            catch (Exception e)
            {
                throw e;
            }

            var sw = new StreamReader(response.GetResponseStream());
            var contents = sw.ReadToEnd();

            T jsonRet;
            try
            {
                jsonRet = JsonConvert.DeserializeObject<T>(contents);
            }
            catch (Exception e)
            {
                throw e;
            }

            return jsonRet;
        }

        // Retrieves masteries from a list of matches.
        // API: match-v2.2
        public static List<Mastery> Get_Mastery_From_Match_ID(long matchid, long smnid, string apikey)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = MATCH_REQUEST + apikey;
            url = url.Insert(url.IndexOf("match/") + 6, matchid.ToString());
            
            MatchDetail Json;
            try
            {
                Json = Get_Json<MatchDetail>(url);

                var identities = Json.participantIdentities;
                long identID = -1;

                foreach (ParticipantIdentity obj in identities)
                {
                    if (obj.player.summonerId == smnid)
                    {
                        identID = obj.participantId;
                    }
                }

                var participants = Json.participants;
                foreach (Participant obj in participants)
                {
                    if (obj.participantId == identID)
                    {
                        return obj.masteries;
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }

        // Retrieve status of the lol servers
        // API: lol-status-v1.0
        public static statusContainer Get_LoL_Status()
        {
            statusContainer retval = new statusContainer();
            ShardStatus json;
            try
            {
                json = Get_Json<ShardStatus>(LOLSTATUS_REQUEST);

                var services = json.services;

                foreach (Service obj in services)
                {
                    if (obj.name == "Client")
                        retval.client = obj.status;
                    else if (obj.name == "Game")
                        retval.game = (string)obj.status;
                    else if (obj.name == "Store")
                        retval.store = (string)obj.status;
                    else if (obj.name == "Website")
                        retval.website = (string)obj.status;
                }

                return retval;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Retrieves a list of matches based on sumoner ID and/or championid
        // API: matchlist-v2.2
        public static List<MatchReference> Get_Matches_From_Summoner_ID(long id, string apikey, string champid = "")
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = MATCH_LIST_REQUEST + apikey;
            url = url.Insert(url.IndexOf("by-summoner/") + 12, id.ToString());
            url = url.Insert(url.IndexOf("?championIds=") + 13, champid);

            MatchList Json;
            try
            {
                Json = Get_Json<MatchList>(url);

                return Json.matches;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Gets summoner details by name.  Returns -1 if error occurs
        // API: summoner-v1.4
        public static long Get_Summoner_ID_By_Name(string name, string apikey)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = SMN_NAME_REQUEST + apikey;
            url = url.Insert(url.IndexOf("by-name/") + 8, name.ToLower());

            Dictionary<string, SummonerDto> Json;
            try
            {
                Json = Get_Json<Dictionary<string, SummonerDto>>(url);
                return Json[name.ToLower()].id;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // API: lol-static-data-v1.2
        public static MasteryListDto Get_Masteries(string apikey, string version = "")
        {
            try
            {
                var url = MASTERY_REQUEST + apikey;
                url = url.Insert(url.IndexOf("?version=") + 9, version);
                return Get_Json<MasteryListDto>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // API: lol-static-data-v1.2
        public static ChampionListDto Get_Champions(string apikey, string version = "")
        {
            try
            {
                return Get_Json<ChampionListDto>(CHAMP_REQUEST + apikey);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    public class statusContainer : IEquatable<statusContainer>
    {
        public string client { get; set; }
        public string store { get; set; }
        public string game { get; set; }
        public string website { get; set; }

        public bool Equals(statusContainer other)
        {
            if (this.client == other.client &&
                this.store == other.store &&
                this.game == other.game &&
                this.website == other.website)
                return true;
            return false;
        }
    }
    #endregion
}
