using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class Hotel
    {
        //hotel name
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
    }
}