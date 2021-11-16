using TechTalk.SpecFlow;
using NUnit.Framework;
using System.IO;
using System;

namespace CrypticWizard.TextSaveFile
{
    [Binding]
    public sealed class TextSaveFileStepDefinitions
    {
        private const string fileName = "settings.txt";
        private static TextSaveFile textSaveFile = new TextSaveFile();

        public TextSaveFileStepDefinitions(ScenarioContext scenarioContext)
        {

        }

        #region ScenarioSteps

        [BeforeScenario]
        public void BeforeScenario()
        {
            if(TextSaveFile.Exists(fileName))
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

        [Given(@"I create a new text save file")]
        public void GivenICreateANewTextSaveFile()
        {
            textSaveFile = new TextSaveFile();
        }

        #endregion

        #region WhenSteps

        [When(@"I write the settings file")]
        public void WhenIWriteTheSettingsFile()
        {
            textSaveFile.Write("settings.txt");
        }

        [When(@"I read the settings file")]
        public void WhenIReadTheSettingsFile()
        {
            textSaveFile = TextSaveFile.Read(fileName);
        }

        [When(@"I add the string '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheStringWithValueToTheSettingsFile(string key, string value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the char '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheCharWithValueToTheSettingsFile(string key, char value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the datetime '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheDateTimeWithValueToTheSettingsFile(string key, DateTime value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the bool '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheBoolWithValueToTheSettingsFile(string key, bool value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the sbyte '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheSByteWithValueToTheSettingsFile(string key, sbyte value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the short '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheShortWithValueToTheSettingsFile(string key, short value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the int '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheIntWithValueToTheSettingsFile(string key, int value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the long '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheLongWithValueToTheSettingsFile(string key, long value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the byte '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheByteWithValueToTheSettingsFile(string key, byte value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the ushort '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheUShortWithValueToTheSettingsFile(string key, ushort value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the uint '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheUIntWithValueToTheSettingsFile(string key, uint value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the ulong '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheULongWithValueToTheSettingsFile(string key, ulong value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the double '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheDoubleWithValueToTheSettingsFile(string key, double value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the float '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheFloatWithValueToTheSettingsFile(string key, float value)
        {
            textSaveFile.Add(key, value);
        }

        [When(@"I add the decimal '(.*)' with value '(.*)' to the settings file")]
        public void WhenIAddTheDecimalWithValueToTheSettingsFile(string key, decimal value)
        {
            textSaveFile.Add(key, value);
        }

        #endregion

        #region ThenSteps

        [Then(@"the string '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheStringWithValueIsInTheSettingsFile(string key, string value)
        {
            Assert.True(textSaveFile.Strings.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Strings[key]);
        }

        [Then(@"the char '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheCharWithValueIsInTheSettingsFile(string key, char value)
        {
            Assert.True(textSaveFile.Chars.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Chars[key]);
        }

        [Then(@"the datetime '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDatetimeWithValueIsInTheSettingsFile(string key, DateTime value)
        {
            Assert.True(textSaveFile.DateTimes.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.DateTimes[key]);
        }

        [Then(@"the bool '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheBoolWithValueIsInTheSettingsFile(string key, bool value)
        {
            Assert.True(textSaveFile.Bools.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Bools[key]);
        }

        [Then(@"the sbyte '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheSByteWithValueIsInTheSettingsFile(string key, sbyte value)
        {
            Assert.True(textSaveFile.SBytes.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.SBytes[key]);
        }

        [Then(@"the short '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheShortWithValueIsInTheSettingsFile(string key, short value)
        {
            Assert.True(textSaveFile.Shorts.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Shorts[key]);
        }

        [Then(@"the int '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheIntWithValueIsInTheSettingsFile(string key, int value)
        {
            Assert.True(textSaveFile.Ints.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Ints[key]);
        }

        [Then(@"the long '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheLongWithValueIsInTheSettingsFile(string key, long value)
        {
            Assert.True(textSaveFile.Longs.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Longs[key]);
        }

        [Then(@"the byte '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheByteWithValueIsInTheSettingsFile(string key, byte value)
        {
            Assert.True(textSaveFile.Bytes.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Bytes[key]);
        }

        [Then(@"the ushort '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheUShortWithValueIsInTheSettingsFile(string key, ushort value)
        {
            Assert.True(textSaveFile.UShorts.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.UShorts[key]);
        }

        [Then(@"the uint '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheUIntWithValueIsInTheSettingsFile(string key, uint value)
        {
            Assert.True(textSaveFile.UInts.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.UInts[key]);
        }

        [Then(@"the ulong '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheULongWithValueIsInTheSettingsFile(string key, ulong value)
        {
            Assert.True(textSaveFile.ULongs.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.ULongs[key]);
        }

        [Then(@"the double '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDoubleWithValueIsInTheSettingsFile(string key, double value)
        {
            Assert.True(textSaveFile.Doubles.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Doubles[key]);
        }

        [Then(@"the float '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheFloatWithValueIsInTheSettingsFile(string key, float value)
        {
            Assert.True(textSaveFile.Floats.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Floats[key]);
        }

        [Then(@"the decimal '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDecimalWithValueIsInTheSettingsFile(string key, decimal value)
        {
            Assert.True(textSaveFile.Decimals.ContainsKey(key));
            Assert.AreEqual(value, textSaveFile.Decimals[key]);
        }

        #endregion
    }
}
