﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace StealthBot.SpecFlow.Actions
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DropOffToJetissonContainerActionTest")]
    [NUnit.Framework.CategoryAttribute("DropOffToJetissonContainerActionTest")]
    public partial class DropOffToJetissonContainerActionTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "DropOffToJetissonContainerActionTest"};
        
#line 1 "DropOffToJetissonContainerActionTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Actions", "DropOffToJetissonContainerActionTest", "\tAs a miner\r\n\tI want to unload ore to a jetisson container", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1 a - When no jetcan exists / is active, and I have ore in my ore hold, create a " +
            "new one")]
        public void _1A_WhenNoJetcanExistsIsActiveAndIHaveOreInMyOreHoldCreateANewOne()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 a - When no jetcan exists / is active, and I have ore in my ore hold, create a " +
                    "new one", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "Name"});
                table28.AddRow(new string[] {
                            "<scordite>",
                            "Scordite"});
#line 7
testRunner.Given("I have ore hold items", ((string)(null)), table28, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table29 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "ID",
                            "Name",
                            "IsLockedTarget"});
#line 10
testRunner.And("I have entities", ((string)(null)), table29, "And ");
#line hidden
#line 12
testRunner.When("I process jetisson container dropoff (\'1\' time(s))", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
testRunner.Then("item \'<scordite>\' should have been jetissoned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1 b - When no jetcan exists / is active, and I have ore in my cargo hold, create " +
            "a new one")]
        public void _1B_WhenNoJetcanExistsIsActiveAndIHaveOreInMyCargoHoldCreateANewOne()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 b - When no jetcan exists / is active, and I have ore in my cargo hold, create " +
                    "a new one", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table30 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "Name",
                            "CategoryID"});
                table30.AddRow(new string[] {
                            "<scordite>",
                            "Scordite",
                            "25"});
#line 16
testRunner.Given("I have cargo hold items", ((string)(null)), table30, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "ID",
                            "Name",
                            "IsLockedTarget"});
#line 19
testRunner.And("I have entities", ((string)(null)), table31, "And ");
#line hidden
#line 21
testRunner.When("I process jetisson container dropoff (\'1\' time(s))", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
testRunner.Then("item \'<scordite>\' should have been jetissoned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("1 c - When no jetcan exists / is active, and I have ore in my ore hold and cargo," +
            " create a new one from the ore hold item")]
        public void _1C_WhenNoJetcanExistsIsActiveAndIHaveOreInMyOreHoldAndCargoCreateANewOneFromTheOreHoldItem()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1 c - When no jetcan exists / is active, and I have ore in my ore hold and cargo," +
                    " create a new one from the ore hold item", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "Name",
                            "CategoryID"});
                table32.AddRow(new string[] {
                            "<scordite>",
                            "Scordite",
                            "25"});
#line 25
testRunner.Given("I have cargo hold items", ((string)(null)), table32, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "Name"});
                table33.AddRow(new string[] {
                            "<veldspar>",
                            "Veldspar"});
#line 28
testRunner.And("I have ore hold items", ((string)(null)), table33, "And ");
#line hidden
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "!this",
                            "ID",
                            "Name",
                            "IsLockedTarget"});
#line 31
testRunner.And("I have entities", ((string)(null)), table34, "And ");
#line hidden
#line 33
testRunner.When("I process jetisson container dropoff (\'1\' time(s))", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
testRunner.Then("item \'<veldspar>\' should have been jetissoned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
testRunner.And("item \'<scordite>\' should not have been jettisoned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 a - When no jetcan was active, and I had no existing cans, and I jettison an it" +
            "em, I should detect the new can and make it active")]
        public void _2A_WhenNoJetcanWasActiveAndIHadNoExistingCansAndIJettisonAnItemIShouldDetectTheNewCanAndMakeItActive()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 a - When no jetcan was active, and I had no existing cans, and I jettison an it" +
                    "em, I should detect the new can and make it active", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 b - When no jetcan was active, and I had existing nearby jetcans, and I jettiso" +
            "n an item, I should detect the new can and make it active")]
        public void _2B_WhenNoJetcanWasActiveAndIHadExistingNearbyJetcansAndIJettisonAnItemIShouldDetectTheNewCanAndMakeItActive()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 b - When no jetcan was active, and I had existing nearby jetcans, and I jettiso" +
                    "n an item, I should detect the new can and make it active", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("3 - Only try to create a new jetisson container after the 3-minute cooldown")]
        public void _3_OnlyTryToCreateANewJetissonContainerAfterThe3_MinuteCooldown()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("3 - Only try to create a new jetisson container after the 3-minute cooldown", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 41
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("4 - When the active jetcan is nearly full, it should be considered full and marke" +
            "d for pickup")]
        public void _4_WhenTheActiveJetcanIsNearlyFullItShouldBeConsideredFullAndMarkedForPickup()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("4 - When the active jetcan is nearly full, it should be considered full and marke" +
                    "d for pickup", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("5 - When no jetcan exists / is active, and I create one from either source, and j" +
            "etisson a full can, it should finish the dropoff cycle renamed and pickup reques" +
            "ted")]
        public void _5_WhenNoJetcanExistsIsActiveAndICreateOneFromEitherSourceAndJetissonAFullCanItShouldFinishTheDropoffCycleRenamedAndPickupRequested()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("5 - When no jetcan exists / is active, and I create one from either source, and j" +
                    "etisson a full can, it should finish the dropoff cycle renamed and pickup reques" +
                    "ted", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 45
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
