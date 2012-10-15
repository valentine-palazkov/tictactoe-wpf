﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TicTakToe.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Play interactive tic-tac-toe")]
    public partial class PlayInteractiveTic_Tac_ToeFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TikTacToe.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Play interactive tic-tac-toe", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should not be able to replace tic with tak")]
        public virtual void ShouldNotBeAbleToReplaceTicWithTak()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should not be able to replace tic with tak", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        "x",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 4
 testRunner.Given("board:", ((string)(null)), table1);
#line 8
 testRunner.When("try to put a tac at {0, 1}");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        "x",
                        ""});
            table2.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table2.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 9
 testRunner.Then("the board should be:", ((string)(null)), table2);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should allow tac after tic")]
        public virtual void ShouldAllowTacAfterTic()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should allow tac after tic", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        "x",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 15
 testRunner.Given("board:", ((string)(null)), table3);
#line 19
 testRunner.When("try to put a tac at {1, 1}");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        "x",
                        ""});
            table4.AddRow(new string[] {
                        "",
                        "0",
                        ""});
            table4.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 20
 testRunner.Then("the board should be:", ((string)(null)), table4);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should track move order")]
        public virtual void ShouldTrackMoveOrder()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should track move order", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        "x",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 26
 testRunner.Given("board:", ((string)(null)), table5);
#line 30
 testRunner.When("try to put a tic at {1, 1}");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "",
                        "x",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 31
 testRunner.Then("the board should be:", ((string)(null)), table6);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
