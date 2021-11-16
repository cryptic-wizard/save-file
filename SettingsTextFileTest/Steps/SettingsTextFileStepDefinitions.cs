using TechTalk.SpecFlow;
using SettingsFile;
using NUnit.Framework;
using System.IO;
using System;

namespace SettingsTextFileTest.Steps
{
    [Binding]
    public sealed class SettingsTextFileStepDefinitions
    {
        private const string fileName = "settings.txt";
        private static SettingsTextFile settingsTextFile = new SettingsTextFile();

        public SettingsTextFileStepDefinitions(ScenarioContext scenarioContext)
        {

        }

        #region ScenarioSteps

        [BeforeScenario]
        public void BeforeScenario()
        {
            if(SettingsTextFile.Exists(fileName))
            {
                File.Delete(fileName);
            }
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
            settingsTextFile = SettingsTextFile.Read(fileName);
        }

        [When(@"I add the string '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheStringWithValueToTheSettingsFile(string key, string value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the char '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheCharWithValueToTheSettingsFile(string key, char value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the datetime '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheDateTimeWithValueToTheSettingsFile(string key, DateTime value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the bool '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheBoolWithValueToTheSettingsFile(string key, bool value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the sbyte '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheSByteWithValueToTheSettingsFile(string key, sbyte value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the short '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheShortWithValueToTheSettingsFile(string key, short value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the int '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheIntWithValueToTheSettingsFile(string key, int value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the long '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheLongWithValueToTheSettingsFile(string key, long value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the byte '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheByteWithValueToTheSettingsFile(string key, byte value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the ushort '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheUShortWithValueToTheSettingsFile(string key, ushort value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the uint '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheUIntWithValueToTheSettingsFile(string key, uint value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the ulong '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheULongWithValueToTheSettingsFile(string key, ulong value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the double '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheDoubleWithValueToTheSettingsFile(string key, double value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the float '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheFloatWithValueToTheSettingsFile(string key, float value)
        {
            settingsTextFile.Add(key, value);
        }

        [When(@"I add the decimal '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheDecimalWithValueToTheSettingsFile(string key, decimal value)
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

        [Then(@"the char '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheCharWithValueIsInTheSettingsFile(string key, char value)
        {
            Assert.True(settingsTextFile.Chars.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Chars[key]);
        }

        [Then(@"the datetime '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDatetimeWithValueIsInTheSettingsFile(string key, DateTime value)
        {
            Assert.True(settingsTextFile.DateTimes.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.DateTimes[key]);
        }

        [Then(@"the bool '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheBoolWithValueIsInTheSettingsFile(string key, bool value)
        {
            Assert.True(settingsTextFile.Bools.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Bools[key]);
        }

        [Then(@"the sbyte '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheSByteWithValueIsInTheSettingsFile(string key, sbyte value)
        {
            Assert.True(settingsTextFile.SBytes.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.SBytes[key]);
        }

        [Then(@"the short '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheShortWithValueIsInTheSettingsFile(string key, short value)
        {
            Assert.True(settingsTextFile.Shorts.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Shorts[key]);
        }

        [Then(@"the int '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheIntWithValueIsInTheSettingsFile(string key, int value)
        {
            Assert.True(settingsTextFile.Ints.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Ints[key]);
        }

        [Then(@"the long '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheLongWithValueIsInTheSettingsFile(string key, long value)
        {
            Assert.True(settingsTextFile.Longs.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Longs[key]);
        }

        [Then(@"the byte '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheByteWithValueIsInTheSettingsFile(string key, byte value)
        {
            Assert.True(settingsTextFile.Bytes.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Bytes[key]);
        }

        [Then(@"the ushort '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheUShortWithValueIsInTheSettingsFile(string key, ushort value)
        {
            Assert.True(settingsTextFile.UShorts.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.UShorts[key]);
        }

        [Then(@"the uint '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheUIntWithValueIsInTheSettingsFile(string key, uint value)
        {
            Assert.True(settingsTextFile.UInts.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.UInts[key]);
        }

        [Then(@"the ulong '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheULongWithValueIsInTheSettingsFile(string key, ulong value)
        {
            Assert.True(settingsTextFile.ULongs.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.ULongs[key]);
        }

        [Then(@"the double '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDoubleWithValueIsInTheSettingsFile(string key, double value)
        {
            Assert.True(settingsTextFile.Doubles.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Doubles[key]);
        }

        [Then(@"the float '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheFloatWithValueIsInTheSettingsFile(string key, float value)
        {
            Assert.True(settingsTextFile.Floats.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Floats[key]);
        }

        [Then(@"the decimal '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDecimalWithValueIsInTheSettingsFile(string key, decimal value)
        {
            Assert.True(settingsTextFile.Decimals.ContainsKey(key));
            Assert.AreEqual(value, settingsTextFile.Decimals[key]);
        }

        #endregion
    }
}
