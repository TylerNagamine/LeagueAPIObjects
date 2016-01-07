using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeagueApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueApi.Tests
{
    [TestClass()]
    public class LeagueApiTests
    {
        private static string apikey = "b0991e7f-9626-4bad-85f5-6b0e8ae59a85";
        private static long testmatchid = 2060220320;
        private static long testsmnid = 21910919;

        [TestMethod()]
        public void Get_Match_From_Match_IDTest()
        {
            MatchDetail toTest = null;
            toTest = LeagueApi.Get_Match_From_Match_ID(testmatchid, apikey);
            Assert.AreNotEqual(toTest, null);
            Assert.AreEqual(toTest.matchId, testmatchid);
            Assert.AreEqual(toTest.matchCreation, 1452091262390);
        }

        [TestMethod()]
        public void Get_LoL_StatusTest()
        {
            statusContainer toTest = null;
            toTest = LeagueApi.Get_LoL_Status();

            Assert.AreNotEqual(toTest, null);
            Assert.AreEqual(toTest.client, "online");
            Assert.AreEqual(toTest.game, "online");
            Assert.AreEqual(toTest.store, "online");
            Assert.AreEqual(toTest.website, "online");
        }

        [TestMethod()]
        public void Get_Matches_From_Summoner_IDTest()
        {
            List<MatchReference> toTest = null;
            toTest = LeagueApi.Get_Matches_From_Summoner_ID(testsmnid, apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.Count, 0);
        }

        [TestMethod()]
        public void Get_Summoner_ID_By_NameTest()
        {
            long toTest = -1;
            toTest = LeagueApi.Get_Summoner_ID_By_Name("Cleare", apikey);

            Assert.AreEqual(toTest, testsmnid);
        }

        [TestMethod()]
        public void Get_Summoner_By_IDTest()
        {
            Dictionary<string, SummonerDto> toTest = null;
            toTest = LeagueApi.Get_Summoner_By_ID(testsmnid, apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.Count, 0);
            Assert.AreEqual(toTest[toTest.First().Key].name, "Cleare");
        }

        [TestMethod()]
        public void Get_Summoner_MasteriesTest()
        {
            Dictionary<string, MasteryPagesDto> toTest = null;
            toTest = LeagueApi.Get_Summoner_Masteries(testsmnid, apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.Count, 0);
            Assert.AreNotEqual(toTest[toTest.First().Key].pages.Count, 0);
        }

        [TestMethod()]
        public void Get_Summoner_RunesTest()
        {
            Dictionary<string, RunePagesDto> toTest = null;
            toTest = LeagueApi.Get_Summoner_Runes(testsmnid, apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.Count, 0);
            Assert.AreEqual(toTest[toTest.First().Key].pages.Count, 3);
        }

        [TestMethod()]
        public void Get_MasteriesTest()
        {
            MasteryListDto toTest = null;
            toTest = LeagueApi.Get_Masteries(apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.data, null);
            Assert.AreNotEqual(toTest.data.Count, 0);
            Assert.AreNotEqual(toTest.data[toTest.data.First().Key].id, 0);
        }

        [TestMethod()]
        public void Get_ChampionsTest()
        {
            ChampionListDto toTest = null;
            toTest = LeagueApi.Get_Champions(apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.data, null);
            Assert.AreNotEqual(String.IsNullOrEmpty(toTest.version), true);
            Assert.AreNotEqual(toTest.data.Count, 0);
            Assert.AreNotEqual(toTest.data[toTest.data.First().Key].id, 0);
        }

        [TestMethod()]
        public void Get_ItemsTest()
        {
            ItemListDto toTest = null;
            toTest = LeagueApi.Get_Items(apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.data, null);
            Assert.AreNotEqual(String.IsNullOrEmpty(toTest.version), true);
            Assert.AreNotEqual(toTest.data.Count, 0);
            Assert.AreNotEqual(toTest.data[toTest.data.First().Key].id, 0);
        }

        [TestMethod()]
        public void Get_VersionTest()
        {
            List<string> toTest = null;
            toTest = LeagueApi.Get_Version(apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.Count, 0);
            Assert.AreEqual(toTest[0], "5.24.2");
        }

        [TestMethod()]
        public void Get_Summoner_SpellsTest()
        {
            SummonerSpellListDto toTest = null;
            toTest = LeagueApi.Get_Summoner_Spells(apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.data, null);
            Assert.AreNotEqual(String.IsNullOrEmpty(toTest.version), true);
            Assert.AreNotEqual(toTest.data.Count, 0);
            Assert.AreNotEqual(toTest.data[toTest.data.First().Key].id, 0);
        }

        [TestMethod()]
        public void Get_RunesTest()
        {
            RuneListDto toTest = null;
            toTest = LeagueApi.Get_Runes(apikey);

            Assert.AreNotEqual(toTest, null);
            Assert.AreNotEqual(toTest.data, null);
            Assert.AreNotEqual(String.IsNullOrEmpty(toTest.version), true);
            Assert.AreNotEqual(toTest.data.Count, 0);
            Assert.AreNotEqual(toTest.data[toTest.data.First().Key].id, 0);
        }
    }
}