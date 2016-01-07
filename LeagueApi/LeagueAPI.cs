using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

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
    public class Mastery : IEquatable<Mastery>
    {
        public long masteryId { get; set; }
        public int rank { get; set; }

        public bool Equals(Mastery other)
        {
            if (this.masteryId == other.masteryId &&
            this.rank == other.rank)
                return true;
            return false;
        }
    }
    public class Rune : IEquatable<Rune>
    {
        public int count { get; set; }
        public long runeId { get; set; }

        public bool Equals(Rune other)
        {
            if (this.count == other.count &&
            this.runeId == other.runeId)
                return true;
            return false;
        }
    }
    public class BannedChampion : IEquatable<BannedChampion>
    {
        public long championId { get; set; }
        public int pickTurn { get; set; }
        public long teamId { get; set; }

        public bool Equals(BannedChampion other)
        {
            if (this.championId == other.championId &&
            this.pickTurn == other.pickTurn &&
            this.teamId == other.teamId)
                return true;
            return false;
        }
    }
    public class BasicDataStatsDto : IEquatable<BasicDataStatsDto>
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

        public bool Equals(BasicDataStatsDto other)
        {
            if (this.FlatArmorMod == other.FlatArmorMod &&
            this.FlatAttackSpeedMod == other.FlatAttackSpeedMod &&
            this.FlatBlockMod == other.FlatBlockMod &&
            this.FlatCritChanceMod == other.FlatCritChanceMod &&
            this.FlatCritDamageMod == other.FlatCritDamageMod &&
            this.FlatEXPBonus == other.FlatEXPBonus &&
            this.FlatEnergyPoolMod == other.FlatEnergyPoolMod &&
            this.FlatEnergyRegenMod == other.FlatEnergyRegenMod &&
            this.FlatHPPoolMod == other.FlatHPPoolMod &&
            this.FlatHPRegenMod == other.FlatHPRegenMod &&
            this.FlatMPPoolMod == other.FlatMPPoolMod &&
            this.FlatMPRegenMod == other.FlatMPRegenMod &&
            this.FlatMagicDamageMod == other.FlatMagicDamageMod &&
            this.FlatMovementSpeedMod == other.FlatMovementSpeedMod &&
            this.FlatPhysicalDamageMod == other.FlatPhysicalDamageMod &&
            this.FlatSpellBlockMod == other.FlatSpellBlockMod &&
            this.PercentArmorMod == other.PercentArmorMod &&
            this.PercentAttackSpeedMod == other.PercentAttackSpeedMod &&
            this.PercentBlockMod == other.PercentBlockMod &&
            this.PercentCritChanceMod == other.PercentCritChanceMod &&
            this.PercentCritDamageMod == other.PercentCritDamageMod &&
            this.PercentDodgeMod == other.PercentDodgeMod &&
            this.PercentEXPBonus == other.PercentEXPBonus &&
            this.PercentHPPoolMod == other.PercentHPPoolMod &&
            this.PercentHPRegenMod == other.PercentHPRegenMod &&
            this.PercentLifeStealMod == other.PercentLifeStealMod &&
            this.PercentMPPoolMod == other.PercentMPPoolMod &&
            this.PercentMPRegenMod == other.PercentMPRegenMod &&
            this.PercentMagicDamageMod == other.PercentMagicDamageMod &&
            this.PercentMovementSpeedMod == other.PercentMovementSpeedMod &&
            this.PercentPhysicalDamageMod == other.PercentPhysicalDamageMod &&
            this.PercentSpellBlockMod == other.PercentSpellBlockMod &&
            this.PercentSpellVampMod == other.PercentSpellVampMod &&
            this.rFlatArmorModPerLevel == other.rFlatArmorModPerLevel &&
            this.rFlatArmorPenetrationMod == other.rFlatArmorPenetrationMod &&
            this.rFlatArmorPenetrationModPerLevel == other.rFlatArmorPenetrationModPerLevel &&
            this.rFlatCritChanceModPerLevel == other.rFlatCritChanceModPerLevel &&
            this.rFlatCritDamageModPerLevel == other.rFlatCritDamageModPerLevel &&
            this.rFlatDodgeMod == other.rFlatDodgeMod &&
            this.rFlatDodgeModPerLevel == other.rFlatDodgeModPerLevel &&
            this.rFlatEnergyModPerLevel == other.rFlatEnergyModPerLevel &&
            this.rFlatEnergyRegenModPerLevel == other.rFlatEnergyRegenModPerLevel &&
            this.rFlatGoldPer10Mod == other.rFlatGoldPer10Mod &&
            this.rFlatHPModPerLevel == other.rFlatHPModPerLevel &&
            this.rFlatHPRegenModPerLevel == other.rFlatHPRegenModPerLevel &&
            this.rFlatMPModPerLevel == other.rFlatMPModPerLevel &&
            this.rFlatMPRegenModPerLevel == other.rFlatMPRegenModPerLevel &&
            this.rFlatMagicDamageModPerLevel == other.rFlatMagicDamageModPerLevel &&
            this.rFlatMagicPenetrationMod == other.rFlatMagicPenetrationMod &&
            this.rFlatMagicPenetrationModPerLevel == other.rFlatMagicPenetrationModPerLevel &&
            this.rFlatMovementSpeedModPerLevel == other.rFlatMovementSpeedModPerLevel &&
            this.rFlatPhysicalDamageModPerLevel == other.rFlatPhysicalDamageModPerLevel &&
            this.rFlatSpellBlockModPerLevel == other.rFlatSpellBlockModPerLevel &&
            this.rFlatTimeDeadMod == other.rFlatTimeDeadMod &&
            this.rFlatTimeDeadModPerLevel == other.rFlatTimeDeadModPerLevel &&
            this.rPercentArmorPenetrationMod == other.rPercentArmorPenetrationMod &&
            this.rPercentArmorPenetrationModPerLevel == other.rPercentArmorPenetrationModPerLevel &&
            this.rPercentAttackSpeedModPerLevel == other.rPercentAttackSpeedModPerLevel &&
            this.rPercentCooldownMod == other.rPercentCooldownMod &&
            this.rPercentCooldownModPerLevel == other.rPercentCooldownModPerLevel &&
            this.rPercentMagicPenetrationMod == other.rPercentMagicPenetrationMod &&
            this.rPercentMagicPenetrationModPerLevel == other.rPercentMagicPenetrationModPerLevel &&
            this.rPercentMovementSpeedModPerLevel == other.rPercentMovementSpeedModPerLevel &&
            this.rPercentTimeDeadMod == other.rPercentTimeDeadMod &&
            this.rPercentTimeDeadModPerLevel == other.rPercentTimeDeadModPerLevel)
                return true;
            return false;
        }
    }
    public class GoldDto : IEquatable<GoldDto>
    {
        public int test { get; set; } // Originally named base.  Can't use it?
        public bool purchasable { get; set; }
        public int sell { get; set; }
        public int total { get; set; }

        public bool Equals(GoldDto other)
        {
            if (this.test == other.test &&
            this.purchasable == other.purchasable &&
            this.sell == other.sell &&
            this.total == other.total)
                return true;
            return false;
        }
    }
    public class MetaDataDto : IEquatable<MetaDataDto>
    {
        public bool isRune { get; set; }
        public string tier { get; set; }
        public string type { get; set; }

        public bool Equals(MetaDataDto other)
        {
            if (this.isRune == other.isRune &&
            this.tier == other.tier &&
            this.type == other.type)
                return true;
            return false;
        }
    }
    public class SpellVarsDto : IEquatable<SpellVarsDto>
    {
        public List<double> coeff { get; set; }
        public string dyn { get; set; }
        public string key { get; set; }
        public string link { get; set; }
        public string ranksWith { get; set; }

        public bool Equals(SpellVarsDto other)
        {
            if (this.coeff.SequenceEqual(other.coeff) &&
            this.dyn == other.dyn &&
            this.key == other.key &&
            this.link == other.link &&
            this.ranksWith == other.ranksWith)
                return true;
            return false;
        }
    }
    public class ImageDto : IEquatable<ImageDto>
    {
        public string full { get; set; }
        public string group { get; set; }
        public int h { get; set; }
        public string sprite { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public bool Equals(ImageDto other)
        {
            if (this.full == other.full &&
            this.group == other.group &&
            this.h == other.h &&
            this.sprite == other.sprite &&
            this.w == other.w &&
            this.x == other.x &&
            this.y == other.y)
                return true;
            return false;
        }
    }
    #endregion

    // Champion v1.2
    #region Championv1.2
    // Champion
    public class ChampionListDto : IEquatable<ChampionListDto>
    {
        public List<ChampionDto> champions { get; set; }

        public Dictionary<string, ChampionDto> data { get; set; }
        public string format { get; set; }
        public Dictionary<string, string> keys { get; set; }
        public string type { get; set; }
        public string version { get; set; }

        public bool Equals(ChampionListDto other)
        {
            if (this.champions.SequenceEqual(other.champions) &&
            this.data.SequenceEqual(other.data) &&
            this.format == other.format &&
            this.keys.SequenceEqual(other.keys) &&
            this.type == other.type &&
            this.version == other.version)
                return true;
            return false;
        }
    }
    public class ChampionDto : IEquatable<ChampionDto>
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

        public bool Equals(ChampionDto other)
        {
            if (this.active == other.active &&
            this.botEnabled == other.botEnabled &&
            this.botMmEnabled == other.botMmEnabled &&
            this.freeToPlay == other.freeToPlay &&
            this.id == other.id &&
            this.rankedPlayEnabled == other.rankedPlayEnabled &&
            this.allytips.SequenceEqual(other.allytips) &&
            this.blurb == other.blurb &&
            this.enemytips.SequenceEqual(other.enemytips) &&
            this.image == other.image &&
            this.info == other.info &&
            this.key == other.key &&
            this.lore == other.lore &&
            this.name == other.name &&
            this.partype == other.partype &&
            this.passive == other.passive &&
            this.recommended.SequenceEqual(other.recommended) &&
            this.skins.SequenceEqual(other.skins) &&
            this.spells.SequenceEqual(other.spells) &&
            this.stats == other.stats &&
            this.tags.SequenceEqual(other.tags) &&
            this.title == other.title)
                return true;
            return false;
        }
    }
    #endregion

    // Current-game v1.0
    #region Current game v1.0
    public class CurrentGameInfo : IEquatable<CurrentGameInfo>
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

        public bool Equals(CurrentGameInfo other)
        {
            if (this.bannedChampions.SequenceEqual(other.bannedChampions) &&
            this.gameId == other.gameId &&
            this.gameLength == other.gameLength &&
            this.gameMode == other.gameMode &&
            this.gameQueueConfigId == other.gameQueueConfigId &&
            this.gameStartTime == other.gameStartTime &&
            this.gameType == other.gameType &&
            this.mapId == other.mapId &&
            this.observers == other.observers &&
            this.participants.SequenceEqual(other.participants) &&
            this.platformId == other.platformId)
                return true;
            return false;
        }
    }

    public class CurrentGameParticipant : IEquatable<CurrentGameParticipant>
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

        public bool Equals(CurrentGameParticipant other)
        {
            if (this.bot == other.bot &&
            this.championId == other.championId &&
            this.masteries.SequenceEqual(other.masteries) &&
            this.profileIconId == other.profileIconId &&
            this.runes.SequenceEqual(other.runes) &&
            this.spell1Id == other.spell1Id &&
            this.spell2Id == other.spell2Id &&
            this.summonerId == other.summonerId &&
            this.summonerName == other.summonerName &&
            this.teamId == other.teamId)
                return true;
            return false;
        }
    }
    #endregion

    // Featured Games v1.0
    #region Featured games v1.0
    public class FeaturedGames : IEquatable<FeaturedGames>
    {
        public long clientRefreshInterval { get; set; }
        public List<FeaturedGameInfo> gameList { get; set; }

        public bool Equals(FeaturedGames other)
        {
            if (this.clientRefreshInterval == other.clientRefreshInterval &&
            this.gameList.SequenceEqual(other.gameList))
                return true;
            return false;
        }
    }
    public class FeaturedGameInfo : IEquatable<FeaturedGameInfo>
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

        public bool Equals(FeaturedGameInfo other)
        {
            if (this.bannedChampions.SequenceEqual(other.bannedChampions) &&
            this.gameId == other.gameId &&
            this.gameLength == other.gameLength &&
            this.gameMode == other.gameMode &&
            this.gameQueueConfigId == other.gameQueueConfigId &&
            this.gameStartTime == other.gameStartTime &&
            this.gameType == other.gameType &&
            this.mapId == other.mapId &&
            this.observers == other.observers &&
            this.participants.SequenceEqual(other.participants) &&
            this.platformId == other.platformId)
                return true;
            return false;
        }
    }

    #endregion

    // Game v1.3
    #region Game v1.3
    public class RecentGamesDto : IEquatable<RecentGamesDto>
    {
        public HashSet<GameDto> games { get; set; }
        public long summonerId { get; set; }

        public bool Equals(RecentGamesDto other)
        {
            if (this.games.SetEquals(other.games) &&
            this.summonerId == other.summonerId)
                return true;
            return false;
        }
    }
    public class GameDto : IEquatable<GameDto>
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

        public bool Equals(GameDto other)
        {
            if (this.championId == other.championId &&
            this.createDate == other.createDate &&
            this.fellowPlayers.SequenceEqual(other.fellowPlayers) &&
            this.gameId == other.gameId &&
            this.gameMode == other.gameMode &&
            this.gameType == other.gameType &&
            this.invalid == other.invalid &&
            this.ipEarned == other.ipEarned &&
            this.level == other.level &&
            this.mapId == other.mapId &&
            this.spell1 == other.spell1 &&
            this.spell2 == other.spell2 &&
            this.stats == other.stats &&
            this.subType == other.subType &&
            this.teamId == other.teamId)
                return true;
            return false;
        }
    }
    public class PlayerDto : IEquatable<PlayerDto>
    {
        public int championId { get; set; }
        public long summonerId { get; set; }
        public int teamId { get; set; }

        public bool Equals(PlayerDto other)
        {
            if (this.championId == other.championId &&
            this.summonerId == other.summonerId &&
            this.teamId == other.teamId)
                return true;
            return false;
        }
    }
    public class RawStatsDto : IEquatable<RawStatsDto>
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

        public bool Equals(RawStatsDto other)
        {
            if (this.assists == other.assists &&
            this.barracksKilled == other.barracksKilled &&
            this.championsKilled == other.championsKilled &&
            this.combatPlayerScore == other.combatPlayerScore &&
            this.consumablesPurchased == other.consumablesPurchased &&
            this.damageDealtPlayer == other.damageDealtPlayer &&
            this.doubleKills == other.doubleKills &&
            this.firstBlood == other.firstBlood &&
            this.gold == other.gold &&
            this.goldEarned == other.goldEarned &&
            this.goldSpent == other.goldSpent &&
            this.item0 == other.item0 &&
            this.item1 == other.item1 &&
            this.item2 == other.item2 &&
            this.item3 == other.item3 &&
            this.item4 == other.item4 &&
            this.item5 == other.item5 &&
            this.item6 == other.item6 &&
            this.itemsPurchased == other.itemsPurchased &&
            this.killingSprees == other.killingSprees &&
            this.largestCriticalStrike == other.largestCriticalStrike &&
            this.largestKillingSpree == other.largestKillingSpree &&
            this.largestMultiKill == other.largestMultiKill &&
            this.legendaryItemsCreated == other.legendaryItemsCreated &&
            this.level == other.level &&
            this.magicDamageDealtPlayer == other.magicDamageDealtPlayer &&
            this.magicDamageDealtToChampions == other.magicDamageDealtToChampions &&
            this.magicDamageTaken == other.magicDamageTaken &&
            this.minionsDenied == other.minionsDenied &&
            this.minionsKilled == other.minionsKilled &&
            this.neutralMinionsKilled == other.neutralMinionsKilled &&
            this.neutralMinionsKilledEnemyJungle == other.neutralMinionsKilledEnemyJungle &&
            this.neutralMinionsKilledYourJungle == other.neutralMinionsKilledYourJungle &&
            this.nexusKilled == other.nexusKilled &&
            this.nodeCapture == other.nodeCapture &&
            this.nodeCaptureAssist == other.nodeCaptureAssist &&
            this.nodeNeutralize == other.nodeNeutralize &&
            this.nodeNeutralizeAssist == other.nodeNeutralizeAssist &&
            this.numDeaths == other.numDeaths &&
            this.numItemsBought == other.numItemsBought &&
            this.objectivePlayerScore == other.objectivePlayerScore &&
            this.pentaKills == other.pentaKills &&
            this.physicalDamageDealtPlayer == other.physicalDamageDealtPlayer &&
            this.physicalDamageDealtToChampions == other.physicalDamageDealtToChampions &&
            this.physicalDamageTaken == other.physicalDamageTaken &&
            this.playerPosition == other.playerPosition &&
            this.playerRole == other.playerRole &&
            this.quadraKills == other.quadraKills &&
            this.sightWardsBought == other.sightWardsBought &&
            this.spell1Cast == other.spell1Cast &&
            this.spell2Cast == other.spell2Cast &&
            this.spell3Cast == other.spell3Cast &&
            this.spell4Cast == other.spell4Cast &&
            this.summonSpell1Cast == other.summonSpell1Cast &&
            this.summonSpell2Cast == other.summonSpell2Cast &&
            this.superMonsterKilled == other.superMonsterKilled &&
            this.team == other.team &&
            this.teamObjective == other.teamObjective &&
            this.timePlayed == other.timePlayed &&
            this.totalDamageDealt == other.totalDamageDealt &&
            this.totalDamageDealtToChampions == other.totalDamageDealtToChampions &&
            this.totalDamageTaken == other.totalDamageTaken &&
            this.totalHeal == other.totalHeal &&
            this.totalPlayerScore == other.totalPlayerScore &&
            this.totalScoreRank == other.totalScoreRank &&
            this.totalTimeCrowdControlDealt == other.totalTimeCrowdControlDealt &&
            this.totalUnitsHealed == other.totalUnitsHealed &&
            this.tripleKills == other.tripleKills &&
            this.trueDamageDealtPlayer == other.trueDamageDealtPlayer &&
            this.trueDamageDealtToChampions == other.trueDamageDealtToChampions &&
            this.trueDamageTaken == other.trueDamageTaken &&
            this.turretsKilled == other.turretsKilled &&
            this.unrealKills == other.unrealKills &&
            this.victoryPoTotal == other.victoryPoTotal &&
            this.visionWardsBought == other.visionWardsBought &&
            this.wardKilled == other.wardKilled &&
            this.wardPlaced == other.wardPlaced &&
            this.win == other.win)
                return true;
            return false;
        }
    }
    #endregion

    // Static data v1.2
    #region Static
    #region Champion
    // ChampionListDto in Championv1.2
    // ChampionDto in Championv1.2
    public class ChampionSpellDto : IEquatable<ChampionSpellDto>
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

        public bool Equals(ChampionSpellDto other)
        {
            if (this.altimages.SequenceEqual(other.altimages) &&
            this.cooldown.SequenceEqual(other.cooldown) &&
            this.cooldownBurn == other.cooldownBurn &&
            this.cost.SequenceEqual(other.cost) &&
            this.costBurn == other.costBurn &&
            this.costType == other.costType &&
            this.description == other.description &&
            this.effect.SequenceEqual(other.effect) &&
            this.effectBurn.SequenceEqual(other.effectBurn) &&
            this.image == other.image &&
            this.key == other.key &&
            this.leveltip == other.leveltip &&
            this.maxrank == other.maxrank &&
            this.name == other.name &&
            this.range == other.range &&
            this.rangeBurn == other.rangeBurn &&
            this.resource == other.resource &&
            this.sanitizedDescription == other.sanitizedDescription &&
            this.sanitizedTooltip == other.sanitizedTooltip &&
            this.tooltip == other.tooltip &&
            this.vars.SequenceEqual(other.vars))
                return true;
            return false;
        }
    }
    public class InfoDto : IEquatable<InfoDto>
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int difficulty { get; set; }
        public int magic { get; set; }

        public bool Equals(InfoDto other)
        {
            if (this.attack == other.attack &&
            this.defense == other.defense &&
            this.difficulty == other.difficulty &&
            this.magic == other.magic)
                return true;
            return false;
        }
    }
    public class PassiveDto : IEquatable<PassiveDto>
    {
        public string description { get; set; }
        public ImageDto image { get; set; }
        public string name { get; set; }
        public string sanitizedDescription { get; set; }

        public bool Equals(PassiveDto other)
        {
            if (this.description == other.description &&
            this.image == other.image &&
            this.name == other.name &&
            this.sanitizedDescription == other.sanitizedDescription)
                return true;
            return false;
        }
    }
    public class RecommendedDto : IEquatable<RecommendedDto>
    {
        public List<BlockDto> blocks { get; set; }
        public string champion { get; set; }
        public string map { get; set; }
        public string mode { get; set; }
        public bool priority { get; set; }
        public string title { get; set; }
        public string type { get; set; }

        public bool Equals(RecommendedDto other)
        {
            if (this.blocks.SequenceEqual(other.blocks) &&
            this.champion == other.champion &&
            this.map == other.map &&
            this.mode == other.mode &&
            this.priority == other.priority &&
            this.title == other.title &&
            this.type == other.type)
                return true;
            return false;
        }
    }
    public class SkinDto : IEquatable<SkinDto>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int num { get; set; }

        public bool Equals(SkinDto other)
        {
            if (this.id == other.id &&
            this.name == other.name &&
            this.num == other.num)
                return true;
            return false;
        }
    }
    public class StatsDto : IEquatable<StatsDto>
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

        public bool Equals(StatsDto other)
        {
            if (this.armor == other.armor &&
            this.armorperlevel == other.armorperlevel &&
            this.attackdamage == other.attackdamage &&
            this.attackdamageperlevel == other.attackdamageperlevel &&
            this.attackrange == other.attackrange &&
            this.attackspeedoffset == other.attackspeedoffset &&
            this.attackspeedperlevel == other.attackspeedperlevel &&
            this.crit == other.crit &&
            this.critperlevel == other.critperlevel &&
            this.hp == other.hp &&
            this.hpperlevel == other.hpperlevel &&
            this.hpregen == other.hpregen &&
            this.hpregenperlevel == other.hpregenperlevel &&
            this.movespeed == other.movespeed &&
            this.mp == other.mp &&
            this.mpperlevel == other.mpperlevel &&
            this.mpregen == other.mpregen &&
            this.mpregenperlevel == other.mpregenperlevel &&
            this.spellblock == other.spellblock &&
            this.spellblockperlevel == other.spellblockperlevel)
                return true;
            return false;
        }
    }
    public class BlockDto : IEquatable<BlockDto>
    {
        public List<BlockItemDto> items { get; set; }
        public bool recMath { get; set; }
        public string type { get; set; }

        public bool Equals(BlockDto other)
        {
            if (this.items.SequenceEqual(other.items) &&
            this.recMath == other.recMath &&
            this.type == other.type)
                return true;
            return false;
        }
    }
    public class BlockItemDto : IEquatable<BlockItemDto>
    {
        public int count { get; set; }
        public int id { get; set; }

        public bool Equals(BlockItemDto other)
        {
            if (this.count == other.count &&
            this.id == other.id)
                return true;
            return false;
        }
    }
    #endregion
    #region Items
    public class ItemListDto : IEquatable<ItemListDto>
    {
        public BasicDataDto basic { get; set; }
        public Dictionary<string, ItemDto> data { get; set; }
        public List<GroupDto> groups { get; set; }
        public List<ItemTreeDto> tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }

        public bool Equals(ItemListDto other)
        {
            if (this.basic == other.basic &&
            this.data.SequenceEqual(other.data) &&
            this.groups.SequenceEqual(other.groups) &&
            this.tree.SequenceEqual(other.tree) &&
            this.type == other.type &&
            this.version == other.version)
                return true;
            return false;
        }
    }
    public class BasicDataDto : IEquatable<BasicDataDto>
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

        public bool Equals(BasicDataDto other)
        {
            if (this.colloq == other.colloq &&
            this.consumeOnFull == other.consumeOnFull &&
            this.consumed == other.consumed &&
            this.depth == other.depth &&
            this.description == other.description &&
            this.from.SequenceEqual(other.from) &&
            this.gold == other.gold &&
            this.group == other.group &&
            this.hideFromAll == other.hideFromAll &&
            this.id == other.id &&
            this.image == other.image &&
            this.inStore == other.inStore &&
            this.into.SequenceEqual(other.into) &&
            this.maps.SequenceEqual(other.maps) &&
            this.name == other.name &&
            this.plaintext == other.plaintext &&
            this.requiredChampion == other.requiredChampion &&
            this.rune == other.rune &&
            this.sanitizedDescription == other.sanitizedDescription &&
            this.specialRecipe == other.specialRecipe &&
            this.stacks == other.stacks &&
            this.stats == other.stats &&
            this.tags.SequenceEqual(other.tags))
                return true;
            return false;
        }
    }
    public class GroupDto : IEquatable<GroupDto>
    {
        public string MaxGroupOwnable { get; set; }
        public string key { get; set; }

        public bool Equals(GroupDto other)
        {
            if (this.MaxGroupOwnable == other.MaxGroupOwnable &&
            this.key == other.key)
                return true;
            return false;
        }
    }
    public class ItemDto : IEquatable<ItemDto>
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

        public bool Equals(ItemDto other)
        {
            if (this.colloq == other.colloq &&
            this.consumeOnFull == other.consumeOnFull &&
            this.consumed == other.consumed &&
            this.depth == other.depth &&
            this.description == other.description &&
            this.effect.SequenceEqual(other.effect) &&
            this.from.SequenceEqual(other.from) &&
            this.gold == other.gold &&
            this.group == other.group &&
            this.hideFromAll == other.hideFromAll &&
            this.id == other.id &&
            this.image == other.image &&
            this.inStore == other.inStore &&
            this.into.SequenceEqual(other.into) &&
            this.maps.SequenceEqual(other.maps) &&
            this.name == other.name &&
            this.plaintext == other.plaintext &&
            this.requiredChampion == other.requiredChampion &&
            this.rune == other.rune &&
            this.sanitizedDescription == other.sanitizedDescription &&
            this.specialRecipe == other.specialRecipe &&
            this.stacks == other.stacks &&
            this.stats == other.stats &&
            this.tags.SequenceEqual(other.tags))
                return true;
            return false;
        }
    }
    public class ItemTreeDto : IEquatable<ItemTreeDto>
    {
        public string header { get; set; }
        public List<string> tags { get; set; }

        public bool Equals(ItemTreeDto other)
        {
            if (this.header == other.header &&
            this.tags.SequenceEqual(other.tags))
                return true;
            return false;
        }
    }
    #endregion
    #region Masteries
    public class MasteryListDto : IEquatable<MasteryListDto>
    {
        public Dictionary<string, MasteryDto> data { get; set; }
        public MasteryTreeDto tree { get; set; }
        public string type { get; set; }
        public string version { get; set; }

        public bool Equals(MasteryListDto other)
        {
            if (this.data.SequenceEqual(other.data) &&
            this.tree == other.tree &&
            this.type == other.type &&
            this.version == other.version)
                return true;
            return false;
        }
    }
    public class MasteryDto : IEquatable<MasteryDto>
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

        public bool Equals(MasteryDto other)
        {
            if (this.description.SequenceEqual(other.description) &&
            this.id == other.id &&
            this.image == other.image &&
            this.masteryTree == other.masteryTree &&
            this.name == other.name &&
            this.prereq == other.prereq &&
            this.rank == other.rank &&
            this.ranks == other.ranks &&
            this.sanitizedDescription.SequenceEqual(other.sanitizedDescription))
                return true;
            return false;
        }
    }
    public class MasteryTreeDto : IEquatable<MasteryTreeDto>
    {
        public List<MasteryTreeListDto> Cunning { get; set; }
        public List<MasteryTreeListDto> Ferocity { get; set; }
        public List<MasteryTreeListDto> Resolve { get; set; }

        public bool Equals(MasteryTreeDto other)
        {
            if (this.Cunning.SequenceEqual(other.Cunning) &&
            this.Ferocity.SequenceEqual(other.Ferocity) &&
            this.Resolve.SequenceEqual(other.Resolve))
                return true;
            return false;
        }
    }
    // ImageDto in static champion
    public class MasteryTreeListDto : IEquatable<MasteryTreeListDto>
    {
        public List<MasteryTreeItemDto> masteryTreeItems { get; set; }

        public bool Equals(MasteryTreeListDto other)
        {
            if (this.masteryTreeItems.SequenceEqual(other.masteryTreeItems))
                return true;
            return false;
        }
    }
    public class MasteryTreeItemDto : IEquatable<MasteryTreeItemDto>
    {
        public int masteryId { get; set; }
        public string prereq { get; set; }

        public bool Equals(MasteryTreeItemDto other)
        {
            if (this.masteryId == other.masteryId &&
            this.prereq == other.prereq)
                return true;
            return false;
        }
    }
    #endregion
    #region Runes
    public class RuneListDto : IEquatable<RuneListDto>
    {
        public BasicDataDto basic { get; set; }
        public Dictionary<string, RuneDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }

        public bool Equals(RuneListDto other)
        {
            if (this.basic == other.basic &&
            this.data.SequenceEqual(other.data) &&
            this.type == other.type &&
            this.version == other.version)
                return true;
            return false;
        }
    }
    public class RuneDto : IEquatable<RuneDto>
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

        public bool Equals(RuneDto other)
        {
            if (this.colloq == other.colloq &&
            this.consumeOnFull == other.consumeOnFull &&
            this.consumed == other.consumed &&
            this.depth == other.depth &&
            this.description == other.description &&
            this.from.SequenceEqual(other.from) &&
            this.group == other.group &&
            this.hideFromAll == other.hideFromAll &&
            this.id == other.id &&
            this.image == other.image &&
            this.inStore == other.inStore &&
            this.into.SequenceEqual(other.into) &&
            this.maps.SequenceEqual(other.maps) &&
            this.name == other.name &&
            this.plaintext == other.plaintext &&
            this.requiredChampion == other.requiredChampion &&
            this.rune == other.rune &&
            this.sanitizedDescription == other.sanitizedDescription &&
            this.specialRecipe == other.specialRecipe &&
            this.stacks == other.stacks &&
            this.stats == other.stats &&
            this.tags.SequenceEqual(other.tags))
                return true;
            return false;
        }
    }
    #endregion
    #region SummonerSpell
    public class SummonerSpellListDto : IEquatable<SummonerSpellListDto>
    {
        public Dictionary<string, SummonerSpellDto> data { get; set; }
        public string type { get; set; }
        public string version { get; set; }

        public bool Equals(SummonerSpellListDto other)
        {
            if (this.data.SequenceEqual(other.data) &&
            this.type == other.type &&
            this.version == other.version)
                return true;
            return false;
        }
    }
    public class SummonerSpellDto : IEquatable<SummonerSpellDto>
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

        public bool Equals(SummonerSpellDto other)
        {
            if (this.cooldown.SequenceEqual(other.cooldown) &&
            this.cooldownBurn == other.cooldownBurn &&
            this.cost.SequenceEqual(other.cost) &&
            this.costBurn == other.costBurn &&
            this.costType == other.costType &&
            this.description == other.description &&
            this.effect.SequenceEqual(other.effect) &&
            this.effectBurn.SequenceEqual(other.effectBurn) &&
            this.id == other.id &&
            this.image == other.image &&
            this.key == other.key &&
            this.leveltip == other.leveltip &&
            this.maxrank == other.maxrank &&
            this.modes.SequenceEqual(other.modes) &&
            this.name == other.name &&
            this.range == other.range &&
            this.rangeBurn == other.rangeBurn &&
            this.resource == other.resource &&
            this.sanitizedDescription == other.sanitizedDescription &&
            this.sanitizedTooltip == other.sanitizedTooltip &&
            this.summonerLevel == other.summonerLevel &&
            this.tooltip == other.tooltip &&
            this.vars.SequenceEqual(other.vars))
                return true;
            return false;
        }
    }
    public class LevelTipDto : IEquatable<LevelTipDto>
    {
        public List<string> effect { get; set; }
        public List<string> label { get; set; }

        public bool Equals(LevelTipDto other)
        {
            if (this.effect.SequenceEqual(other.effect) &&
            this.label.SequenceEqual(other.label))
                return true;
            return false;
        }
    }
    #endregion
    #endregion

    // status v1.0
    #region status v1.0
    public class ShardStatus : IEquatable<ShardStatus>
    {
        public string hostname { get; set; }
        public List<string> locales { get; set; }
        public string name { get; set; }
        public string region_tag { get; set; }
        public List<Service> services { get; set; }
        public string slug { get; set; }

        public bool Equals(ShardStatus other)
        {
            if (this.hostname == other.hostname &&
            this.locales.SequenceEqual(other.locales) &&
            this.name == other.name &&
            this.region_tag == other.region_tag &&
            this.services.SequenceEqual(other.services) &&
            this.slug == other.slug)
                return true;
            return false;
        }
    }
    public class Service : IEquatable<Service>
    {
        public List<Incident> incidents { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string status { get; set; }

        public bool Equals(Service other)
        {
            if (this.incidents.SequenceEqual(other.incidents) &&
            this.name == other.name &&
            this.slug == other.slug &&
            this.status == other.status)
                return true;
            return false;
        }
    }
    public class Incident : IEquatable<Incident>
    {
        public bool active { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public List<Message> updates { get; set; }

        public bool Equals(Incident other)
        {
            if (this.active == other.active &&
            this.created_at == other.created_at &&
            this.id == other.id &&
            this.updates.SequenceEqual(other.updates))
                return true;
            return false;
        }
    }
    public class Message : IEquatable<Message>
    {
        public string author { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
        public long id { get; set; }
        public string severity { get; set; }
        public List<Translation> translations { get; set; }
        public string updated_at { get; set; }

        public bool Equals(Message other)
        {
            if (this.author == other.author &&
            this.content == other.content &&
            this.created_at == other.created_at &&
            this.id == other.id &&
            this.severity == other.severity &&
            this.translations.SequenceEqual(other.translations) &&
            this.updated_at == other.updated_at)
                return true;
            return false;
        }
    }
    public class Translation : IEquatable<Translation>
    {
        public string content { get; set; }
        public string locale { get; set; }
        public string updated_at { get; set; }

        public bool Equals(Translation other)
        {
            if (this.content == other.content &&
            this.locale == other.locale &&
            this.updated_at == other.updated_at)
                return true;
            return false;
        }
    }
    #endregion

    // Match v2.2
    #region Match v2.2
    public class MatchDetail : IEquatable<MatchDetail>
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

        public bool Equals(MatchDetail other)
        {
            if (this.mapId == other.mapId &&
            this.matchCreation == other.matchCreation &&
            this.matchDuration == other.matchDuration &&
            this.matchId == other.matchId &&
            this.matchMode == other.matchMode &&
            this.matchType == other.matchType &&
            this.matchVersion == other.matchVersion &&
            this.participantIdentities.SequenceEqual(other.participantIdentities) &&
            this.participants.SequenceEqual(other.participants) &&
            this.platformId == other.platformId &&
            this.queueType == other.queueType &&
            this.region == other.region &&
            this.season == other.season &&
            this.teams.SequenceEqual(other.teams) &&
            this.timeline == other.timeline)
                return true;
            return false;
        }
    }
    public class Participant : IEquatable<Participant>
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

        public bool Equals(Participant other)
        {
            if (this.championId == other.championId &&
            this.highestAchievedSeasonTier == other.highestAchievedSeasonTier &&
            this.masteries.SequenceEqual(other.masteries) &&
            this.participantId == other.participantId &&
            this.runes.SequenceEqual(other.runes) &&
            this.spell1Id == other.spell1Id &&
            this.spell2Id == other.spell2Id &&
            this.stats == other.stats &&
            this.teamId == other.teamId &&
            this.timeline == other.timeline)
                return true;
            return false;
        }
    }
    public class ParticipantIdentity : IEquatable<ParticipantIdentity>
    {
        public int participantId { get; set; }
        public Player player { get; set; }

        public bool Equals(ParticipantIdentity other)
        {
            if (this.participantId == other.participantId &&
            this.player == other.player)
                return true;
            return false;
        }
    }
    public class Team : IEquatable<Team>
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

        public bool Equals(Team other)
        {
            if (this.bans.SequenceEqual(other.bans) &&
            this.baronKills == other.baronKills &&
            this.dominionVictoryScore == other.dominionVictoryScore &&
            this.dragonKills == other.dragonKills &&
            this.firstBaron == other.firstBaron &&
            this.firstBlood == other.firstBlood &&
            this.firstDragon == other.firstDragon &&
            this.firstInhibitor == other.firstInhibitor &&
            this.firstRiftHerald == other.firstRiftHerald &&
            this.firstTower == other.firstTower &&
            this.inhibitorKills == other.inhibitorKills &&
            this.riftHeraldKills == other.riftHeraldKills &&
            this.teamId == other.teamId &&
            this.towerKills == other.towerKills &&
            this.vilemawKills == other.vilemawKills &&
            this.winner == other.winner)
                return true;
            return false;
        }
    }
    public class Timeline : IEquatable<Timeline>
    {
        public long frameInterval { get; set; }
        public List<Frame> frames { get; set; }

        public bool Equals(Timeline other)
        {
            if (this.frameInterval == other.frameInterval &&
            this.frames.SequenceEqual(other.frames))
                return true;
            return false;
        }
    }
    public class ParticipantStats : IEquatable<ParticipantStats>
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

        public bool Equals(ParticipantStats other)
        {
            if (this.assists == other.assists &&
            this.champLevel == other.champLevel &&
            this.combatPlayerScore == other.combatPlayerScore &&
            this.deaths == other.deaths &&
            this.doubleKills == other.doubleKills &&
            this.firstBloodAssist == other.firstBloodAssist &&
            this.firstBloodKill == other.firstBloodKill &&
            this.firstInhibitorAssist == other.firstInhibitorAssist &&
            this.firstInhibitorKill == other.firstInhibitorKill &&
            this.firstTowerAssist == other.firstTowerAssist &&
            this.firstTowerKill == other.firstTowerKill &&
            this.goldEarned == other.goldEarned &&
            this.goldSpent == other.goldSpent &&
            this.inhibitorKills == other.inhibitorKills &&
            this.item0 == other.item0 &&
            this.item1 == other.item1 &&
            this.item2 == other.item2 &&
            this.item3 == other.item3 &&
            this.item4 == other.item4 &&
            this.item5 == other.item5 &&
            this.item6 == other.item6 &&
            this.killingSprees == other.killingSprees &&
            this.kills == other.kills &&
            this.largestCriticalStrike == other.largestCriticalStrike &&
            this.largestKillingSpree == other.largestKillingSpree &&
            this.largestMultiKill == other.largestMultiKill &&
            this.magicDamageDealt == other.magicDamageDealt &&
            this.magicDamageDealtToChampions == other.magicDamageDealtToChampions &&
            this.magicDamageTaken == other.magicDamageTaken &&
            this.minionsKilled == other.minionsKilled &&
            this.neutralMinionsKilled == other.neutralMinionsKilled &&
            this.neutralMinionsKilledEnemyJungle == other.neutralMinionsKilledEnemyJungle &&
            this.neutralMinionsKilledTeamJungle == other.neutralMinionsKilledTeamJungle &&
            this.nodeCapture == other.nodeCapture &&
            this.nodeCaptureAssist == other.nodeCaptureAssist &&
            this.nodeNeutralize == other.nodeNeutralize &&
            this.nodeNeutralizeAssist == other.nodeNeutralizeAssist &&
            this.objectivePlayerScore == other.objectivePlayerScore &&
            this.pentaKills == other.pentaKills &&
            this.physicalDamageDealt == other.physicalDamageDealt &&
            this.physicalDamageDealtToChampions == other.physicalDamageDealtToChampions &&
            this.physicalDamageTaken == other.physicalDamageTaken &&
            this.quadraKills == other.quadraKills &&
            this.sightWardsBoughtInGame == other.sightWardsBoughtInGame &&
            this.teamObjective == other.teamObjective &&
            this.totalDamageDealt == other.totalDamageDealt &&
            this.totalDamageDealtToChampions == other.totalDamageDealtToChampions &&
            this.totalDamageTaken == other.totalDamageTaken &&
            this.totalHeal == other.totalHeal &&
            this.totalPlayerScore == other.totalPlayerScore &&
            this.totalScoreRank == other.totalScoreRank &&
            this.totalTimeCrowdControlDealt == other.totalTimeCrowdControlDealt &&
            this.totalUnitsHealed == other.totalUnitsHealed &&
            this.towerKills == other.towerKills &&
            this.tripleKills == other.tripleKills &&
            this.trueDamageDealt == other.trueDamageDealt &&
            this.trueDamageDealtToChampions == other.trueDamageDealtToChampions &&
            this.trueDamageTaken == other.trueDamageTaken &&
            this.unrealKills == other.unrealKills &&
            this.visionWardsBoughtInGame == other.visionWardsBoughtInGame &&
            this.wardsKilled == other.wardsKilled &&
            this.wardsPlaced == other.wardsPlaced &&
            this.winner == other.winner)
                return true;
            return false;
        }
    }
    public class ParticipantTimeline : IEquatable<ParticipantTimeline>
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

        public bool Equals(ParticipantTimeline other)
        {
            if (this.ancientGolemAssistsPerMinCounts == other.ancientGolemAssistsPerMinCounts &&
            this.ancientGolemKillsPerMinCounts == other.ancientGolemKillsPerMinCounts &&
            this.assistedLaneDeathsPerMinDeltas == other.assistedLaneDeathsPerMinDeltas &&
            this.assistedLaneKillsPerMinDeltas == other.assistedLaneKillsPerMinDeltas &&
            this.baronAssistsPerMinCounts == other.baronAssistsPerMinCounts &&
            this.baronKillsPerMinCounts == other.baronKillsPerMinCounts &&
            this.creepsPerMinDeltas == other.creepsPerMinDeltas &&
            this.csDiffPerMinDeltas == other.csDiffPerMinDeltas &&
            this.damageTakenDiffPerMinDeltas == other.damageTakenDiffPerMinDeltas &&
            this.damageTakenPerMinDeltas == other.damageTakenPerMinDeltas &&
            this.dragonAssistsPerMinCounts == other.dragonAssistsPerMinCounts &&
            this.dragonKillsPerMinCounts == other.dragonKillsPerMinCounts &&
            this.elderLizardAssistsPerMinCounts == other.elderLizardAssistsPerMinCounts &&
            this.elderLizardKillsPerMinCounts == other.elderLizardKillsPerMinCounts &&
            this.goldPerMinDeltas == other.goldPerMinDeltas &&
            this.inhibitorAssistsPerMinCounts == other.inhibitorAssistsPerMinCounts &&
            this.inhibitorKillsPerMinCounts == other.inhibitorKillsPerMinCounts &&
            this.lane == other.lane &&
            this.role == other.role &&
            this.towerAssistsPerMinCounts == other.towerAssistsPerMinCounts &&
            this.towerKillsPerMinCounts == other.towerKillsPerMinCounts &&
            this.towerKillsPerMinDeltas == other.towerKillsPerMinDeltas &&
            this.vilemawAssistsPerMinCounts == other.vilemawAssistsPerMinCounts &&
            this.vilemawKillsPerMinCounts == other.vilemawKillsPerMinCounts &&
            this.wardsPerMinDeltas == other.wardsPerMinDeltas &&
            this.xpDiffPerMinDeltas == other.xpDiffPerMinDeltas &&
            this.xpPerMinDeltas == other.xpPerMinDeltas)
                return true;
            return false;
        }
    }
    public class Player : IEquatable<Player>
    {
        public string matchHistoryUri { get; set; }
        public int profileIcon { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }

        public bool Equals(Player other)
        {
            if (this.matchHistoryUri == other.matchHistoryUri &&
            this.profileIcon == other.profileIcon &&
            this.summonerId == other.summonerId &&
            this.summonerName == other.summonerName)
                return true;
            return false;
        }
    }
    public class Frame : IEquatable<Frame>
    {
        public List<Event> events { get; set; }
        public Dictionary<string, ParticipantFrame> participantFrames { get; set; }
        public long timestamp { get; set; }

        public bool Equals(Frame other)
        {
            if (this.events.SequenceEqual(other.events) &&
            this.participantFrames.SequenceEqual(other.participantFrames) &&
            this.timestamp == other.timestamp)
                return true;
            return false;
        }
    }
    public class ParticipantTimelineData : IEquatable<ParticipantTimelineData>
    {
        public double tenToTwenty { get; set; }
        public double thirtyToEnd { get; set; }
        public double twentyToThirty { get; set; }
        public double zeroToTen { get; set; }

        public bool Equals(ParticipantTimelineData other)
        {
            if (this.tenToTwenty == other.tenToTwenty &&
            this.thirtyToEnd == other.thirtyToEnd &&
            this.twentyToThirty == other.twentyToThirty &&
            this.zeroToTen == other.zeroToTen)
                return true;
            return false;
        }
    }
    public class Event : IEquatable<Event>
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

        public bool Equals(Event other)
        {
            if (this.ascendedType == other.ascendedType &&
            this.assistingParticipantIds.SequenceEqual(other.assistingParticipantIds) &&
            this.buildingType == other.buildingType &&
            this.creatorId == other.creatorId &&
            this.eventType == other.eventType &&
            this.itemAfter == other.itemAfter &&
            this.itemBefore == other.itemBefore &&
            this.itemId == other.itemId &&
            this.killerId == other.killerId &&
            this.laneType == other.laneType &&
            this.levelUpType == other.levelUpType &&
            this.monsterType == other.monsterType &&
            this.participantId == other.participantId &&
            this.pointCaptured == other.pointCaptured &&
            this.position == other.position &&
            this.skillSlot == other.skillSlot &&
            this.teamId == other.teamId &&
            this.timestamp == other.timestamp &&
            this.towerType == other.towerType &&
            this.victimId == other.victimId &&
            this.wardType == other.wardType)
                return true;
            return false;
        }
    }
    public class ParticipantFrame : IEquatable<ParticipantFrame>
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

        public bool Equals(ParticipantFrame other)
        {
            if (this.currentGold == other.currentGold &&
            this.dominionScore == other.dominionScore &&
            this.jungleMinionsKilled == other.jungleMinionsKilled &&
            this.level == other.level &&
            this.minionsKilled == other.minionsKilled &&
            this.participantId == other.participantId &&
            this.position == other.position &&
            this.teamScore == other.teamScore &&
            this.totalGold == other.totalGold &&
            this.xp == other.xp)
                return true;
            return false;
        }
    }
    public class Position : IEquatable<Position>
    {
        public int x { get; set; }
        public int y { get; set; }

        public bool Equals(Position other)
        {
            if (this.x == other.x &&
            this.y == other.y)
                return true;
            return false;
        }
    }
    #endregion

    // MatchList v2.2
    #region MatchList v2.2
    public class MatchList : IEquatable<MatchList>
    {
        public int endIndex { get; set; }
        public List<MatchReference> matches { get; set; }
        public int startIndex { get; set; }
        public int totalGames { get; set; }

        public bool Equals(MatchList other)
        {
            if (this.endIndex == other.endIndex &&
            this.matches.SequenceEqual(other.matches) &&
            this.startIndex == other.startIndex &&
            this.totalGames == other.totalGames)
                return true;
            return false;
        }
    }
    public class MatchReference : IEquatable<MatchReference>
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

        public bool Equals(MatchReference other)
        {
            if (this.champion == other.champion &&
            this.lane == other.lane &&
            this.matchId == other.matchId &&
            this.platformId == other.platformId &&
            this.queue == other.queue &&
            this.region == other.region &&
            this.role == other.role &&
            this.season == other.season &&
            this.timestamp == other.timestamp)
                return true;
            return false;
        }
    }
    #endregion

    // stats v1.3
    #region stats v1.3
    #region Ranked stats by summoner ID
    public class RankedStatsDto : IEquatable<RankedStatsDto>
    {
        public List<ChampionStatsDto> champions { get; set; }
        public long modifyDate { get; set; }
        public long summonerId { get; set; }

        public bool Equals(RankedStatsDto other)
        {
            if (this.champions.SequenceEqual(other.champions) &&
            this.modifyDate == other.modifyDate &&
            this.summonerId == other.summonerId)
                return true;
            return false;
        }
    }
    public class ChampionStatsDto : IEquatable<ChampionStatsDto>
    {
        public int id { get; set; }
        public AggregatedStatsDto stats { get; set; }

        public bool Equals(ChampionStatsDto other)
        {
            if (this.id == other.id &&
            this.stats == other.stats)
                return true;
            return false;
        }
    }
    public class AggregatedStatsDto : IEquatable<AggregatedStatsDto>
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

        public bool Equals(AggregatedStatsDto other)
        {
            if (this.averageAssists == other.averageAssists &&
            this.averageChampionsKilled == other.averageChampionsKilled &&
            this.averageCombatPlayerScore == other.averageCombatPlayerScore &&
            this.averageNodeCapture == other.averageNodeCapture &&
            this.averageNodeCaptureAssist == other.averageNodeCaptureAssist &&
            this.averageNodeNeutralize == other.averageNodeNeutralize &&
            this.averageNodeNeutralizeAssist == other.averageNodeNeutralizeAssist &&
            this.averageNumDeaths == other.averageNumDeaths &&
            this.averageObjectivePlayerScore == other.averageObjectivePlayerScore &&
            this.averageTeamObjective == other.averageTeamObjective &&
            this.averageTotalPlayerScore == other.averageTotalPlayerScore &&
            this.botGamesPlayed == other.botGamesPlayed &&
            this.killingSpree == other.killingSpree &&
            this.maxAssists == other.maxAssists &&
            this.maxChampionsKilled == other.maxChampionsKilled &&
            this.maxCombatPlayerScore == other.maxCombatPlayerScore &&
            this.maxLargestCriticalStrike == other.maxLargestCriticalStrike &&
            this.maxLargestKillingSpree == other.maxLargestKillingSpree &&
            this.maxNodeCapture == other.maxNodeCapture &&
            this.maxNodeCaptureAssist == other.maxNodeCaptureAssist &&
            this.maxNodeNeutralize == other.maxNodeNeutralize &&
            this.maxNodeNeutralizeAssist == other.maxNodeNeutralizeAssist &&
            this.maxNumDeaths == other.maxNumDeaths &&
            this.maxObjectivePlayerScore == other.maxObjectivePlayerScore &&
            this.maxTeamObjective == other.maxTeamObjective &&
            this.maxTimePlayed == other.maxTimePlayed &&
            this.maxTimeSpentLiving == other.maxTimeSpentLiving &&
            this.maxTotalPlayerScore == other.maxTotalPlayerScore &&
            this.mostChampionKillsPerSession == other.mostChampionKillsPerSession &&
            this.mostSpellsCast == other.mostSpellsCast &&
            this.normalGamesPlayed == other.normalGamesPlayed &&
            this.rankedPremadeGamesPlayed == other.rankedPremadeGamesPlayed &&
            this.rankedSoloGamesPlayed == other.rankedSoloGamesPlayed &&
            this.totalAssists == other.totalAssists &&
            this.totalChampionKills == other.totalChampionKills &&
            this.totalDamageDealt == other.totalDamageDealt &&
            this.totalDamageTaken == other.totalDamageTaken &&
            this.totalDeathsPerSession == other.totalDeathsPerSession &&
            this.totalDoubleKills == other.totalDoubleKills &&
            this.totalFirstBlood == other.totalFirstBlood &&
            this.totalGoldEarned == other.totalGoldEarned &&
            this.totalHeal == other.totalHeal &&
            this.totalMagicDamageDealt == other.totalMagicDamageDealt &&
            this.totalMinionKills == other.totalMinionKills &&
            this.totalNeutralMinionsKilled == other.totalNeutralMinionsKilled &&
            this.totalNodeCapture == other.totalNodeCapture &&
            this.totalNodeNeutralize == other.totalNodeNeutralize &&
            this.totalPentaKills == other.totalPentaKills &&
            this.totalPhysicalDamageDealt == other.totalPhysicalDamageDealt &&
            this.totalQuadraKills == other.totalQuadraKills &&
            this.totalSessionsLost == other.totalSessionsLost &&
            this.totalSessionsPlayed == other.totalSessionsPlayed &&
            this.totalSessionsWon == other.totalSessionsWon &&
            this.totalTripleKills == other.totalTripleKills &&
            this.totalTurretsKilled == other.totalTurretsKilled &&
            this.totalUnrealKills == other.totalUnrealKills)
                return true;
            return false;
        }
    }
    #endregion
    #region Player stats summaries by ID
    public class PlayerStatsSummaryListDto : IEquatable<PlayerStatsSummaryListDto>
    {
        public List<PlayerStatsSummaryDto> playerStatSummaries { get; set; }
        public long summonerId { get; set; }

        public bool Equals(PlayerStatsSummaryListDto other)
        {
            if (this.playerStatSummaries.SequenceEqual(other.playerStatSummaries) &&
            this.summonerId == other.summonerId)
                return true;
            return false;
        }
    }
    public class PlayerStatsSummaryDto : IEquatable<PlayerStatsSummaryDto>
    {
        public AggregatedStatsDto aggregatedStats { get; set; }
        public int losses { get; set; }
        public long modifyDate { get; set; }
        public string playerStatSummaryType { get; set; }
        public int wins { get; set; }

        public bool Equals(PlayerStatsSummaryDto other)
        {
            if (this.aggregatedStats == other.aggregatedStats &&
            this.losses == other.losses &&
            this.modifyDate == other.modifyDate &&
            this.playerStatSummaryType == other.playerStatSummaryType &&
            this.wins == other.wins)
                return true;
            return false;
        }
    }
    #endregion
    #endregion

    // Summoner v1.4
    #region Summoner v1.4
    #region Summoner info by name
    public class SummonerDto : IEquatable<SummonerDto>
    {
        public long id { get; set; }
        public string name { get; set; }
        public int profileIconId { get; set; }
        public long revisionDate { get; set; }
        public long summonerLevel { get; set; }

        public bool Equals(SummonerDto other)
        {
            if (this.id == other.id &&
            this.name == other.name &&
            this.profileIconId == other.profileIconId &&
            this.revisionDate == other.revisionDate &&
            this.summonerLevel == other.summonerLevel)
                return true;
            return false;
        }
    }
    #endregion
    #region Summoner mastery pages
    public class MasteryPagesDto : IEquatable<MasteryPagesDto>
    {
        public HashSet<MasteryPageDto> pages { get; set; }
        public long summonerId { get; set; }

        public bool Equals(MasteryPagesDto other)
        {
            if (this.pages.SetEquals(other.pages) &&
            this.summonerId == other.summonerId)
                return true;
            return false;
        }
    }
    public class MasteryPageDto : IEquatable<MasteryPageDto>
    {
        public bool current { get; set; }
        public long id { get; set; }
        public List<MasteryDto> masteries { get; set; }
        public string name { get; set; }

        public bool Equals(MasteryPageDto other)
        {
            if (this.current == other.current &&
            this.id == other.id &&
            this.masteries.SequenceEqual(other.masteries) &&
            this.name == other.name)
                return true;
            return false;
        }
    }
    #endregion
    #region Rune pages by summoner id
    public class RunePagesDto : IEquatable<RunePagesDto>
    {
        public HashSet<RunePageDto> pages { get; set; }
        public long summonerId { get; set; }

        public bool Equals(RunePagesDto other)
        {
            if (this.pages.SetEquals(other.pages) &&
            this.summonerId == other.summonerId)
                return true;
            return false;
        }
    }
    public class RunePageDto : IEquatable<RunePageDto>
    {
        public bool current { get; set; }
        public long id { get; set; }
        public string name { get; set; }
        public HashSet<RuneSlotDto> slots { get; set; }

        public bool Equals(RunePageDto other)
        {
            if (this.current == other.current &&
            this.id == other.id &&
            this.name == other.name &&
            this.slots.SetEquals(other.slots))
                return true;
            return false;
        }
    }
    public class RuneSlotDto : IEquatable<RuneSlotDto>
    {
        public int runeId { get; set; }
        public int runeSlotId { get; set; }

        public bool Equals(RuneSlotDto other)
        {
            if (this.runeId == other.runeId &&
            this.runeSlotId == other.runeSlotId)
                return true;
            return false;
        }
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
        private static string MATCH_REQUEST = "https://na.api.pvp.net/api/lol/na/v2.2/match/?includeTimeline=&api_key=";
        private static string CHAMP_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?locale=&version=&dataById=&api_key=";
        private static string MASTERY_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/mastery?locale=&version=&api_key=";
        private static string ITEM_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/item?locale=&version=&api_key=";
        private static string RUNE_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/rune?locale=&version=&api_key=";
        private static string SMN_SPELL_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/summoner-spell?locale=&version=&dataById=&api_key=";

        // SMN Name request URL
        private static string SMN_NAME_REQUEST = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/?api_key=";
        private static string SMN_REQUEST = "https://na.api.pvp.net/api/lol/na/v1.4/summoner/?api_key=";
        private static string SMN_MASTERY_REQUEST = "https://na.api.pvp.net/api/lol/na/v1.4/summoner//masteries?api_key=";
        private static string SMN_RUNE_REQUEST = "https://na.api.pvp.net/api/lol/na/v1.4/summoner//runes?api_key=";

        // League status request
        private static string LOLSTATUS_REQUEST = "http://status.leagueoflegends.com/shards/na";

        // Version request
        private static string VERSION_REQUEST = "https://global.api.pvp.net/api/lol/static-data/na/v1.2/versions?api_key=";
        #endregion

        // Helper function: Get the JSON object from url
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
        public static MatchDetail Get_Match_From_Match_ID(long matchid, string apikey, bool timeline = false)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = MATCH_REQUEST + apikey;
            url = url.Insert(url.IndexOf("match/") + 6, matchid.ToString());
            url = url.Insert(url.IndexOf("?includeTimeline=") + 17, timeline.ToString());

            try
            {
                return Get_Json<MatchDetail>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
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
        public static Dictionary<string, SummonerDto> Get_Summoner_By_ID (long id, string apikey)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = SMN_REQUEST + apikey;
            url = url.Insert(url.IndexOf("summoner/") + 9, id.ToString());

            try
            {
                return Get_Json<Dictionary<string, SummonerDto>>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static Dictionary<string, MasteryPagesDto> Get_Summoner_Masteries (long id, string apikey)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = SMN_MASTERY_REQUEST + apikey;
            url = url.Insert(url.IndexOf("summoner/") + 9, id.ToString());

            try
            {
                return Get_Json<Dictionary<string, MasteryPagesDto>>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static Dictionary<string, RunePagesDto> Get_Summoner_Runes (long id, string apikey)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = SMN_RUNE_REQUEST + apikey;
            url = url.Insert(url.IndexOf("summoner/") + 9, id.ToString());

            try
            {
                return Get_Json<Dictionary<string, RunePagesDto>>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // API: lol-static-data-v1.2
        public static MasteryListDto Get_Masteries(string apikey, string version = "", string locale = "en_US")
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = MASTERY_REQUEST + apikey;
            url = url.Insert(url.IndexOf("?version=") + 9, version);
            url = url.Insert(url.IndexOf("?locale=") + 8, locale);
            try
            {
                return Get_Json<MasteryListDto>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static ChampionListDto Get_Champions(string apikey, string version = "", string locale = "en_US", bool databyid = false)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = CHAMP_REQUEST + apikey;
            url = url.Insert(url.IndexOf("?version=") + 9, version);
            url = url.Insert(url.IndexOf("&dataById=") + 10, databyid.ToString());
            url = url.Insert(url.IndexOf("?locale=") + 8, locale);
            try
            {
                return Get_Json<ChampionListDto>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static ItemListDto Get_Items(string apikey, string version = "", string locale = "en_US")
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = ITEM_REQUEST + apikey;
            url = url.Insert(url.IndexOf("?version=") + 9, version);
            url = url.Insert(url.IndexOf("?locale=") + 8, locale);
            try
            {
                return Get_Json<ItemListDto>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<string> Get_Version(string apikey)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");
            try
            {
                return Get_Json<List<string>>(VERSION_REQUEST + apikey);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static SummonerSpellListDto Get_Summoner_Spells(string apikey, string version = "", string locale = "en_US", bool databyid = false)
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = SMN_SPELL_REQUEST + apikey;
            url = url.Insert(url.IndexOf("?locale=") + 8, locale);
            url = url.Insert(url.IndexOf("&dataById=") + 10, databyid.ToString());
            url = url.Insert(url.IndexOf("&version=") + 9, version);
            try
            {
                return Get_Json<SummonerSpellListDto>(url);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static RuneListDto Get_Runes(string apikey, string version = "", string locale = "en_US")
        {
            if (String.IsNullOrEmpty(apikey))
                throw new Exception("Invalid API key");

            var url = SMN_SPELL_REQUEST + apikey;
            url = url.Insert(url.IndexOf("?locale=") + 8, locale);
            url = url.Insert(url.IndexOf("&version=") + 9, version);
            try
            {
                return Get_Json<RuneListDto>(url);
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
