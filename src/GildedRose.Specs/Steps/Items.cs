using TechTalk.SpecFlow;

namespace GildedRose.Specs.Steps
{
    [Binding]
    public sealed class ItemsStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;

        public ItemsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I have an item with the name of ""(.*)""")]
        public void GivenIHaveAnItemWithTheNameOf(string p0)
        {
            _scenarioContext.Pending();
        }

        [Given(@"I have an item")]
        public void GivenIHaveAnItem()
        {
            _scenarioContext.Pending();
        }

        [Given(@"the sell in date has passed")]
        public void GivenTheSellInDateHasPassed()
        {
            _scenarioContext.Pending();
        }

        [Given(@"the sell in date is (.*) days or less")]
        public void GivenTheSellInDateIsDaysOrLess(int p0)
        {
            _scenarioContext.Pending();
        }


        [When(@"I update quality")]
        public void WhenIUpdateQuality()
        {
            _scenarioContext.Pending();
        }

        [Then(@"the sell in value should decrease by (.*)")]
        public void WhenTheSellInValueDecreasesBy(int p0)
        {
            _scenarioContext.Pending();
        }


        [Then(@"the quality should decrease by (.*)")]
        public void ThenTheQualityShouldDecreaseBy(int p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"the quality should increase by (.*)")]
        public void ThenTheQualityShouldIncreaseBy(int p0)
        {
            _scenarioContext.Pending();
        }


        [Then(@"the quality should be (.*)")]
        public void ThenTheQualityShouldBe(int p0)
        {
            _scenarioContext.Pending();
        }


    }
}
