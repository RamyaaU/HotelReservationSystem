using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest6
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Given the date range should return the best hotel.
        /// </summary>
        [TestMethod]
        public void Given_DateRange_Should_ReturnThe_BestHotel()
        {
            HotelService service = new HotelService();
            //Act
            HotelType hotel = service.FindBestRatedHotel("2020-09-11", "2020-09-12");
            //Arrange
            HotelType expected = HotelType.RIDGEWOOD;
            //Assert
            Assert.AreEqual(hotel, expected);
        }
    }
}
