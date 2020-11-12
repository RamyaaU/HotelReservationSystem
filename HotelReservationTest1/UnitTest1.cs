using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the date range should return cheapest hotel.
        /// </summary>
        [TestMethod]
        public void Given_DateRange_Should_Return_CheapestHotel()
        {
            HotelService service = new HotelService();
            //Act
            HotelType hotel = service.FindCheapestHotel("2020-09-10", "2020-09-11");
            //Arrange
            HotelType expected = HotelType.LAKEWOOD;
            //Assert
            Assert.AreEqual(hotel, expected);
        }
    }
}
