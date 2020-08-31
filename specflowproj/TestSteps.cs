using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

namespace specflowproj
{
    [Binding]
    public class TestSteps
    {
        List<string> expected = new List<string>();
        List<string> actual = new List<string>();


        [Given("I have entered num into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(Table table)
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            foreach (TableRow row in table.Rows)
            {
                foreach (string v in row.Values)
                {
                    expected.Add(v);
                    //Some comments 

                }


            }


        }

        List<int> act = new List<int>();


        [When("I press add")]
        public void WhenIPressAdd()
        {
            foreach (var l in expected)
            {
                int intl = Convert.ToInt16(l);

                intl = intl * intl;
                act.Add(intl);

            }
        }

        [Then("the result num should be on the screen")]
        public void ThenTheResultShouldBe(Table table)
        {


            foreach (TableRow row in table.Rows)
            {
                foreach (string v in row.Values)
                {
                    actual.Add(v);

                }


            }



            if (act.Count == expected.Count)
            {
                for (int i = 0; i < expected.Count; i++)
                {
                    Assert.AreEqual(Convert.ToInt16(actual[i]), act[i]);

                }
            }

        }
    }
}
