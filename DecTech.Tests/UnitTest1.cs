using DecTech.Models;
using Xunit;

namespace DecTech.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Bread_Basic_Test()
        {
            Bread bread = new Bread(1, 1.0M, null);
            
            var actual = bread.GetOffers();
            Assert.Equal(1.0M, actual);
        }

        [Fact]
        public void Butter_Basic_Test()
        {
            Butter butter= new Butter(1, 1.0M);

            var actual = butter.GetOffers();
            Assert.Equal(1.0M, actual);
        }
        [Fact]
        public void Milk_Basic_Test()
        {
            Milk milk = new Milk(1, 1.0M);

            var actual = milk.GetOffers();
            Assert.Equal(1.0M, actual);
        }

        [Fact]
        public void Check_Three_Butter_Zero_Bread_Offer_Test()
        {
            Butter butter = new Butter(3, 0.80M);
            Bread bread = new Bread(0, 1.00M, butter);

            var actual = bread.GetOffers() + butter.GetOffers();
            Assert.Equal(2.40M, actual);
        }

        [Fact]
        public void Check_Four_Butter_Two_Bread_Offer_Test()
        {
            Butter butter = new Butter(4, 0.80M);
            Bread bread = new Bread(2, 1.00M, butter);

            var actual = bread.GetOffers() + butter.GetOffers();
            Assert.Equal(4.20M, actual);
        }


        [Fact]
        public void Scenario_1_Test()
        {
            Butter butter = new Butter(1, 0.80M);
            Bread bread = new Bread(1, 1.00M, butter);
            Milk milk = new Milk(1, 1.15M);

            var actual = butter.GetOffers() + bread.GetOffers() + milk.GetOffers();
            Assert.Equal(2.95M, actual);
        }
        [Fact]
        public void Scenario_2_Test()
        {
            Butter butter = new Butter(2, 0.80M);
            Bread bread = new Bread(2, 1.00M, butter);
            Milk milk = new Milk(0, 1.15M);

            var actual = butter.GetOffers() + bread.GetOffers() + milk.GetOffers();
            Assert.Equal(3.10M, actual);
        }

        [Fact]
        public void Scenario_3_Test()
        {
            Butter butter = new Butter(0, 0.80M);
            Bread bread = new Bread(0, 1.00M, butter);
            Milk milk = new Milk(4, 1.15M);

            var actual = butter.GetOffers() + bread.GetOffers() + milk.GetOffers();
            Assert.Equal(3.45M, actual);
        }

        [Fact]
        public void Scenario_4_Test()
        {
            Butter butter = new Butter(2, 0.80M);
            Bread bread = new Bread(1, 1.00M, butter);
            Milk milk = new Milk(8, 1.15M);

            var actual = butter.GetOffers() + bread.GetOffers() + milk.GetOffers();
            Assert.Equal(9.00M, actual);
        }



    }
}
