namespace SingletonPattern.Tests
{
    [TestFixture]
    public class SingletonPatternTests
    {
        [Test]
        public void GetInstance_CreateInstanceTwice_AreEqual()
        {
            // Arrange, Act
            var firstAttemptInstance = ChocolateBoiler.GetInstance();
            var secondAttemptInstance = ChocolateBoiler.GetInstance();

            // Assert
            Assert.That(firstAttemptInstance, Is.EqualTo(secondAttemptInstance));
        }
    }
}
