using NUnit.Framework;

namespace IntegrationTests
{
    public class SanityTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description = "Create and Read Precondition")]
        public void CreateAndReadPrecondition()
        {
            Assert.Pass();
        }

        [Test(Description = "Create and Read Step")]
        public void CreateAndReadStep()
        {
            Assert.AreEqual("Description A", "?????????? ???",
                "Migration Service failed to read the expected step description");
        }

        [Test(Description = "Create and Read Change History")]
        public void CreateAndReadChangeHistory()
        {
            Assert.Pass();
        }

        [Test(Description = "Create and Read Child-Step")]
        public void CreateAndReadChildStepTest()
        {
            Assert.Pass();
        }

    }
}