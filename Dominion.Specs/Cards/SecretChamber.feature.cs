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
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Secret Chamber")]
    public partial class SecretChamberFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SecretChamber.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Secret Chamber", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Player must select a number of cards to discard")]
        public virtual void PlayerMustSelectANumberOfCardsToDiscard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player must select a number of cards to discard", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a SecretChamber in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a SecretChamber");
#line 7
testRunner.Then("Player1 must select any number of cards from their hand");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player discards one card to Secret Chamber")]
        public virtual void PlayerDiscardsOneCardToSecretChamber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player discards one card to Secret Chamber", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
testRunner.Given("A new game with 3 players");
#line 11
testRunner.And("Player1 has a SecretChamber in hand instead of a Copper");
#line 12
testRunner.When("Player1 plays a SecretChamber");
#line 13
testRunner.And("Player1 selects a Copper to discard");
#line 14
testRunner.Then("Player1 should have 1 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player discards nothing to Secret Chamber")]
        public virtual void PlayerDiscardsNothingToSecretChamber()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player discards nothing to Secret Chamber", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 17
testRunner.Given("A new game with 3 players");
#line 18
testRunner.And("Player1 has a SecretChamber in hand instead of a Copper");
#line 19
testRunner.When("Player1 plays a SecretChamber");
#line 20
testRunner.And("Player1 selects nothing to discard");
#line 21
testRunner.Then("Player1 should have 0 to spend");
#line 22
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Secret Chamber is a reaction")]
        public virtual void SecretChamberIsAReaction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Secret Chamber is a reaction", ((string[])(null)));
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
testRunner.Given("A new game with 3 players");
#line 26
testRunner.And("Player1 has a Militia in hand instead of a Copper");
#line 27
testRunner.And("Player2 has a SecretChamber in hand instead of a Copper");
#line 28
testRunner.When("Player1 plays a Militia");
#line 29
testRunner.Then("Player2 may reveal a reaction");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player uses Secret Chamber\'s reaction effect and is prompted to select cards")]
        public virtual void PlayerUsesSecretChamberSReactionEffectAndIsPromptedToSelectCards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player uses Secret Chamber\'s reaction effect and is prompted to select cards", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 32
testRunner.Given("A new game with 3 players");
#line 33
testRunner.And("Player1 has a Militia in hand instead of a Copper");
#line 34
testRunner.And("Player2 has a SecretChamber in hand instead of a Copper");
#line 35
testRunner.When("Player1 plays a Militia");
#line 36
testRunner.When("Player2 reveals SecretChamber");
#line 37
testRunner.Then("Player2 must select 2 cards to put on top of the deck");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player uses Secret Chamber\'s reaction effect and cards are put on top")]
        public virtual void PlayerUsesSecretChamberSReactionEffectAndCardsArePutOnTop()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player uses Secret Chamber\'s reaction effect and cards are put on top", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
testRunner.Given("A new game with 3 players");
#line 41
testRunner.And("Player1 has a Militia in hand instead of a Copper");
#line 42
testRunner.And("Player2 has a hand of SecretChamber, Copper, Copper, Copper, Estate");
#line 43
testRunner.And("Player2 has a deck of Estate, Estate, Copper, Cooper, Copper");
#line 44
testRunner.When("Player1 plays a Militia");
#line 45
testRunner.When("Player2 reveals SecretChamber");
#line 46
testRunner.When("Player2 selects a SecretChamber to go on top");
#line 47
testRunner.When("Player2 selects a Copper to go on top");
#line 48
testRunner.Then("Player2 should have a hand of Copper, Copper, Estate, Estate, Estate");
#line 49
testRunner.And("Player2 should have a deck of Copper, SecretChamber, Copper, Copper, Copper");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
