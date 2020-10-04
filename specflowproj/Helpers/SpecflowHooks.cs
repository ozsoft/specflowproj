
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using specflowproj.Tests;
using OpenQA.Selenium.Chrome;
using System;

namespace specflowproj
{
    [Binding]
    public class SpecflowHooks
    {
        /*
         * Specflow available hooks:
         
        [BeforeTestRun]

        [BeforeFeature]

        [BeforeScenario]

        [BeforeScenarioBlock]

        [BeforeStep]

        [AfterStep]

        [AfterScenarioBlock]

        [AfterScenario]

        [AfterFeature]

        [AfterTestRun]
        */

        [BeforeTestRun(Order = 1)]
        public static void Setup()
        {
            Console.WriteLine("test started");

        }


        [AfterTestRun]
        public static int AfterTestRun()
        {
            Console.WriteLine("test completed");

            //System.ArgumentException: The type 'System.Void' may not be used as a type argument
            //error when method returns void
            return -1;
        }


        [BeforeScenario("timesheet", "browser: chrome")]
        public static int BeforeScenarioRun()
        {
            Console.WriteLine("timeshhet before scenario run");

            return -1;

        }

        [AfterScenario("timesheet", "browser: chrome")]
        public static int AfterScenarioRun()
        {
            Console.WriteLine("timeshhet after scenario run");

            return -1;

        }


        public SpecflowHooks()
        {
        }
    }
}
