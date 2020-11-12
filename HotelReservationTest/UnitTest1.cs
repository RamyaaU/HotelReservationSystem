using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// This test case is checking whether add hotel test method is working or not
        /// </summary>
        [TestMethod]
        public void AddHotelTest()
        {
            //Act
            Hotel hotel = new Hotel(HotelType.RIDGEWOOD);
            //Arrange
            double expectedRate = 220;
            //Assert
            Assert.AreEqual(expectedRate, hotel.RATE);
        }
    }
}
