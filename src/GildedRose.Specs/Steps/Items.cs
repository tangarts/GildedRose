using GildedRose.Console;
using Shouldly;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace GildedRose.Specs.Steps
{
    [Binding]
    public sealed class ItemsStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private readonly App _app = new();

        public ItemsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"I have an item")]
        [Given(@"I have an item with the name of Sulfuras")]
        [Given(@"I have an item with the name of Backstage passes")]

        public void GivenIHaveAnItem(Table table)
        {
            var oldItem = table.CreateInstance<Item>();
            var item = table.CreateInstance<Item>();

            _app.Items.Add(item);
            _scenarioContext.Set(item);
            _scenarioContext.Set(oldItem, "oldItem");
        }


        [Given(@"I have these items:")]
        public void GivenIHaveTheseItems(Table table)
        {
            _app.Items = table.CreateSet<Item>().ToList();
        }


        [Given(@"the concert has happened")]
        [Given(@"the sell in date has passed")]
        public void GivenTheSellInDateHasPassed()
        {
            var item = _scenarioContext.Get<Item>();
            item.SellIn = -1;
            _scenarioContext.Set(item);
        }

        [Given(@"the sell in date is (.*) days or less")]
        public void GivenTheSellInDateIsDaysOrLess(int p0)
        {
            var item = _scenarioContext.Get<Item>();
            item.SellIn = p0;
            _scenarioContext.Set(item);
        }

        [When(@"I update quality")]
        public void WhenIUpdateQuality()
        {
            var item = _scenarioContext.Get<Item>();
            _app.UpdateQuality();
            _scenarioContext.Set(item);
        }

        [When(@"the items are updated (.*) times?")]
        public void WhenTheItemsAreUpdatedTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _app.UpdateQuality();
            }
        }

        [Then(@"the updated items are:")]
        public void ThenTheUpdatedItemsAre(Table table)
        {
            var expectedItems = table.CreateSet<Item>().ToList();
            _app.Items.ShouldBeEquivalentTo(expectedItems);
        }


        [Then(@"the sell in value should decrease by (.*)")]
        public void WhenTheSellInValueDecreasesBy(int expectedDecrease)
        {
            var oldItem = _scenarioContext.Get<Item>("oldItem");
            var item = _scenarioContext.Get<Item>();
            var actualDifference = oldItem.SellIn - item.SellIn;
            actualDifference.ShouldBe(expectedDecrease);
        }

        [Then(@"the sell in date should be (.*)")]
        public void ThenTheSellInDateShouldBe(int expectedSellIn)
        {
            var item = _scenarioContext.Get<Item>();
            item.SellIn.ShouldBe(expectedSellIn);
        }

        [Then(@"the quality should be (.*)")]
        public void ThenTheQualityShouldBe(int expectedQuality)
        {
            var item = _scenarioContext.Get<Item>();
            item.Quality.ShouldBe(expectedQuality);
        }

        [Then(@"the quality should decrease by (.*)")]
        public void ThenTheQualityShouldDecreaseBy(int expectedDecrease)
        {
            var oldItem = _scenarioContext.Get<Item>("oldItem");
            var item = _scenarioContext.Get<Item>();
            var actualDifference = oldItem.Quality - item.Quality;
            actualDifference.ShouldBe(expectedDecrease);
        }

        [Then(@"the quality should increase by (.*)")]
        public void ThenTheQualityShouldIncreaseBy(int expectedIncrease)
        {
            var oldItem = _scenarioContext.Get<Item>("oldItem");
            var item = _scenarioContext.Get<Item>();
            var actualDifference = item.Quality - oldItem.Quality;
            actualDifference.ShouldBe(expectedIncrease);
        }

        [Given(@"it is not a Sulfuras")]
        public void GivenItIsNotASulfuras()
        {
            var item = _scenarioContext.Get<Item>();
            item.Name.ShouldNotContain("Sulfras");
        }

        [Then(@"the quality should be less than (.*)")]
        public void ThenTheQualityShouldBeLessThan(int p0)
        {
            var item = _scenarioContext.Get<Item>();
            item.Quality.ShouldBeLessThan(p0);
        }


        [Then(@"the quality should be positive")]
        public void ThenTheQualityShouldBePositive()
        {
            var item = _scenarioContext.Get<Item>();
            item.Quality.ShouldBeGreaterThanOrEqualTo(0);
        }


    }
}
