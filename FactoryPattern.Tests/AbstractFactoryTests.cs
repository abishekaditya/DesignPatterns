namespace FactoryPattern.Tests
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        [TestCaseSource(nameof(_cheeseCases))]
        public void CreateCheese_CheeseFromIngredientsFactories_ReturnsCertainCheeseType(object ingredientsFactory, Type expected)
        {
            // Arrange, Act
            var actual = ((IIngredientsFactory)ingredientsFactory).CreateCheese();

            // Assert
            Assert.That(actual, Is.InstanceOf(expected));
        }

        [TestCaseSource(nameof(_clamCases))]
        public void CreateClam_ClamFromIngredientsFactories_ReturnsCertainClamType(object ingredientsFactory, Type expected)
        {
            // Arrange, Act
            var actual = ((IIngredientsFactory)ingredientsFactory).CreateClam();

            // Assert
            Assert.That(actual, Is.InstanceOf(expected));
        }

        [TestCaseSource(nameof(_doughCases))]
        public void CreateDough_DoughFromIngredientsFactories_ReturnsCertainDoughType(object ingredientsFactory, Type expected)
        {
            // Arrange, Act
            var actual = ((IIngredientsFactory)ingredientsFactory).CreateDough();

            // Assert
            Assert.That(actual, Is.InstanceOf(expected));
        }

        [TestCaseSource(nameof(_sauceCases))]
        public void CreateSauce_SauceFromIngredientsFactories_ReturnsCertainSauceType(object ingredientsFactory, Type expected)
        {
            // Arrange, Act
            var actual = ((IIngredientsFactory)ingredientsFactory).CreateSauce();

            // Assert
            Assert.That(actual, Is.InstanceOf(expected));
        }

        [TestCaseSource(nameof(_veggiesCases))]
        public void CreateVeggies_VeggiesFromIngredientsFactories_ReturnsCertainVeggiesSet(object ingredientsFactory, string[] expected)
        {
            // Arrange, Act
            var veggies = ((IIngredientsFactory)ingredientsFactory).CreateVeggies();
            var actual = veggies.Select(v => v.Name);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        private static readonly List<TestCaseData> _cheeseCases =
           new(new[]
           {
                new TestCaseData(new NyIngredientsFactory(), typeof(Mozarella)),
                new TestCaseData(new ChicagoIngredientsFactory(), typeof(Parmesan))
           });

        private static readonly List<TestCaseData> _clamCases =
           new(new[]
           {
                new TestCaseData(new NyIngredientsFactory(), typeof(FrozenClam)),
                new TestCaseData(new ChicagoIngredientsFactory(), typeof(FreshClam))
           });

        private static readonly List<TestCaseData> _doughCases =
           new(new[]
           {
                new TestCaseData(new NyIngredientsFactory(), typeof(ThinCrust)),
                new TestCaseData(new ChicagoIngredientsFactory(), typeof(DeepDish))
           });

        private static readonly List<TestCaseData> _sauceCases =
           new(new[]
           {
                new TestCaseData(new NyIngredientsFactory(), typeof(CherryTomato)),
                new TestCaseData(new ChicagoIngredientsFactory(), typeof(PlumTomato))
           });

        private static readonly List<TestCaseData> _veggiesCases =
           new(new[]
           {
                new TestCaseData(new NyIngredientsFactory(), new string[] { "Onions", "Bell Peppers", "Olives" }),
                new TestCaseData(new ChicagoIngredientsFactory(), new string[] { "Onions", "Cucumber", "Bell Peppers" })
           });
    }
}
