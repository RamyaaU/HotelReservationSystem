using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest3
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Cheapest the hotel for a given data range should return lake wood.
        /// </summary>
        [TestMethod]
        public void CheapestHotel_For_A_Given_DataRange_ShouldReturnLakeWood()
        {
            HotelService service = new HotelService();
            //Act
            HotelType hotel = service.FindCheapestHotel("2020-09-11", "2020-09-12");
            //Arrange
            HotelType expected = HotelType.LAKEWOOD;
            //Assert
            Assert.AreEqual(hotel, expected);
        }

        /// <summary>
        /// Cheapest the hotel for a given data range should return bridge wood.
        /// </summary>
        public void CheapestHotel_For_A_Given_DataRange_ShouldReturnBridgeWood()
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

