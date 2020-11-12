using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        //hotel type
        HotelType type;

        //Rate for Regular Customer
        public double RATE { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hotel"/> class.
        /// </summary>
        /// <param name="hotelType">Type of the hotel.</param>
        /// <exception cref="HotelReservationException">Invalid Hotel Type</exception>
        public Hotel(HotelType hotelType)
        {
            this.type = hotelType;
            try
            {
                if (hotelType.Equals(HotelType.LAKEWOOD))
                {
                    this.RATE = 110;
                }
                if (hotelType.Equals(HotelType.BRIDGEWOOD))
                {
                    this.RATE = 150;
                }
                if (hotelType.Equals(HotelType.RIDGEWOOD))
                {
                    this.RATE = 220;
                }
            }
            catch (HotelReservationException)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_HOTEL_TYPE, "Invalid Hotel Type");
            }
        }

        /// <summary>
        /// Finds the total cost.
        /// </summary>
        /// <param name="startDateString">The start date string.</param>
        /// <param name="endDateString">The end date string.</param>
        /// <returns></returns>
        /// <exception cref="HotelReservationException">Invalid date entered</exception>
        public double FindTotalCost(string startDateString, string endDateString)
        {
            //variable
            double TotalCost = 0;
            try
            {
                //converts the start date and time value to an equivalent string representation of date and time
                DateTime startDate = Convert.ToDateTime(startDateString);
                //converts the end date and time value to an equivalent string representation of date and time
                DateTime endDate = Convert.ToDateTime(endDateString);
                //finding difference of days between dates
                int days = (int)((endDate - startDate).TotalDays);
                TotalCost = days * this.RATE;
            }
            catch (Exception)
            {
                throw new HotelReservationException(HotelReservationException.ExceptionType.INVALID_DATE, "Invalid date entered");
            }
            return TotalCost;
        }
    }
}
