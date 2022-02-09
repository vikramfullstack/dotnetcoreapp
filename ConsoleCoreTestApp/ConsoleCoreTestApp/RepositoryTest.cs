using System;
using Xunit;

namespace ConsoleCoreTestApp
{
    public class RepositoryTest
    {
        [Fact]
        public void TestToCheckXunitFirstTestCase()
        {
            int expectedResult = 10;
            //Act
            int actualResultFromDevCode = 10;
            //Assert
            Assert.Equal(expectedResult, actualResultFromDevCode);
        }
    }
}
