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

        [When(@"the sell in value decreases by (.*)")]
        public void WhenTheSellInValueDecreasesBy(int p0)
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
