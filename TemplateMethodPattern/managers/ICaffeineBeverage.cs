namespace TemplateMethodPattern.managers
{
    public interface ICaffeineBeverage
    {
        string PrepareRecipe();
        string Brew();
        string AddCondiments();
        string BoilWater();
        string PourInCup();
    }
}
