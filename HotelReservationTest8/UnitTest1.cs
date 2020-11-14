using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest8
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Given the reward customer type and valid dates for hotel lakewood should return hotel rates.
        /// </summary>
        [TestMethod]
        public void GivenRewardCustomer_ForDateRange_ForHotelLakewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.LAKEWOOD, CustomerType.REWARD);
            //Arrange
            double expected = 160;
            //Act
            double actual = hotel.FindRate("11/09/2020", "12/09/2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given the reward customer type and valid dates for hotel bridgewood should return hotel rates.
        /// </summary>
        [TestMethod]
        public void GivenRewardCustomer_ForDateRange_ForHotelBridgewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.BRIDGEWOOD, CustomerType.REWARD);
            //Arrange
            double expected = 160;
            //Act
            double actual = hotel.FindRate("11/09/2020", "12/09/2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given the reward customer type and valid dates for hotel ridgewood should return hotel rates.
        /// </summary>
        [TestMethod]
        public void GivenRewardCustomer_ForDateRange_ForHotelRidgewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.RIDGEWOOD, CustomerType.REWARD);
            //Arrange
            double expected = 140;
            //Act
            double actual = hotel.FindRate("11/09/2020", "12/09/2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}