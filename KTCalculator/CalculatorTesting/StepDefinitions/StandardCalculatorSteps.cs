using NUnit.Framework;
using TechTalk.SpecFlow;
using Testing.Pages;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class StandardCalculatorSteps
    {
        [When("I input (.*) into calculator")]
        public void WhenInputNumber(string number)
        {
            new StandardPage().InputNumber(number);
        }

        [When("I store the displayed result to calculator memory")]
        public void WhenNumberStored()
        {
            new StandardPage().AddResultToMemory();
        }

        [When("I add (.*) to current result")]
        public void WhenAddNumber(string number)
        {
            new StandardPage().AddNumber(number);
        }

        [When("I add the number from calculator memory")]
        public void WhenAddFromMemory()
        {
            new StandardPage().AddFromMemory();
        }

        [Then("(.*) is displayed as result")]
        public void ThenNumberDisplayed(string displayedNumber)
        {
            Assert.AreEqual(displayedNumber, new StandardPage().GetResult());
        }
    }
}