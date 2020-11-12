using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest5
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Givens the date range find the cheapest best rated hotel.
        /// </summary>
        [TestMethod]
        public void Given_DateRange_FindThe_CheapestBestRated_Hotel()
        {
            HotelService service = new HotelService();
            //Act
            HotelType hotel = service.FindCheapestHotel("2020-09-11", "2020-09-12");
            //Arrange
            HotelType expected = HotelType.BRIDGEWOOD;
            //Assert
            Assert.AreEqual(hotel, expected);
        }
    }
}