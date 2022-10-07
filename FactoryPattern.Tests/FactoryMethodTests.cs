namespace FactoryPattern.Tests
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [TestCase(typeof(ClamPizza), "Clam")]
        [TestCase(typeof(CheesePizza), "Cheese")]
        [TestCase(typeof(VeggiePizza), "Veggie")]
        public void Create_PizzaFromNyPizzaFactory_ReturnsPizzaOfCertainType(Type expected, string pizzaType)
        {
            // Arrange
            var nyPizzaFactory = new NyPizzaFactory();

            // Act
            var actual = nyPizzaFactory.Order(pizzaType);

            // Assert
            Assert.That(actual, Is.InstanceOf(expected));
        }

        [TestCase(typeof(ClamPizza), "Clam")]
        [TestCase(typeof(CheesePizza), "Cheese")]
        [TestCase(typeof(VeggiePizza), "Veggie")]
        public void Create_PizzaFromChicagoPizzaFactory_ReturnsPizzaOfCertainType(Type expected, string pizzaType)
        {
            // Arrange
            var chicagoPizzaFactory = new ChicagoPizzaFactory();

            // Act
            var actual = chicagoPizzaFactory.Order(pizzaType);

            // Assert
            Assert.That(actual, Is.InstanceOf(expected));
        }
    }
}
