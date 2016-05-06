using TemplateMethodPattern.Managers;

namespace TemplateMethodPattern
{
    public class CoffeeRepository : CaffeineBeverage
    {
        public CoffeeRepository()
        { }

        public override string Brew()
        {
            return "Dripping coffee through filter\n";
        }

        public override string AddCondiments()
        {
            return "Adding sugar and milk\n";
        }
    }
}
