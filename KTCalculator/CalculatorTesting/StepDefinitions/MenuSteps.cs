using CalculatorTesting.Areas;
using TechTalk.SpecFlow;

namespace Testing.StepDefinitions
{
    [Binding]
    public sealed class MenuSteps
    {
        [When("I select (.*) calculator view")]
        public void WhenViewSelected(string view)
        {
            var page = new ContextMenu();
            page.OpenView();
            page.SelectViewItem(view);
        }

        [Then("(.*) calculator view is selected")]
        public void ThenViewSelected()
        {

        }
    }
}