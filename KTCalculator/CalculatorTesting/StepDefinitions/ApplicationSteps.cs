using TechTalk.SpecFlow;
using Testing.Utils;
using TestingFramework.Framework;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class ApplicationSteps
    {
        [Given("The calculator application is started")]
        public void GivenCalculatorAppStart()
        {
            ApplicationController.StartApplication(Constants.CALCULATOR_PATH);
        }
    }
}
