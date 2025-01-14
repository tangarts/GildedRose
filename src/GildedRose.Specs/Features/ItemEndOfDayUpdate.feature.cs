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
namespace GildedRose.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ItemEndOfDayUpdate")]
    public partial class ItemEndOfDayUpdateFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ItemEndOfDayUpdate.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ItemEndOfDayUpdate", "\tAs a system owner\r\n\tIn order to manage inventory\r\n\tI need to update quality and " +
                    "sell-in values each day", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Once the sell by date has passed, Quality degrades twice as fast")]
        public virtual void OnceTheSellByDateHasPassedQualityDegradesTwiceAsFast()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Once the sell by date has passed, Quality degrades twice as fast", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Sell in",
                            "Quality"});
                table7.AddRow(new string[] {
                            "+5 Dexterity Vest",
                            "1",
                            "20"});
#line 7
 testRunner.Given("I have an item", ((string)(null)), table7, "Given ");
#line hidden
#line 10
 testRunner.And("the sell in date has passed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("the quality should decrease by 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Quality of an item is never negative")]
        public virtual void TheQualityOfAnItemIsNeverNegative()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Quality of an item is never negative", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Sell in",
                            "Quality"});
                table8.AddRow(new string[] {
                            "+5 Dexterity Vest",
                            "10",
                            "20"});
#line 15
 testRunner.Given("I have an item", ((string)(null)), table8, "Given ");
#line hidden
#line 18
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("the quality should be positive", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Aged Brie\" actually increases in Quality the older it gets")]
        public virtual void AgedBrieActuallyIncreasesInQualityTheOlderItGets()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Aged Brie\" actually increases in Quality the older it gets", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Sell in",
                            "Quality"});
                table9.AddRow(new string[] {
                            "Aged Brie",
                            "10",
                            "20"});
#line 22
 testRunner.Given("I have an item", ((string)(null)), table9, "Given ");
#line hidden
#line 25
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("the sell in value should decrease by 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then("the quality should increase by 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The Quality of an item is never more than 50")]
        [NUnit.Framework.TestCaseAttribute("+5 Dexterity Vest", "1", "2", null)]
        [NUnit.Framework.TestCaseAttribute("Aged Brie", "10", "3", null)]
        [NUnit.Framework.TestCaseAttribute("Elixir of the Mongoose", "5", "12", null)]
        [NUnit.Framework.TestCaseAttribute("Conjured Mana Cake", "13", "23", null)]
        public virtual void TheQualityOfAnItemIsNeverMoreThan50(string name, string sellIn, string quality, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Name", name);
            argumentsOfScenario.Add("SellIn", sellIn);
            argumentsOfScenario.Add("Quality", quality);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Quality of an item is never more than 50", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "SellIn",
                            "Quality"});
                table10.AddRow(new string[] {
                            string.Format("{0}", name),
                            string.Format("{0}", sellIn),
                            string.Format("{0}", quality)});
#line 30
 testRunner.Given("I have an item", ((string)(null)), table10, "Given ");
#line hidden
#line 33
 testRunner.And("it is not a Sulfuras", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then("the quality should be less than 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Sulfuras\", being a legendary item, never has to be sold or decreases in Quality")]
        public virtual void SulfurasBeingALegendaryItemNeverHasToBeSoldOrDecreasesInQuality()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Sulfuras\", being a legendary item, never has to be sold or decreases in Quality", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "SellIn",
                            "Quality"});
                table11.AddRow(new string[] {
                            "Sulfuras, Hand of Ragnaros",
                            "0",
                            "80"});
#line 45
 testRunner.Given("I have an item with the name of Sulfuras", ((string)(null)), table11, "Given ");
#line hidden
#line 48
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("the sell in date should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.And("the quality should be 80", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Backstage passes\" increases in Quality as it\'s SellIn  value approaches;")]
        public virtual void BackstagePassesIncreasesInQualityAsItsSellInValueApproaches()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Backstage passes\" increases in Quality as it\'s SellIn  value approaches;", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 52
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
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
        [NUnit.Framework.DescriptionAttribute("\"Backstage passes\" acts like brie")]
        public virtual void BackstagePassesActsLikeBrie()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Backstage passes\" acts like brie", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "SellIn",
                            "Quality"});
                table12.AddRow(new string[] {
                            "Backstage passes to a TAFKAL80ETC concert",
                            "12",
                            "2"});
#line 55
 testRunner.Given("I have an item with the name of Backstage passes", ((string)(null)), table12, "Given ");
#line hidden
#line 58
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then("the sell in value should decrease by 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.Then("the quality should increase by 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Backstage passes\" quality 1")]
        public virtual void BackstagePassesQuality1()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Backstage passes\" quality 1", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 62
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "SellIn",
                            "Quality"});
                table13.AddRow(new string[] {
                            "Backstage passes to a TAFKAL80ETC concert",
                            "9",
                            "2"});
#line 63
 testRunner.Given("I have an item with the name of Backstage passes", ((string)(null)), table13, "Given ");
#line hidden
#line 66
 testRunner.And("the sell in date is 10 days or less", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then("the quality should increase by 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Backstage passes\" quality 2")]
        public virtual void BackstagePassesQuality2()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Backstage passes\" quality 2", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 70
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "SellIn",
                            "Quality"});
                table14.AddRow(new string[] {
                            "Backstage passes to a TAFKAL80ETC concert",
                            "4",
                            "2"});
#line 71
 testRunner.Given("I have an item with the name of Backstage passes", ((string)(null)), table14, "Given ");
#line hidden
#line 74
 testRunner.And("the sell in date is 5 days or less", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.Then("the quality should increase by 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Backstage passes\" after the concert")]
        public virtual void BackstagePassesAfterTheConcert()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Backstage passes\" after the concert", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Quality"});
                table15.AddRow(new string[] {
                            "Backstage passes to a TAFKAL80ETC concert",
                            "2"});
#line 79
 testRunner.Given("I have an item with the name of Backstage passes", ((string)(null)), table15, "Given ");
#line hidden
#line 82
 testRunner.And("the concert has happened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.Then("the quality should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("\"Conjured\" items degrade in Quality twice as fast as normal items")]
        public virtual void ConjuredItemsDegradeInQualityTwiceAsFastAsNormalItems()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("\"Conjured\" items degrade in Quality twice as fast as normal items", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 88
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Sell in",
                            "Quality"});
                table16.AddRow(new string[] {
                            "Conjured Mana Cake",
                            "10",
                            "20"});
#line 89
 testRunner.Given("I have an item", ((string)(null)), table16, "Given ");
#line hidden
#line 92
 testRunner.When("I update quality", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.Then("the sell in value should decrease by 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.Then("the quality should decrease by 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
