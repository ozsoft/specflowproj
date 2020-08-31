using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;

//git status : gives you the status of the source code compared to the github rep
//git add . : this adds the modified files to now be able to be committed
//git commit -m "comment on checkin" : commenting on the commit
//git push https://github.com/ozsoft/specflowproj.git : push (forge, merge) commits to rep


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


            foreach (TableRow row in table.Rows)
            {
                foreach (string v in row.Values)
                {
                    expected.Add(v);
                    //Some comments
                    //new branch

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
