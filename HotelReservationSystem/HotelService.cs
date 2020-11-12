using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelService
    {
        /// <summary>
        /// Finds the cheapest hotel.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public HotelType FindCheapestHotel(string startDate, string endDate)
        {
            //initialization
            Hotel LakeWood = new Hotel(HotelType.LAKEWOOD);
            Hotel BridgeWood = new Hotel(HotelType.BRIDGEWOOD);
            Hotel RidgeWood = new Hotel(HotelType.RIDGEWOOD);

            //calculating rate of each Hotel between the given dates
            double LakeWoodRate = LakeWood.FindTotalCost(startDate, endDate);
            double BridgeWoodRate = BridgeWood.FindTotalCost(startDate, endDate);
            double RidgeWoodRate = RidgeWood.FindTotalCost(startDate, endDate);
            
            if (LakeWoodRate < BridgeWoodRate && LakeWoodRate < RidgeWoodRate)
            {
                return HotelType.LAKEWOOD;
            }
            else if (BridgeWoodRate < LakeWoodRate && BridgeWoodRate < RidgeWoodRate)
            {
                return HotelType.BRIDGEWOOD;
            }
            else
            {
                return HotelType.RIDGEWOOD;
            }
        }
    }
}