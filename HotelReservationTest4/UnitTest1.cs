using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest4
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Gets the rating.
        /// </summary>
        /// <value>
        /// The rating.
        /// </value>
        public double RATING { get; private set; }

        [TestMethod]
        public void AbilityToAdd_Ratings_To_EachHotel()
        {
            //Arrange
            double expectedRATING = 2;
            //Act
            Hotel LakeWood = new Hotel(HotelType.LAKEWOOD);
            { RATING = 3; }
            Hotel BridgeWood = new Hotel(HotelType.BRIDGEWOOD);
            { RATING = 4; }
            Hotel RidgeWood = new Hotel(HotelType.RIDGEWOOD);
            { RATING = 2; }

            //Act
            double actualRating = (double) HotelType.RIDGEWOOD;
            //Assert
            Assert.AreEqual(expectedRATING, actualRating);
        }
    }
}
