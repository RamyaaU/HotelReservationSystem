using HotelReservationSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservationTest8
{
    [TestClass]
    public class UnitTest1
    {
        public double RATING { get; private set; }
        public double WEEKDAY_RATEForNormal { get; private set; }
        public double WEEKEND_RATEForNormal { get; private set; }
        public double WEEKDAY_RATEForReward { get; private set; }
        public double WEEKEND_RATEForReward { get; private set; }
        public object LAKEWOOD { get; private set; }
        public object NORMAL { get; private set; }

        [TestMethod]
        public void Ability_ToAdd_Ratings_To_EachHotel()
        {
            //Arrange
            double expectedWEEKDAY_RATE = 80;
            double expectedWEEKEND_RATE = 80;
            double expectedRATING = 2;
            Hotel LakeWood = new Hotel(HotelType.LAKEWOOD);
            {
                WEEKDAY_RATEForNormal = 110;
                WEEKEND_RATEForNormal = 90;
                WEEKDAY_RATEForReward = 80;
                WEEKEND_RATEForReward = 80;
            }
            Hotel BridgeWood = new Hotel(HotelType.BRIDGEWOOD);
            {
                WEEKDAY_RATEForNormal = 150;
                WEEKEND_RATEForNormal = 50;
                WEEKDAY_RATEForReward = 110;
                WEEKEND_RATEForReward = 50;
            }
            Hotel RidgeWood = new Hotel(HotelType.RIDGEWOOD);
            {
                WEEKDAY_RATEForNormal = 220;
                WEEKEND_RATEForNormal = 50;
                WEEKDAY_RATEForReward = 110;
                WEEKEND_RATEForReward = 40;
            }
        }
    }
}

