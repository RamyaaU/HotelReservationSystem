using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelService
    {
        /// <summary>
        /// Finds the cheap hotel.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="customerType">Type of the customer.</param>
        public void FindCheapHotel(string startDate, string endDate, CustomerType customerType)
        {
            //initialization
            HotelType hotelType = HotelType.LAKEWOOD;
            //parameterized constructor
            Hotel lakewood = new Hotel(hotelType, customerType);
            //finds rate of hotel from given startdate to enddate
            double rateLakewood = lakewood.FindRate(startDate, endDate);
            //initialization
            hotelType = HotelType.BRIDGEWOOD;
            //parameterized constructor
            Hotel bridgewood = new Hotel(hotelType, customerType);
            //finds rate of hotel from given startdate to enddate
            double rateBridgewood = bridgewood.FindRate(startDate, endDate);
            //initialization
            hotelType = HotelType.RIDGEWOOD;
            //parameterized constructor
            Hotel ridgewood = new Hotel(hotelType, customerType);
            //finds rate of hotel from given startdate to enddate
            double rateRidgewood = ridgewood.FindRate(startDate, endDate);
            if (rateLakewood < rateBridgewood && rateLakewood < rateRidgewood)
            {
                Console.WriteLine("Best hotel for your stay is " + HotelType.LAKEWOOD + ", Rating: " + lakewood.RATING + ", Cost of stay: " + rateLakewood);
            }
            if ((rateBridgewood < rateLakewood && rateBridgewood < rateRidgewood) || (rateLakewood == rateBridgewood && rateBridgewood < rateRidgewood))
            {
                Console.WriteLine("Best hotel for your stay is " + HotelType.BRIDGEWOOD + ", Rating: " + bridgewood.RATING + ", Cost of stay: " + rateBridgewood);
            }
            if ((rateRidgewood < rateLakewood && rateRidgewood < rateBridgewood) || (rateLakewood == rateRidgewood && rateRidgewood < rateBridgewood) || (rateBridgewood == rateRidgewood && rateRidgewood < rateLakewood))
            {
                Console.WriteLine("Best hotel for your stay is " + HotelType.RIDGEWOOD + ", Rating: " + ridgewood.RATING + ", Cost of stay: " + rateRidgewood);
            }
        }

        /// <summary>
        /// Finds best hotel according to rating
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        public void FindBestRatedHotel(string startDate, string endDate, CustomerType customerType)
        {
            //initialization
            HotelType hotelType = HotelType.LAKEWOOD;
            //parameterized constructor
            Hotel lakewood = new Hotel(hotelType, customerType);
            //finds rate of hotel from given startdate to enddate
            double rateLakewood = lakewood.FindRate(startDate, endDate);
            //initialization
            hotelType = HotelType.BRIDGEWOOD;
            //parameterized constructor
            Hotel bridgewood = new Hotel(hotelType, customerType);
            //finds rate of hotel from given startdate to enddate
            double rateBridgewood = bridgewood.FindRate(startDate, endDate);
            //initialization
            hotelType = HotelType.RIDGEWOOD;
            //parameterized constructor
            Hotel ridgewood = new Hotel(hotelType, customerType);
            //finds rate of hotel from given startdate to enddate
            double rateRidgewood = ridgewood.FindRate(startDate, endDate);
            if (lakewood.RATING > bridgewood.RATING && lakewood.RATING > ridgewood.RATING)
                Console.WriteLine("Best hotel for your stay is " + HotelType.LAKEWOOD + ", Rating: " + lakewood.RATING + ", Cost of stay: " + rateLakewood);
            if (bridgewood.RATING > lakewood.RATING && bridgewood.RATING > ridgewood.RATING)
                Console.WriteLine("Best hotel for your stay is " + HotelType.BRIDGEWOOD + ", Rating: " + bridgewood.RATING + ", Cost of stay: " + rateBridgewood);
            if (ridgewood.RATING > lakewood.RATING && ridgewood.RATING > bridgewood.RATING)
                Console.WriteLine("Best hotel for your stay is " + HotelType.RIDGEWOOD + ", Rating: " + ridgewood.RATING + ", Cost of stay: " + rateRidgewood);
        }
    }
}