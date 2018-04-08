using DecTech.Models;
using Xunit;

namespace DecTech.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Bread_Basic_Test()
        {
            Butter butter = new Butter(1, 1.0M);
            Bread bread = new Bread(1, 0.80M, butter);
            
            var actual = bread.GetOffers();
            Assert.Equal(0.80M, actual);
        }
    }
}
