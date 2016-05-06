using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateMethodPattern;
using TemplateMethodPattern.repositories;

namespace TemplateMethodPatternTests
{
    [TestClass]
    public class TemplateMethodTests
    {
        private TeaRepository _tea;
        private CoffeeRepository _coffee;
        private CoffeeWithHookRepository _coffeeWithHook;
        private TeaWithHookRepository _teaWithHook;
        private StringBuilder _teaResult;
        private StringBuilder _coffeeResult;
        private StringBuilder _coffeeWithHookYesResult;
        private StringBuilder _coffeeWithHookNoResult;
        private StringBuilder _teaWithHookYesResult;
        private StringBuilder _teaWithHookNoResult;

        [TestInitialize]
        public void Init()
        {
            _tea = new TeaRepository();
            _coffee = new CoffeeRepository();
            _coffeeWithHook = new CoffeeWithHookRepository();
            _teaWithHook = new TeaWithHookRepository();
            _teaResult = new StringBuilder();
            _coffeeResult = new StringBuilder();
            _coffeeWithHookYesResult = new StringBuilder();
            _coffeeWithHookNoResult = new StringBuilder();
            _teaWithHookYesResult = new StringBuilder();
            _teaWithHookNoResult = new StringBuilder();
        }

        [TestCleanup]
        public void Dispose()
        {
            _tea = null;
            _coffee = null;
            _coffeeWithHook = null;
            _teaWithHook = null;
            _teaResult = null;
            _coffeeResult = null;
            _coffeeWithHookYesResult = null;
            _coffeeWithHookNoResult = null;
            _teaWithHookYesResult = null;
            _teaWithHookNoResult = null;
        }

        [TestMethod]
        public void TestTea()
        {
            _teaResult.Append("Boiling water\n");
            _teaResult.Append("Steeping the tea\n");
            _teaResult.Append("Pouring into cup\n");
            _teaResult.Append("Adding lemon\n");
            Assert.AreEqual(_teaResult.ToString(), _tea.PrepareRecipe());
        }

        [TestMethod]
        public void TestCoffee()
        {
            _coffeeResult.Append("Boiling water\n");
            _coffeeResult.Append("Dripping coffee through filter\n");
            _coffeeResult.Append("Pouring into cup\n");
            _coffeeResult.Append("Adding sugar and milk\n");
            Assert.AreEqual(_coffeeResult.ToString(), _coffee.PrepareRecipe());
        }

        [TestMethod]
        public void TestCoffeeWithHook()
        {
            if (_coffeeWithHook.CustomerWantsCondiments())
            {
                _coffeeWithHookYesResult.Append("Boiling water\n");
                _coffeeWithHookYesResult.Append("Dripping coffee through filter\n");
                _coffeeWithHookYesResult.Append("Pouring into cup\n");
                _coffeeWithHookYesResult.Append("Adding sugar and milk\n");
                Assert.AreEqual(_coffeeWithHookYesResult.ToString(),
                    _coffeeWithHook.PrepareRecipe());
            }
            else
            {
                _coffeeWithHookNoResult.Append("Boiling water\n");
                _coffeeWithHookNoResult.Append("Dripping coffee through filter\n");
                _coffeeWithHookNoResult.Append("Pouring into cup\n");
                Assert.AreEqual(_coffeeWithHookNoResult.ToString(),
                    _coffeeWithHook.PrepareRecipe());
            }
        }

        [TestMethod]
        public void TestTeaWithHook()
        {
            if (_teaWithHook.CustomerWantsCondiments())
            {
                _teaWithHookYesResult.Append("Boiling water\n");
                _teaWithHookYesResult.Append("Steeping the tea\n");
                _teaWithHookYesResult.Append("Pouring into cup\n");
                _teaWithHookYesResult.Append("Adding lemon\n");
                Assert.AreEqual(_teaWithHookYesResult.ToString(),
                    _teaWithHook.PrepareRecipe());
            }
            else
            {
                _teaWithHookNoResult.Append("Boiling water\n");
                _teaWithHookNoResult.Append("Steeping the tea\n");
                _teaWithHookNoResult.Append("Pouring into cup\n");
                Assert.AreEqual(_teaWithHookNoResult.ToString(),
                    _teaWithHook.PrepareRecipe());
            }
        }
    }
}
