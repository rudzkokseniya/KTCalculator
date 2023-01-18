using TechTalk.SpecFlow;
using Testing.Pages;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class ScientificCalculatorSteps
    {
        [When("I square the result")]
        public void WhenSquareResult()
        {
            new ScientificPage().SquareResult();
        }
    }
}