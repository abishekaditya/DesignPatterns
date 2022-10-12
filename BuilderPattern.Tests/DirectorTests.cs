using Moq;

namespace BuilderPattern.Tests
{
    [TestFixture]
    public class DirectorTests
    {
        private Cook _cook;
        private Mock<IBuilder> _builder;

        [OneTimeSetUp]
        public void SetUp()
        {
            _builder = new Mock<IBuilder>();
            _cook = new Cook(_builder.Object);
        }

        [Test]
        public void ChangeBuilder_DeclareMyHamburgerBuilder_ReturnsHamburgerByWifesHamburgerBuilder()
        {
            // Arrange, Act
            _cook.ChangeBuilder(new WifesHamburgerBuilder());

            // Assert
            _builder.Verify(s => s.Reset());
        }

        [Test]
        public void Build_TwoBuilderCases_ReturnsFilledInstanceOfHamburgerClass()
        {
            // Arrange, Act
            var actual = _cook.Build();

            // Assert
            _builder.Verify(s => s.AddIngredients());
            _builder.Verify(s => s.AddShape());
            _builder.Verify(s => s.AddSize());
            _builder.Verify(s => s.Build());
        }
    }
}
