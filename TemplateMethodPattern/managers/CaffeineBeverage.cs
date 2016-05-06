using System.Text;
using TemplateMethodPattern.managers;

namespace TemplateMethodPattern.Managers
{
    public abstract class CaffeineBeverage : ICaffeineBeverage
    {
        public string PrepareRecipe()
        {
            var sb = new StringBuilder();
            sb.Append(BoilWater());
            sb.Append(Brew());
            sb.Append(PourInCup());
            sb.Append(AddCondiments());

            return sb.ToString();
        }

        public abstract string Brew();
        public abstract string AddCondiments();

        public string BoilWater()
        {
            return "Boiling water\n";
        }

        public string PourInCup()
        {
            return "Pouring into cup\n";
        }
    }
}
