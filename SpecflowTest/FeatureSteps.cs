using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecflowTest
{
    [Binding]
    public class FeatureSteps
    {
        [Given(@"a table:")]
        public void GivenATable(IEnumerable<ClassWithColor> table)
        {
            var colorClass = table;
        }

        [StepArgumentTransformation]
        public IEnumerable<ClassWithColor> Transform(Table table)
        {
            return new List<ClassWithColor> { new ClassWithColor() };
        }

    }
}
