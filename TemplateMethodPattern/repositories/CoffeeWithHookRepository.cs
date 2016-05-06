using System;
using TemplateMethodPattern.Managers;

namespace TemplateMethodPattern
{
    public class CoffeeWithHookRepository : CaffeineBeverageWithHook
    {
        public CoffeeWithHookRepository()
        { }

        public override string Brew()
        {
            return "Dripping coffee through filter\n";
        }

        public override string AddCondiments()
        {
            return "Adding sugar and milk\n";
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");
            var customerAnswer = Console.ReadLine();
            if (customerAnswer != null)
            {
                var lower = customerAnswer.ToLower();

                if (lower == "y")
                {
                    return true; //returns true if lower == y
                }
                return false; //returns false if lower == n
            }
            return false; //returns false if no answer
        }

    }
}
