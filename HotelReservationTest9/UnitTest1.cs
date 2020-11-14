using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenRewardCustomerTypeAndValidDatesForHotelBridgewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.BRIDGEWOOD, CustomerType.REWARD);
            //Arrange
            double expected = 160;
            //Act
            double actual = hotel.FindRate("11/09/2020", "12/09/2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void GivenRewardCustomerTypeAndValidDatesForHotelRidgewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.RIDGEWOOD, CustomerType.REWARD);
            //Arrange
            double expected = 140;
            //Act
            double actual = hotel.FindRate("11/09/2020", "12/09/2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenRewardCustomerTypeAndValidDatesForHotelLakewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.LAKEWOOD, CustomerType.REWARD);
            //Arrange
            double expected = 160;
            //Act
            double actual = hotel.FindRate("11/09/2020", "12/09/2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
