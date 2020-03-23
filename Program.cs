using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Laborator5
{
    class Program
    {
        static void Main(string[] args)
        {
            App_Start.EntityFrameworkProfilerBootstrapper.PreStart();
            ScenarioOne();
            ScenarioTwo();
            ScenarioThree();
            ScenarioFour();
            ScenarioFive();
        }

        static void ScenarioTwo()
        {
            var scenarioTwo = new ScenarioTwo();
            scenarioTwo.AddProduct();
            scenarioTwo.PrintProducts();
        }

        static void ScenarioOne()
        {
            var scenarioOne = new ScenarioOne();
            var refOne = new SelfReference()
            {
                Name = "First Ref"
            };
            var refTwo = new SelfReference()
            {
                Name = "Second Ref",
                ParentSelfReference = refOne
            };
            var refThree = new SelfReference()
            {
                Name = "Third Ref",
                ParentSelfReference = refTwo
            };
            scenarioOne.AddReference(refOne);
            scenarioOne.AddReference(refTwo);
            scenarioOne.AddReference(refThree);
            foreach (var reference in scenarioOne.ListReferences())
            {
                if (reference.ParentSelfReference != null)
                    Console.WriteLine($"Reference {reference.Name} with parent {reference.ParentSelfReference.Name}");
            }
        }

        static void ScenarioThree()
        {
            var scenarioThree = new ScenarioThree();
            scenarioThree.Add();
            scenarioThree.Print();
        }

        static void ScenarioFour()
        {
            var scenarioFour = new ScenarioFour();
            scenarioFour.Add();
            scenarioFour.Print();
        }

        static void ScenarioFive()
        {
            var scenarioFive = new ScenarioFive();
            scenarioFive.Add();
            scenarioFive.Print();
        }
    }
}

