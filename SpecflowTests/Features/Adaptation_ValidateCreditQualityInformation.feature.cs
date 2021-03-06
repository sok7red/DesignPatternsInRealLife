// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecflowTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EconomicEntityAdaptation_CheckStatusFor_CreditQualityInfo")]
    public partial class EconomicEntityAdaptation_CheckStatusFor_CreditQualityInfoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Adaptation_ValidateCreditQualityInformation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "EconomicEntityAdaptation_CheckStatusFor_CreditQualityInfo", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Economic Entity Adaptation : Validate CreditQualityInformation")]
        [NUnit.Framework.CategoryAttribute("Adaptation_CreditQualityInfo")]
        public virtual void EconomicEntityAdaptationValidateCreditQualityInformation()
        {
            string[] tagsOfScenario = new string[] {
                    "Adaptation_CreditQualityInfo"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Economic Entity Adaptation : Validate CreditQualityInformation", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "CounterpartyId",
                            "CounterpartyName",
                            "NettingGroupName",
                            "RemainingMaturity",
                            "EffectiveMaturity",
                            "ExposureAtDefault",
                            "CreditRating"});
                table1.AddRow(new string[] {
                            "123",
                            "Public Limited Company",
                            "Collateral2",
                            "6.26",
                            "723186.4",
                            "999999",
                            "1"});
                table1.AddRow(new string[] {
                            "123",
                            "Public Limited Company",
                            "Collateral1",
                            "8.32",
                            "502224.1",
                            "55000",
                            "1"});
                table1.AddRow(new string[] {
                            "321",
                            "Investment Bank",
                            "Collateral3",
                            "1.47",
                            "27000",
                            "245110",
                            "2"});
                table1.AddRow(new string[] {
                            "456",
                            "Public PLC",
                            "Collateral4",
                            "10.28",
                            "255000",
                            "245110",
                            "2"});
#line 5
 testRunner.Given("an object of data to be adapted", ((string)(null)), table1, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "CounterpartyName",
                            "NettingGroupName"});
                table2.AddRow(new string[] {
                            "Public Limited Company",
                            "Collateral2"});
                table2.AddRow(new string[] {
                            "Investment Bank",
                            "Collateral1"});
#line 11
 testRunner.And("a list of eligible counterparties for the Adaptation", ((string)(null)), table2, "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Rating",
                            "CreditQuality",
                            "RiskWeightCreditQuality",
                            "RiskWeight"});
                table3.AddRow(new string[] {
                            "1",
                            "1",
                            "1",
                            "0.7"});
                table3.AddRow(new string[] {
                            "2",
                            "2",
                            "2",
                            "0.8"});
#line 15
 testRunner.And("I am provided with the required Credit Quality information", ((string)(null)), table3, "And ");
#line hidden
#line 19
 testRunner.When("I create the Economic Entity object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "CreditRating"});
                table4.AddRow(new string[] {
                            "1"});
                table4.AddRow(new string[] {
                            "1"});
                table4.AddRow(new string[] {
                            "2"});
                table4.AddRow(new string[] {
                            "2"});
#line 20
 testRunner.Then("I should be able to validate the CreditQualityInformation for each trade", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
