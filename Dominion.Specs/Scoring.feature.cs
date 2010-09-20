// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Scoring")]
    public partial class ScoringFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Scoring.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scoring", "In order to know how well I did in the game\r\nAs a Dominion player\r\nI want the sco" +
                    "res to be calculated", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Players start with 3 points")]
        public virtual void PlayersStartWith3Points()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Players start with 3 points", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("A new game with 3 players");
#line 8
testRunner.When("The game is scored");
#line 9
testRunner.Then("Player1 should have 3 victory points");
#line 10
testRunner.And("Player2 should have 3 victory points");
#line 11
testRunner.And("Player3 should have 3 victory points");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Score cards in all regions")]
        public virtual void ScoreCardsInAllRegions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Score cards in all regions", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
testRunner.Given("A new game with 3 players");
#line 15
testRunner.And("Player1 has a Curse in hand instead of a Copper");
#line 16
testRunner.And("Player1 has a GreatHall in play");
#line 17
testRunner.And("Player1 has a Province in the discard pile");
#line 18
testRunner.When("The game is scored");
#line 19
testRunner.Then("Player1 should have 9 victory points");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Show sorted deck in play area once game is scored")]
        public virtual void ShowSortedDeckInPlayAreaOnceGameIsScored()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Show sorted deck in play area once game is scored", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
testRunner.Given("A new game with 3 players");
#line 23
testRunner.And("Player1 has a Curse in hand instead of a Copper");
#line 24
testRunner.And("Player1 has a GreatHall in play");
#line 25
testRunner.And("Player1 has a Province in the discard pile");
#line 26
testRunner.When("The game is scored");
#line 27
testRunner.Then("Player1\'s play area should start with this sequence of cards: Province, Estate, E" +
                    "state, Estate, GreatHall, Curse");
#line 28
testRunner.Then("Player2\'s play area should start with this sequence of cards: Estate, Estate, Est" +
                    "ate");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
