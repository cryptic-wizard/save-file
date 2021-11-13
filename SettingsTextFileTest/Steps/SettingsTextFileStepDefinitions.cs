using TechTalk.SpecFlow;
using SettingsFile;
using NUnit.Framework;

namespace SettingsTextFileTest.Steps
{
    [Binding]
    public sealed class SettingsTextFileStepDefinitions
    {
        private static SettingsTextFile settingsTextFile = new SettingsTextFile();

        public SettingsTextFileStepDefinitions(ScenarioContext scenarioContext)
        {

        }

        #region ScenarioSteps

        [BeforeScenario]
        public void BeforeScenario()
        {
            settingsTextFile = null;
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }

        #endregion

        #region GivenSteps

        [Given(@"I create a new settings file")]
        public void GivenICreateANewSettingsFile()
        {
            settingsTextFile = new SettingsTextFile();
        }

        #endregion

        #region WhenSteps

        [When(@"I write the settings file")]
        public void WhenIWriteTheSettingsFile()
        {
            settingsTextFile.Write("settings.txt");
        }

        [When(@"I read the settings file")]
        public void WhenIReadTheSettingsFile()
        {
            settingsTextFile = SettingsTextFile.Read("settings.txt");
        }

        [When(@"I add the string '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheStringWithValueToTheSettingsFile(string key, string value)
        {
            settingsTextFile.Add(key, value);
        }

        #endregion

        #region ThenSteps

        [Then(@"the string '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheStringWithValueIsInTheSettingsFile(string key, string value)
        {
            Assert.True(settingsTextFile.Strings.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Strings[key]);
        }

        #endregion
    }
}
