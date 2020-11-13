using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest8
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the regular customer type and valid dates for hotel lakewood should return hotel rates.
        /// </summary>
        [TestMethod]
        public void GivenRegularCustomerTypeAndValidDatesForHotelLakewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.LAKEWOOD, CustomerType.NORMAL);
            //Arrange
            double expected = 200;
            //Act
            double actual = hotel.FindRate("11-09-2020", "12-09-2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given the regular customer type and valid dates for hotel bridgewood should return hotel rates.
        /// </summary>
        [TestMethod]
        public void GivenRegularCustomerTypeAndValidDatesForHotelBridgewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.BRIDGEWOOD, CustomerType.NORMAL);
            //Arrange
            double expected = 200;
            //Act
            double actual = hotel.FindRate("11-09-2020", "12-09-2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given the regular customer type and valid dates for hotel ridgewood should return hotel rates.
        /// </summary>
        [TestMethod]
        public void GivenRegularCustomerTypeAndValidDatesForHotelRidgewood_ShouldReturn_HotelRates()
        {
            Hotel hotel = new Hotel(HotelType.RIDGEWOOD, CustomerType.NORMAL);
            //Arrange
            double expected = 370;
            //Act
            double actual = hotel.FindRate("11-09-2020", "12-09-2020");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
