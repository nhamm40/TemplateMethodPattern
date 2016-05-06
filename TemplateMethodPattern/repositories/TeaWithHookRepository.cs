using System;
using TemplateMethodPattern.Managers;

namespace TemplateMethodPattern
{
    public class TeaWithHookRepository : CaffeineBeverageWithHook
    {
        public TeaWithHookRepository()
        { }

        public override string Brew()
        {
            return "Steeping the tea\n";
        }

        public override string AddCondiments()
        {
            return "Adding lemon\n";
        }

        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like a lemon with your tea (y/n)? ");
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
