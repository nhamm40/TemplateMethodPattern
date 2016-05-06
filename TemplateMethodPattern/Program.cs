using System;
using TemplateMethodPattern.Managers;
using TemplateMethodPattern.repositories;

namespace TemplateMethodPattern
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("The process to prepare coffee is: ");
            CaffeineBeverage coffee = new CoffeeRepository();
            Console.WriteLine(coffee.PrepareRecipe());

            Console.WriteLine("The process to prepare tea is: ");
            CaffeineBeverage tea = new TeaRepository();
            Console.WriteLine(tea.PrepareRecipe());

            Console.WriteLine("The process to prepare coffee with a hook is: ");
            CaffeineBeverageWithHook coffeeWithHook = new CoffeeWithHookRepository();
            Console.WriteLine(coffeeWithHook.PrepareRecipe());

            Console.WriteLine("The process to prepare tea with a hook is: ");
            CaffeineBeverageWithHook teaWithHook = new TeaWithHookRepository();
            Console.WriteLine(teaWithHook.PrepareRecipe());

            Console.ReadKey();
        }
    }
}
