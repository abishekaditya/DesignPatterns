namespace BuilderPattern.Tests
{
    [TestFixture]
    public class BuilderTests
    {
        [TestCaseSource(nameof(_sizeCases))]
        public void AddSize_TwoBuilderCases_ReturnsInstanceOfHamburgerClassWithFilledSize(IBuilder builder, int expected)
        {
            // Arrange, Act
            builder.Reset();
            builder.AddSize();
            var hamburger = builder.Build();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(hamburger.Size, Is.EqualTo(expected));
                Assert.That(hamburger.Shape, Is.Null);
                Assert.That(hamburger.Ingredients, Is.Null);
            });
        }

        [TestCaseSource(nameof(_shapeCases))]
        public void AddShape_TwoBuilderCases_ReturnsInstanceOfHamburgerClassWithFilledShape(IBuilder builder, string expected)
        {
            // Arrange, Act
            builder.Reset();
            builder.AddShape();
            var hamburger = builder.Build();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(hamburger.Size, Is.Zero);
                Assert.That(hamburger.Shape, Is.EqualTo(expected));
                Assert.That(hamburger.Ingredients, Is.Null);
            });
        }

        [TestCaseSource(nameof(_ingredientsCases))]
        public void AddIngredients_TwoBuilderCases_ReturnsInstanceOfHamburgerClassWithFilledIngredients(IBuilder builder, string[] expected)
        {
            // Arrange, Act
            builder.Reset();
            builder.AddIngredients();
            var hamburger = builder.Build();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(hamburger.Size, Is.Zero);
                Assert.That(hamburger.Shape, Is.Null);
                Assert.That(hamburger.Ingredients, Is.EquivalentTo(expected));
            });
        }

        private static readonly List<TestCaseData> _sizeCases =
           new(new[]
           {
                new TestCaseData(new MyHamburgerBuilder(), 10),
                new TestCaseData(new WifesHamburgerBuilder(), 6)
           });

        private static readonly List<TestCaseData> _shapeCases =
           new(new[]
           {
                new TestCaseData(new MyHamburgerBuilder(), "Kite"),
                new TestCaseData(new WifesHamburgerBuilder(), "Cuboid")
           });

        private static readonly List<TestCaseData> _ingredientsCases =
           new(new[]
           {
                new TestCaseData(new MyHamburgerBuilder(), new string[] { "Bread", "Meat", "Tomato", "Salad", "Mayonnaise" }),
                new TestCaseData(new WifesHamburgerBuilder(), new string[] { "Bread", "Salad" })
           });
    }
}
