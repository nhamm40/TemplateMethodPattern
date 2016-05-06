using TemplateMethodPattern.Managers;

namespace TemplateMethodPattern.repositories
{
    public class TeaRepository : CaffeineBeverage
    {
        public TeaRepository()
        { }

        public override string Brew()
        {
            return "Steeping the tea\n";
        }

        public override string AddCondiments()
        {
            return "Adding lemon\n";
        }
    }
}
