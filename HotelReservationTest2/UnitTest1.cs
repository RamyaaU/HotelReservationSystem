using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest2
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Gets the weekday rate.
        /// </summary>
        /// <value>
        /// The weekday rate.
        /// </value>
        public int WEEKDAY_RATE { get; private set; }

        /// <summary>
        /// Gets the weekend rate.
        /// </summary>
        /// <value>
        /// The weekend rate.
        /// </value>
        public int WEEKEND_RATE { get; private set; }

        /// <summary>
        /// Abilities to add weekday and weekend rates for each hotel.
        /// </summary>
        [TestMethod]
        public void AbilityToAdd_WeekdayAndWeekend_Rates_ForEachHotel()
        {
            //Arrange
            int expectedWeekDayRate = 110;
            int expectedWeekendRate = 90;

            //Act
            Hotel LakeWood = new Hotel(HotelType.LAKEWOOD);
            { WEEKDAY_RATE = 110; WEEKEND_RATE = 90; }
            Hotel BridgeWood = new Hotel(HotelType.BRIDGEWOOD);
            { WEEKDAY_RATE = 150; WEEKEND_RATE = 50; }
            Hotel RidgeWood = new Hotel(HotelType.RIDGEWOOD);
            { WEEKDAY_RATE = 220; WEEKEND_RATE = 150; }

            //Assert
            Assert.AreEqual(expectedWeekDayRate, LakeWood.WEEKDAY_RATE);
            Assert.AreEqual(expectedWeekendRate, LakeWood.WEEKEND_RATE);
        }
    }
}



