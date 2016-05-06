namespace TemplateMethodPattern.managers
{
    public interface ICaffeineBeverageWithHook
    {
        string PrepareRecipe();
        string Brew();
        string AddCondiments();
        string BoilWater();
        string PourInCup();
        bool CustomerWantsCondiments();
    }
}
