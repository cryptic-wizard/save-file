using TechTalk.SpecFlow;
using NUnit.Framework;
using System.IO;
using System;

namespace CrypticWizard.SaveFile
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
            if (TextSaveFile.Exists(fileName))
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
            string entry = textSaveFile.GetString(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the char '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheCharWithValueIsInTheSettingsFile(string key, char value)
        {
            char? entry = textSaveFile.GetChar(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the datetime '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDatetimeWithValueIsInTheSettingsFile(string key, DateTime value)
        {
            DateTime? entry = textSaveFile.GetDateTime(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the bool '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheBoolWithValueIsInTheSettingsFile(string key, bool value)
        {
            bool? entry = textSaveFile.GetBool(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the sbyte '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheSByteWithValueIsInTheSettingsFile(string key, sbyte value)
        {
            sbyte? entry = textSaveFile.GetSByte(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the short '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheShortWithValueIsInTheSettingsFile(string key, short value)
        {
            short? entry = textSaveFile.GetShort(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the int '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheIntWithValueIsInTheSettingsFile(string key, int value)
        {
            int? entry = textSaveFile.GetInt(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the long '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheLongWithValueIsInTheSettingsFile(string key, long value)
        {
            long? entry = textSaveFile.GetLong(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the byte '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheByteWithValueIsInTheSettingsFile(string key, byte value)
        {
            byte? entry = textSaveFile.GetByte(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the ushort '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheUShortWithValueIsInTheSettingsFile(string key, ushort value)
        {
            ushort? entry = textSaveFile.GetUShort(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the uint '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheUIntWithValueIsInTheSettingsFile(string key, uint value)
        {
            uint? entry = textSaveFile.GetUInt(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the ulong '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheULongWithValueIsInTheSettingsFile(string key, ulong value)
        {
            ulong? entry = textSaveFile.GetULong(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the double '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDoubleWithValueIsInTheSettingsFile(string key, double value)
        {
            double? entry = textSaveFile.GetDouble(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the float '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheFloatWithValueIsInTheSettingsFile(string key, float value)
        {
            float? entry = textSaveFile.GetFloat(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        [Then(@"the decimal '(.*)' with value '(.*)' is in the settings file")]
        public void ThenTheDecimalWithValueIsInTheSettingsFile(string key, decimal value)
        {
            decimal? entry = textSaveFile.GetDecimal(key);
            Assert.IsNotNull(entry);
            Assert.AreEqual(value, entry);
        }

        #endregion
    }
}
